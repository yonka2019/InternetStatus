using System;
using System.Windows.Forms;

namespace InternetStatus
{
    public partial class Settings : Form
    {
        private readonly MainForm f;
        public Settings(MainForm form)
        {
            InitializeComponent();
            f = form;
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            TB_DGateway.Text = (Internet.DefaultGateway ?? System.Net.IPAddress.Parse("0.0.0.0")).ToString();
            TB_Host.Text = Properties.Settings.Default.Host;
            NUM_Timeout.Value = Properties.Settings.Default.Timeout;
            NUM_UpdateFreq.Value = Properties.Settings.Default.UpdateFreq;
        }

        private void B_Apply_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Host = TB_Host.Text;
            Properties.Settings.Default.Timeout = (int)NUM_Timeout.Value;
            Properties.Settings.Default.UpdateFreq = (int)NUM_UpdateFreq.Value;

            Properties.Settings.Default.Save();

            f.UpdateHost();
            Close();
        }

        private void B_Host_Reset_Click(object sender, EventArgs e) =>
            TB_Host.Text = "8.8.8.8";

        private void B_Timeout_Reset_Click(object sender, EventArgs e) =>
            NUM_Timeout.Value = 2000;

        private void B_UpdateFreq_Reset_Click(object sender, EventArgs e) =>
            NUM_UpdateFreq.Value = 500;
    }
}
