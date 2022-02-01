
namespace InternetStatus
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.PingChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.B_Clean = new System.Windows.Forms.Button();
            this.L_Ping = new System.Windows.Forms.Label();
            this.L_PingTitle = new System.Windows.Forms.Label();
            this.L_Sep = new System.Windows.Forms.Label();
            this.tp = new System.Windows.Forms.ToolTip(this.components);
            this.CPPB = new System.Windows.Forms.PictureBox();
            this.B_Start = new System.Windows.Forms.Button();
            this.B_Settings = new System.Windows.Forms.Button();
            this.PicInternet = new System.Windows.Forms.PictureBox();
            this.PicRouter = new System.Windows.Forms.PictureBox();
            this.PicPC = new System.Windows.Forms.PictureBox();
            this.L_DGateway_Address = new System.Windows.Forms.Label();
            this.PicConnection1 = new System.Windows.Forms.PictureBox();
            this.PicConnection2 = new System.Windows.Forms.PictureBox();
            this.L_PC_Address = new System.Windows.Forms.Label();
            this.L_Host_Address = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PingChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CPPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicInternet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicRouter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicPC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicConnection1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicConnection2)).BeginInit();
            this.SuspendLayout();
            // 
            // PingChart
            // 
            chartArea2.AxisX.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea2.Name = "ChartArea1";
            this.PingChart.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.PingChart.Legends.Add(legend2);
            this.PingChart.Location = new System.Drawing.Point(0, 161);
            this.PingChart.Name = "PingChart";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Legend = "Legend1";
            series2.Name = "Ping (ms)";
            series2.YAxisType = System.Windows.Forms.DataVisualization.Charting.AxisType.Secondary;
            this.PingChart.Series.Add(series2);
            this.PingChart.Size = new System.Drawing.Size(827, 368);
            this.PingChart.TabIndex = 6;
            // 
            // B_Clean
            // 
            this.B_Clean.Font = new System.Drawing.Font("Open Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.B_Clean.Location = new System.Drawing.Point(706, 462);
            this.B_Clean.Name = "B_Clean";
            this.B_Clean.Size = new System.Drawing.Size(108, 44);
            this.B_Clean.TabIndex = 9;
            this.B_Clean.Text = "Clean";
            this.B_Clean.UseVisualStyleBackColor = true;
            this.B_Clean.Click += new System.EventHandler(this.B_Clean_Click);
            // 
            // L_Ping
            // 
            this.L_Ping.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.L_Ping.AutoSize = true;
            this.L_Ping.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.L_Ping.Location = new System.Drawing.Point(411, 127);
            this.L_Ping.Name = "L_Ping";
            this.L_Ping.Size = new System.Drawing.Size(60, 26);
            this.L_Ping.TabIndex = 13;
            this.L_Ping.Text = "0 ms";
            this.L_Ping.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // L_PingTitle
            // 
            this.L_PingTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.L_PingTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.L_PingTitle.Location = new System.Drawing.Point(355, 125);
            this.L_PingTitle.Name = "L_PingTitle";
            this.L_PingTitle.Size = new System.Drawing.Size(62, 26);
            this.L_PingTitle.TabIndex = 12;
            this.L_PingTitle.Text = "Ping:";
            this.L_PingTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // L_Sep
            // 
            this.L_Sep.Location = new System.Drawing.Point(260, 115);
            this.L_Sep.Name = "L_Sep";
            this.L_Sep.Size = new System.Drawing.Size(307, 10);
            this.L_Sep.TabIndex = 14;
            this.L_Sep.Text = "――――――――――――――――――――――――――――――――――――――――――――――――――――";
            // 
            // CPPB
            // 
            this.CPPB.Image = global::InternetStatus.Properties.Resources.Copyright;
            this.CPPB.Location = new System.Drawing.Point(12, 125);
            this.CPPB.Name = "CPPB";
            this.CPPB.Size = new System.Drawing.Size(30, 30);
            this.CPPB.TabIndex = 15;
            this.CPPB.TabStop = false;
            this.tp.SetToolTip(this.CPPB, "By Yonka");
            // 
            // B_Start
            // 
            this.B_Start.Image = global::InternetStatus.Properties.Resources.Start;
            this.B_Start.Location = new System.Drawing.Point(740, 261);
            this.B_Start.Name = "B_Start";
            this.B_Start.Size = new System.Drawing.Size(40, 40);
            this.B_Start.TabIndex = 11;
            this.tp.SetToolTip(this.B_Start, "Start");
            this.B_Start.UseVisualStyleBackColor = true;
            this.B_Start.Click += new System.EventHandler(this.B_Start_Click);
            // 
            // B_Settings
            // 
            this.B_Settings.Image = global::InternetStatus.Properties.Resources.Settings;
            this.B_Settings.Location = new System.Drawing.Point(740, 356);
            this.B_Settings.Name = "B_Settings";
            this.B_Settings.Size = new System.Drawing.Size(40, 40);
            this.B_Settings.TabIndex = 10;
            this.tp.SetToolTip(this.B_Settings, "Settings");
            this.B_Settings.UseVisualStyleBackColor = true;
            this.B_Settings.Click += new System.EventHandler(this.B_Settings_Click);
            // 
            // PicInternet
            // 
            this.PicInternet.Image = global::InternetStatus.Properties.Resources.Internet_off;
            this.PicInternet.Location = new System.Drawing.Point(673, 12);
            this.PicInternet.Name = "PicInternet";
            this.PicInternet.Size = new System.Drawing.Size(75, 75);
            this.PicInternet.TabIndex = 2;
            this.PicInternet.TabStop = false;
            this.tp.SetToolTip(this.PicInternet, "Internet");
            // 
            // PicRouter
            // 
            this.PicRouter.Image = global::InternetStatus.Properties.Resources.Router_off;
            this.PicRouter.Location = new System.Drawing.Point(376, 12);
            this.PicRouter.Name = "PicRouter";
            this.PicRouter.Size = new System.Drawing.Size(75, 75);
            this.PicRouter.TabIndex = 1;
            this.PicRouter.TabStop = false;
            this.tp.SetToolTip(this.PicRouter, "Default Gateway");
            this.PicRouter.Click += new System.EventHandler(this.Open_Gateway_web);
            // 
            // PicPC
            // 
            this.PicPC.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.PicPC.Image = ((System.Drawing.Image)(resources.GetObject("PicPC.Image")));
            this.PicPC.Location = new System.Drawing.Point(78, 12);
            this.PicPC.Name = "PicPC";
            this.PicPC.Size = new System.Drawing.Size(75, 75);
            this.PicPC.TabIndex = 0;
            this.PicPC.TabStop = false;
            this.tp.SetToolTip(this.PicPC, "This PC");
            this.PicPC.Click += new System.EventHandler(this.Open_ncpa_cpl);
            // 
            // L_DGateway_Address
            // 
            this.L_DGateway_Address.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.L_DGateway_Address.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.L_DGateway_Address.Location = new System.Drawing.Point(320, 90);
            this.L_DGateway_Address.Name = "L_DGateway_Address";
            this.L_DGateway_Address.Size = new System.Drawing.Size(186, 19);
            this.L_DGateway_Address.TabIndex = 20;
            this.L_DGateway_Address.Text = "Address";
            this.L_DGateway_Address.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tp.SetToolTip(this.L_DGateway_Address, "(Open)");
            this.L_DGateway_Address.Click += new System.EventHandler(this.Open_Gateway_web);
            // 
            // PicConnection1
            // 
            this.PicConnection1.Image = ((System.Drawing.Image)(resources.GetObject("PicConnection1.Image")));
            this.PicConnection1.Location = new System.Drawing.Point(243, 22);
            this.PicConnection1.Name = "PicConnection1";
            this.PicConnection1.Size = new System.Drawing.Size(55, 55);
            this.PicConnection1.TabIndex = 8;
            this.PicConnection1.TabStop = false;
            // 
            // PicConnection2
            // 
            this.PicConnection2.Image = ((System.Drawing.Image)(resources.GetObject("PicConnection2.Image")));
            this.PicConnection2.Location = new System.Drawing.Point(529, 22);
            this.PicConnection2.Name = "PicConnection2";
            this.PicConnection2.Size = new System.Drawing.Size(55, 55);
            this.PicConnection2.TabIndex = 7;
            this.PicConnection2.TabStop = false;
            // 
            // L_PC_Address
            // 
            this.L_PC_Address.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.L_PC_Address.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.L_PC_Address.Location = new System.Drawing.Point(22, 90);
            this.L_PC_Address.Name = "L_PC_Address";
            this.L_PC_Address.Size = new System.Drawing.Size(186, 19);
            this.L_PC_Address.TabIndex = 21;
            this.L_PC_Address.Text = "Address";
            this.L_PC_Address.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.L_PC_Address.Click += new System.EventHandler(this.Open_ncpa_cpl);
            // 
            // L_Host_Address
            // 
            this.L_Host_Address.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.L_Host_Address.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.L_Host_Address.Location = new System.Drawing.Point(617, 90);
            this.L_Host_Address.Name = "L_Host_Address";
            this.L_Host_Address.Size = new System.Drawing.Size(186, 19);
            this.L_Host_Address.TabIndex = 22;
            this.L_Host_Address.Text = "Address";
            this.L_Host_Address.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 528);
            this.Controls.Add(this.L_Host_Address);
            this.Controls.Add(this.L_PC_Address);
            this.Controls.Add(this.L_DGateway_Address);
            this.Controls.Add(this.CPPB);
            this.Controls.Add(this.L_Sep);
            this.Controls.Add(this.L_Ping);
            this.Controls.Add(this.L_PingTitle);
            this.Controls.Add(this.B_Start);
            this.Controls.Add(this.B_Settings);
            this.Controls.Add(this.B_Clean);
            this.Controls.Add(this.PicConnection1);
            this.Controls.Add(this.PicConnection2);
            this.Controls.Add(this.PingChart);
            this.Controls.Add(this.PicInternet);
            this.Controls.Add(this.PicRouter);
            this.Controls.Add(this.PicPC);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Opacity = 0.97D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Internet Status";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PingChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CPPB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicInternet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicRouter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicPC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicConnection1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicConnection2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PicPC;
        private System.Windows.Forms.PictureBox PicRouter;
        private System.Windows.Forms.PictureBox PicInternet;
        private System.Windows.Forms.DataVisualization.Charting.Chart PingChart;
        private System.Windows.Forms.PictureBox PicConnection2;
        private System.Windows.Forms.PictureBox PicConnection1;
        private System.Windows.Forms.Button B_Start;
        private System.Windows.Forms.Button B_Settings;
        private System.Windows.Forms.Button B_Clean;
        private System.Windows.Forms.Label L_Ping;
        private System.Windows.Forms.Label L_PingTitle;
        private System.Windows.Forms.Label L_Sep;
        private System.Windows.Forms.ToolTip tp;
        private System.Windows.Forms.PictureBox CPPB;
        private System.Windows.Forms.Label L_DGateway_Address;
        private System.Windows.Forms.Label L_PC_Address;
        private System.Windows.Forms.Label L_Host_Address;
    }
}

