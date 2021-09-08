﻿using System;
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
        private readonly double[] pingArray = new double[60];
        private readonly Ping ping = new Ping();
        private bool working = false;

        public MainForm()
        {
            InitializeComponent();
        }

        internal void UpdateHost() =>
            PingChart.Titles["HostName"].Text = $"Host: {Properties.Settings.Default.Host}";

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
            switch (connection)
            {
                case Connections.PC:
                    InternetStatusT = "Network is unreachable";
                    PicPC.Image = Properties.Resources.PC_on;
                    PicConnection1.Image = Properties.Resources.Connection_off;
                    PicRouter.Image = Properties.Resources.Router_off;
                    PicConnection2.Image = Properties.Resources.Connection_off;
                    PicInternet.Image = Properties.Resources.Internet_off;
                    break;

                case Connections.Router:
                    InternetStatusT = "No Internet";
                    PicPC.Image = Properties.Resources.PC_on;
                    PicConnection1.Image = Properties.Resources.Connection_on;
                    PicRouter.Image = Properties.Resources.Router_on;
                    PicConnection2.Image = Properties.Resources.Connection_off;
                    PicInternet.Image = Properties.Resources.Internet_off;
                    break;

                case Connections.Internet:
                    InternetStatusT = "Connected";
                    PicPC.Image = Properties.Resources.PC_on;
                    PicConnection1.Image = Properties.Resources.Connection_on;
                    PicRouter.Image = Properties.Resources.Router_on;
                    PicConnection2.Image = Properties.Resources.Connection_on;
                    PicInternet.Image = Properties.Resources.Internet_on;
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
                        UpdateHost();
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
                            else if (reply.RoundtripTime > 89 && reply.RoundtripTime < 150)
                                L_Ping.ForeColor = Color.Orange;
                            else
                                L_Ping.ForeColor = Color.Green;
                            if (reply.Status == IPStatus.TimedOut)
                                L_Ping.Text = $"{Properties.Settings.Default.Timeout}+ ms";
                            else
                                L_Ping.Text = $"{reply.RoundtripTime} ms";

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
                        PingChart.Titles["HostName"].Text = $"Default Gateway: {Internet.DefaultGateway ?? System.Net.IPAddress.Parse("0.0.0.0")}";
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
                PingChart.Series["Ping (ms)"].Points.AddY(pingArray[i]);
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
            UpdateHost();
            B_Start.PerformClick();
        }
        private string InternetStatusT
        {
            set
            {
                Invoke((MethodInvoker)delegate
                {
                    Text = $"Internet Status ({value})";
                });
            }
        }
    }
}
