﻿
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.PingChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.B_Clean = new System.Windows.Forms.Button();
            this.L_Ping = new System.Windows.Forms.Label();
            this.L_PingTitle = new System.Windows.Forms.Label();
            this.L_Sep = new System.Windows.Forms.Label();
            this.tp = new System.Windows.Forms.ToolTip(this.components);
            this.B_Start = new System.Windows.Forms.Button();
            this.B_Settings = new System.Windows.Forms.Button();
            this.PicConnection1 = new System.Windows.Forms.PictureBox();
            this.PicConnection2 = new System.Windows.Forms.PictureBox();
            this.PicInternet = new System.Windows.Forms.PictureBox();
            this.PicRouter = new System.Windows.Forms.PictureBox();
            this.PicPC = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PingChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicConnection1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicConnection2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicInternet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicRouter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicPC)).BeginInit();
            this.SuspendLayout();
            // 
            // PingChart
            // 
            chartArea1.AxisX.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea1.Name = "ChartArea1";
            this.PingChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.PingChart.Legends.Add(legend1);
            this.PingChart.Location = new System.Drawing.Point(0, 141);
            this.PingChart.Name = "PingChart";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.Name = "Ping (ms)";
            series1.YAxisType = System.Windows.Forms.DataVisualization.Charting.AxisType.Secondary;
            this.PingChart.Series.Add(series1);
            this.PingChart.Size = new System.Drawing.Size(827, 359);
            this.PingChart.TabIndex = 6;
            title1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            title1.Name = "HostName";
            title1.Text = "Host:";
            this.PingChart.Titles.Add(title1);
            // 
            // B_Clean
            // 
            this.B_Clean.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.B_Clean.Location = new System.Drawing.Point(706, 427);
            this.B_Clean.Name = "B_Clean";
            this.B_Clean.Size = new System.Drawing.Size(108, 44);
            this.B_Clean.TabIndex = 9;
            this.B_Clean.Text = "Clean";
            this.B_Clean.UseVisualStyleBackColor = true;
            this.B_Clean.Click += new System.EventHandler(this.B_Clean_Click);
            // 
            // L_Ping
            // 
            this.L_Ping.AutoSize = true;
            this.L_Ping.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.L_Ping.Location = new System.Drawing.Point(412, 107);
            this.L_Ping.Name = "L_Ping";
            this.L_Ping.Size = new System.Drawing.Size(60, 26);
            this.L_Ping.TabIndex = 13;
            this.L_Ping.Text = "0 ms";
            this.L_Ping.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // L_PingTitle
            // 
            this.L_PingTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.L_PingTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.L_PingTitle.Location = new System.Drawing.Point(356, 105);
            this.L_PingTitle.Name = "L_PingTitle";
            this.L_PingTitle.Size = new System.Drawing.Size(62, 26);
            this.L_PingTitle.TabIndex = 12;
            this.L_PingTitle.Text = "Ping:";
            this.L_PingTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // L_Sep
            // 
            this.L_Sep.Location = new System.Drawing.Point(260, 97);
            this.L_Sep.Name = "L_Sep";
            this.L_Sep.Size = new System.Drawing.Size(307, 10);
            this.L_Sep.TabIndex = 14;
            this.L_Sep.Text = "――――――――――――――――――――――――――――――――――――――――――――――――――――";
            // 
            // B_Start
            // 
            this.B_Start.Image = global::InternetStatus.Properties.Resources.Start;
            this.B_Start.Location = new System.Drawing.Point(740, 231);
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
            this.B_Settings.Location = new System.Drawing.Point(740, 318);
            this.B_Settings.Name = "B_Settings";
            this.B_Settings.Size = new System.Drawing.Size(40, 40);
            this.B_Settings.TabIndex = 10;
            this.tp.SetToolTip(this.B_Settings, "Settings");
            this.B_Settings.UseVisualStyleBackColor = true;
            this.B_Settings.Click += new System.EventHandler(this.B_Settings_Click);
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
            // PicInternet
            // 
            this.PicInternet.Image = global::InternetStatus.Properties.Resources.Internet_off;
            this.PicInternet.Location = new System.Drawing.Point(673, 12);
            this.PicInternet.Name = "PicInternet";
            this.PicInternet.Size = new System.Drawing.Size(75, 75);
            this.PicInternet.TabIndex = 2;
            this.PicInternet.TabStop = false;
            // 
            // PicRouter
            // 
            this.PicRouter.Image = global::InternetStatus.Properties.Resources.Router_off;
            this.PicRouter.Location = new System.Drawing.Point(376, 12);
            this.PicRouter.Name = "PicRouter";
            this.PicRouter.Size = new System.Drawing.Size(75, 75);
            this.PicRouter.TabIndex = 1;
            this.PicRouter.TabStop = false;
            // 
            // PicPC
            // 
            this.PicPC.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.PicPC.Image = ((System.Drawing.Image)(resources.GetObject("PicPC.Image")));
            this.PicPC.Location = new System.Drawing.Point(79, 12);
            this.PicPC.Name = "PicPC";
            this.PicPC.Size = new System.Drawing.Size(75, 75);
            this.PicPC.TabIndex = 0;
            this.PicPC.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 499);
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
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Internet Status";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PingChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicConnection1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicConnection2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicInternet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicRouter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicPC)).EndInit();
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
    }
}

