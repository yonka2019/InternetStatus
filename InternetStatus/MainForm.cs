using darknet.forms;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Net.NetworkInformation;
using System.Threading;
using System.Windows.Forms;

/*
* - - - - - - - - - - - - -
*       Author: Yonka
*       Date: 08.09.2021
* - - - - - - - - - - - - -
*/

namespace InternetStatus
{
    public partial class MainForm : Form
    {
        public static bool darkModeActivated = false;
        private readonly double[] pingArray = new double[60];
        private readonly Ping ping = new Ping();
        private bool working = false;

        private const string ON_BLACK_HEX_COLOR = "#FF000000";
        private const string OFF_GRAY_HEX_COLOR = "#FF848484";
        private const string VERSION = "1.1";

        public MainForm()
        {
            InitializeComponent();
            tp.SetToolTip(CPPB, $"{tp.GetToolTip(CPPB)} (v{VERSION})");
        }

        public MainForm(bool darkModeActivated) : this()// dark mode changed
        {
            if (darkModeActivated)
            {
                DarkModeButton.Image = Properties.Resources.sun_25px;
                tp.SetToolTip(DarkModeButton, "Disable Dark mode");
            }
            else
            {
                DarkModeButton.Image = Properties.Resources.first_quarter_25px;
                tp.SetToolTip(DarkModeButton, "Enable Dark mode");
            }
        }

        internal void UpdateData()
        {
            Invoke((MethodInvoker)delegate
            {
                L_PC_Address.Text = Internet.LocalAddress == null ? "" : Internet.LocalAddress.ToString();
                L_DGateway_Address.Text = Internet.DefaultGateway == null ? "" : Internet.DefaultGateway.ToString();
                L_Host_Address.Text = Properties.Settings.Default.Host;
            });
        }

        private void B_Start_Click(object sender, EventArgs e)
        {
            working = !working;
            if (working)
            {
                B_Start.Image = Properties.Resources.Stop;
                tp.SetToolTip(B_Start, "Stop");
                new Thread(Pinger).Start();
            }
            else
            {
                B_Start.Image = Properties.Resources.Start;
                tp.SetToolTip(B_Start, "Start");
            }
        }
        private void DrawConnection(Connections connection)
        {
            UpdateData();
            switch (connection)
            {
                case Connections.PC:
                    InternetStatusT = "Network is unreachable";
                    PicPC.Image = Properties.Resources.PC_on;
                    PicConnection1.Image = Properties.Resources.Connection_off;
                    L_Host_Address.ForeColor = ColorTranslator.FromHtml(OFF_GRAY_HEX_COLOR);

                    PicRouter.Image = Properties.Resources.Router_off;
                    PicConnection2.Image = Properties.Resources.Connection_off;
                    L_Host_Address.ForeColor = ColorTranslator.FromHtml(OFF_GRAY_HEX_COLOR);

                    PicInternet.Image = Properties.Resources.Internet_off;
                    L_Host_Address.ForeColor = ColorTranslator.FromHtml(OFF_GRAY_HEX_COLOR);
                    break;

                case Connections.Router:
                    InternetStatusT = "No connection";
                    PicPC.Image = Properties.Resources.PC_on;
                    PicConnection1.Image = Properties.Resources.Connection_on;
                    L_Host_Address.ForeColor = ColorTranslator.FromHtml(ON_BLACK_HEX_COLOR);

                    PicRouter.Image = Properties.Resources.Router_on;
                    PicConnection2.Image = Properties.Resources.Connection_on;
                    L_Host_Address.ForeColor = ColorTranslator.FromHtml(ON_BLACK_HEX_COLOR);

                    PicInternet.Image = Properties.Resources.Internet_off;
                    L_Host_Address.ForeColor = ColorTranslator.FromHtml(OFF_GRAY_HEX_COLOR);
                    break;

                case Connections.Internet:
                    InternetStatusT = "Connected";
                    PicPC.Image = Properties.Resources.PC_on;
                    PicConnection1.Image = Properties.Resources.Connection_on;
                    L_Host_Address.ForeColor = ColorTranslator.FromHtml(ON_BLACK_HEX_COLOR);

                    PicRouter.Image = Properties.Resources.Router_on;
                    PicConnection2.Image = Properties.Resources.Connection_on;
                    L_Host_Address.ForeColor = ColorTranslator.FromHtml(ON_BLACK_HEX_COLOR);

                    PicInternet.Image = Properties.Resources.Internet_on;
                    L_Host_Address.ForeColor = ColorTranslator.FromHtml(ON_BLACK_HEX_COLOR);
                    break;
            }
        }

        private void Pinger()
        {
            while (working)
            {
                if (Internet.TryDefaultGateway(ping))
                {
                    Invoke((MethodInvoker)delegate
                    {
                        L_PingTitle.Visible = true;
                        L_Ping.Visible = true;
                    });
                    try
                    {
                        PingReply reply = ping.Send(Properties.Settings.Default.Host, Properties.Settings.Default.Timeout);

                        if (reply.Status == IPStatus.Success)
                            DrawConnection(Connections.Internet);
                        else
                            DrawConnection(Connections.Router);

                        pingArray[pingArray.Length - 1] = reply.RoundtripTime;

                        Array.Copy(pingArray, 1, pingArray, 0, pingArray.Length - 1);

                        Invoke((MethodInvoker)delegate
                        {
                            if (reply.RoundtripTime > 149 || reply.RoundtripTime == 0)
                                L_Ping.ForeColor = Color.Red;
                            else L_Ping.ForeColor = reply.RoundtripTime > 89 && reply.RoundtripTime < 150 ? Color.Orange : Color.Green;

                            L_Ping.Text = reply.Status == IPStatus.TimedOut ? $"{Properties.Settings.Default.Timeout}+ ms" : $"{reply.RoundtripTime} ms";

                            UpdatePingChart();
                        });
                    }
                    catch
                    {
                        Invoke((MethodInvoker)delegate
                        {
                            L_Ping.ForeColor = Color.Red;
                            L_Ping.Text = "0 ms";
                        });
                    }
                }
                else
                {
                    DrawConnection(Connections.PC);
                    Invoke((MethodInvoker)delegate
                    {
                        L_PingTitle.Visible = false;
                        L_Ping.Visible = false;
                        B_Clean.PerformClick();
                    });
                }
                Thread.Sleep(Properties.Settings.Default.UpdateFreq);
            }
        }

        private void UpdatePingChart()
        {
            PingChart.Series["Ping (ms)"].Points.Clear();
            for (int i = 0; i < pingArray.Length - 1; i++)
            {
                PingChart.Series["Ping (ms)"].Points.AddY(pingArray[i]);
            }
        }

        private void B_Settings_Click(object sender, EventArgs e)
        {
            Settings form = new Settings(this);
            form.ShowDialog();
        }

        private void B_Clean_Click(object sender, EventArgs e)
        {
            Array.Clear(pingArray, 0, pingArray.Length);
            PingChart.Series["Ping (ms)"].Points.Clear();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            working = false;
            Environment.Exit(0);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            UpdateData();
            B_Start.PerformClick();
        }

        private string InternetStatusT
        {
            set => Invoke((MethodInvoker)delegate
                 {
                     Text = $"Internet Status ({value})";
                 });
        }

        private void Open_Gateway_web(object sender, EventArgs e)
        {
            Process.Start("http://" + Internet.DefaultGateway.ToString());
        }

        private void Open_ncpa_cpl(object sender, EventArgs e)
        {
            ProcessStartInfo info = new ProcessStartInfo("ncpa.cpl")
            {
                UseShellExecute = true
            };
            Process.Start(info);
        }

        private void DarkModeButton_Click(object sender, EventArgs e)
        {
            darkModeActivated = !darkModeActivated;

            MainForm form = new MainForm(darkModeActivated);
            DarkNet.SetDarkModeAllowedForWindow(form, darkModeActivated);
            Hide();
            form.ShowDialog();
            Close();
        }
    }
}
