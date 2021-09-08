
namespace InternetStatus
{
    partial class Settings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            this.L_Host = new System.Windows.Forms.Label();
            this.L_Timeout = new System.Windows.Forms.Label();
            this.L_UF = new System.Windows.Forms.Label();
            this.TB_Host = new System.Windows.Forms.TextBox();
            this.NUM_Timeout = new System.Windows.Forms.NumericUpDown();
            this.NUM_UpdateFreq = new System.Windows.Forms.NumericUpDown();
            this.B_Apply = new System.Windows.Forms.Button();
            this.tp = new System.Windows.Forms.ToolTip(this.components);
            this.TB_DGateway = new System.Windows.Forms.TextBox();
            this.L_DGateway = new System.Windows.Forms.Label();
            this.B_Host_Reset = new System.Windows.Forms.Button();
            this.B_UpdateFreq_Reset = new System.Windows.Forms.Button();
            this.B_Timeout_Reset = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.NUM_Timeout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUM_UpdateFreq)).BeginInit();
            this.SuspendLayout();
            // 
            // L_Host
            // 
            this.L_Host.AutoSize = true;
            this.L_Host.Font = new System.Drawing.Font("Open Sans", 12F);
            this.L_Host.Location = new System.Drawing.Point(188, 61);
            this.L_Host.Name = "L_Host";
            this.L_Host.Size = new System.Drawing.Size(50, 22);
            this.L_Host.TabIndex = 0;
            this.L_Host.Text = "Host:";
            // 
            // L_Timeout
            // 
            this.L_Timeout.AutoSize = true;
            this.L_Timeout.Font = new System.Drawing.Font("Open Sans", 12F);
            this.L_Timeout.Location = new System.Drawing.Point(161, 94);
            this.L_Timeout.Name = "L_Timeout";
            this.L_Timeout.Size = new System.Drawing.Size(77, 22);
            this.L_Timeout.TabIndex = 1;
            this.L_Timeout.Text = "Timeout:";
            // 
            // L_UF
            // 
            this.L_UF.AutoSize = true;
            this.L_UF.Font = new System.Drawing.Font("Open Sans", 12F);
            this.L_UF.Location = new System.Drawing.Point(51, 128);
            this.L_UF.Name = "L_UF";
            this.L_UF.Size = new System.Drawing.Size(187, 22);
            this.L_UF.TabIndex = 2;
            this.L_UF.Text = "Update frequency (ms):";
            // 
            // TB_Host
            // 
            this.TB_Host.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TB_Host.Location = new System.Drawing.Point(240, 56);
            this.TB_Host.Name = "TB_Host";
            this.TB_Host.Size = new System.Drawing.Size(114, 29);
            this.TB_Host.TabIndex = 3;
            // 
            // NUM_Timeout
            // 
            this.NUM_Timeout.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NUM_Timeout.Location = new System.Drawing.Point(240, 91);
            this.NUM_Timeout.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.NUM_Timeout.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.NUM_Timeout.Name = "NUM_Timeout";
            this.NUM_Timeout.Size = new System.Drawing.Size(114, 29);
            this.NUM_Timeout.TabIndex = 4;
            this.NUM_Timeout.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // NUM_UpdateFreq
            // 
            this.NUM_UpdateFreq.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NUM_UpdateFreq.Location = new System.Drawing.Point(240, 126);
            this.NUM_UpdateFreq.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.NUM_UpdateFreq.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.NUM_UpdateFreq.Name = "NUM_UpdateFreq";
            this.NUM_UpdateFreq.Size = new System.Drawing.Size(114, 29);
            this.NUM_UpdateFreq.TabIndex = 5;
            this.NUM_UpdateFreq.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // B_Apply
            // 
            this.B_Apply.Font = new System.Drawing.Font("Open Sans", 12F);
            this.B_Apply.Location = new System.Drawing.Point(156, 177);
            this.B_Apply.Name = "B_Apply";
            this.B_Apply.Size = new System.Drawing.Size(132, 40);
            this.B_Apply.TabIndex = 6;
            this.B_Apply.Text = "Apply";
            this.B_Apply.UseVisualStyleBackColor = true;
            this.B_Apply.Click += new System.EventHandler(this.B_Apply_Click);
            // 
            // TB_DGateway
            // 
            this.TB_DGateway.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TB_DGateway.Location = new System.Drawing.Point(240, 21);
            this.TB_DGateway.Name = "TB_DGateway";
            this.TB_DGateway.ReadOnly = true;
            this.TB_DGateway.Size = new System.Drawing.Size(149, 29);
            this.TB_DGateway.TabIndex = 13;
            // 
            // L_DGateway
            // 
            this.L_DGateway.AutoSize = true;
            this.L_DGateway.Font = new System.Drawing.Font("Open Sans", 12F);
            this.L_DGateway.Location = new System.Drawing.Point(100, 24);
            this.L_DGateway.Name = "L_DGateway";
            this.L_DGateway.Size = new System.Drawing.Size(138, 22);
            this.L_DGateway.TabIndex = 12;
            this.L_DGateway.Text = "Default Gateway:";
            // 
            // B_Host_Reset
            // 
            this.B_Host_Reset.Image = global::InternetStatus.Properties.Resources.Reset;
            this.B_Host_Reset.Location = new System.Drawing.Point(360, 56);
            this.B_Host_Reset.Name = "B_Host_Reset";
            this.B_Host_Reset.Size = new System.Drawing.Size(29, 29);
            this.B_Host_Reset.TabIndex = 9;
            this.tp.SetToolTip(this.B_Host_Reset, "Reset (8.8.8.8)");
            this.B_Host_Reset.UseVisualStyleBackColor = true;
            this.B_Host_Reset.Click += new System.EventHandler(this.B_Host_Reset_Click);
            // 
            // B_UpdateFreq_Reset
            // 
            this.B_UpdateFreq_Reset.Image = global::InternetStatus.Properties.Resources.Reset;
            this.B_UpdateFreq_Reset.Location = new System.Drawing.Point(360, 126);
            this.B_UpdateFreq_Reset.Name = "B_UpdateFreq_Reset";
            this.B_UpdateFreq_Reset.Size = new System.Drawing.Size(29, 29);
            this.B_UpdateFreq_Reset.TabIndex = 8;
            this.tp.SetToolTip(this.B_UpdateFreq_Reset, "Reset (500)");
            this.B_UpdateFreq_Reset.UseVisualStyleBackColor = true;
            this.B_UpdateFreq_Reset.Click += new System.EventHandler(this.B_UpdateFreq_Reset_Click);
            // 
            // B_Timeout_Reset
            // 
            this.B_Timeout_Reset.Image = global::InternetStatus.Properties.Resources.Reset;
            this.B_Timeout_Reset.Location = new System.Drawing.Point(360, 91);
            this.B_Timeout_Reset.Name = "B_Timeout_Reset";
            this.B_Timeout_Reset.Size = new System.Drawing.Size(29, 29);
            this.B_Timeout_Reset.TabIndex = 7;
            this.tp.SetToolTip(this.B_Timeout_Reset, "Reset (2000)");
            this.B_Timeout_Reset.UseVisualStyleBackColor = true;
            this.B_Timeout_Reset.Click += new System.EventHandler(this.B_Timeout_Reset_Click);
            // 
            // Settings
            // 
            this.AcceptButton = this.B_Apply;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 229);
            this.Controls.Add(this.TB_DGateway);
            this.Controls.Add(this.L_DGateway);
            this.Controls.Add(this.B_Host_Reset);
            this.Controls.Add(this.B_UpdateFreq_Reset);
            this.Controls.Add(this.B_Timeout_Reset);
            this.Controls.Add(this.B_Apply);
            this.Controls.Add(this.NUM_UpdateFreq);
            this.Controls.Add(this.NUM_Timeout);
            this.Controls.Add(this.TB_Host);
            this.Controls.Add(this.L_UF);
            this.Controls.Add(this.L_Timeout);
            this.Controls.Add(this.L_Host);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Settings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Internet Status";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Settings_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NUM_Timeout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUM_UpdateFreq)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label L_Host;
        private System.Windows.Forms.Label L_Timeout;
        private System.Windows.Forms.Label L_UF;
        private System.Windows.Forms.TextBox TB_Host;
        private System.Windows.Forms.NumericUpDown NUM_Timeout;
        private System.Windows.Forms.NumericUpDown NUM_UpdateFreq;
        private System.Windows.Forms.Button B_Apply;
        private System.Windows.Forms.Button B_Timeout_Reset;
        private System.Windows.Forms.Button B_UpdateFreq_Reset;
        private System.Windows.Forms.Button B_Host_Reset;
        private System.Windows.Forms.ToolTip tp;
        private System.Windows.Forms.TextBox TB_DGateway;
        private System.Windows.Forms.Label L_DGateway;
    }
}