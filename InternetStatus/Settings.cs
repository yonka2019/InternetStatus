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

            f.UpdateData();
            Close();
        }

        private void B_Host_Reset_Click(object sender, EventArgs e) =>
            TB_Host.Text = Internet.Default_Host;

        private void B_Timeout_Reset_Click(object sender, EventArgs e) =>
            NUM_Timeout.Value = Internet.Default_Timeout;

        private void B_UpdateFreq_Reset_Click(object sender, EventArgs e) =>
            NUM_UpdateFreq.Value = Internet.Default_UpdateFreq;
    }
}
