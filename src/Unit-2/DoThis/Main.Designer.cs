namespace ChartApp
{
    partial class Main
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.sysChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.BtnCpu = new System.Windows.Forms.Button();
            this.BtnMemory = new System.Windows.Forms.Button();
            this.BtnDisk = new System.Windows.Forms.Button();
            this.btnPauseResume = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.sysChart)).BeginInit();
            this.SuspendLayout();
            // 
            // sysChart
            // 
            chartArea1.Name = "ChartArea1";
            this.sysChart.ChartAreas.Add(chartArea1);
            this.sysChart.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.sysChart.Legends.Add(legend1);
            this.sysChart.Location = new System.Drawing.Point(0, 0);
            this.sysChart.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.sysChart.Name = "sysChart";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.sysChart.Series.Add(series1);
            this.sysChart.Size = new System.Drawing.Size(1824, 1063);
            this.sysChart.TabIndex = 0;
            this.sysChart.Text = "sysChart";
            // 
            // BtnCpu
            // 
            this.BtnCpu.AutoSize = true;
            this.BtnCpu.Location = new System.Drawing.Point(1545, 704);
            this.BtnCpu.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.BtnCpu.Name = "BtnCpu";
            this.BtnCpu.Size = new System.Drawing.Size(180, 73);
            this.BtnCpu.TabIndex = 1;
            this.BtnCpu.Text = "CPU (ON)";
            this.BtnCpu.UseVisualStyleBackColor = true;
            this.BtnCpu.Click += new System.EventHandler(this.BtnCpu_Click);
            // 
            // BtnMemory
            // 
            this.BtnMemory.AutoSize = true;
            this.BtnMemory.Location = new System.Drawing.Point(1545, 798);
            this.BtnMemory.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.BtnMemory.Name = "BtnMemory";
            this.BtnMemory.Size = new System.Drawing.Size(244, 73);
            this.BtnMemory.TabIndex = 2;
            this.BtnMemory.Text = "MEMORY (OFF)";
            this.BtnMemory.UseVisualStyleBackColor = true;
            this.BtnMemory.Click += new System.EventHandler(this.BtnMemory_Click);
            // 
            // BtnDisk
            // 
            this.BtnDisk.AutoSize = true;
            this.BtnDisk.Location = new System.Drawing.Point(1545, 894);
            this.BtnDisk.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.BtnDisk.Name = "BtnDisk";
            this.BtnDisk.Size = new System.Drawing.Size(244, 73);
            this.BtnDisk.TabIndex = 3;
            this.BtnDisk.Text = "DISK (OFF)";
            this.BtnDisk.UseVisualStyleBackColor = true;
            this.BtnDisk.Click += new System.EventHandler(this.BtnDisk_Click);
            // 
            // btnPauseResume
            // 
            this.btnPauseResume.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPauseResume.Location = new System.Drawing.Point(1545, 496);
            this.btnPauseResume.Name = "btnPauseResume";
            this.btnPauseResume.Size = new System.Drawing.Size(244, 73);
            this.btnPauseResume.TabIndex = 4;
            this.btnPauseResume.Text = "PAUSE ||";
            this.btnPauseResume.UseVisualStyleBackColor = true;
            this.btnPauseResume.Click += new System.EventHandler(this.BtnPauseResume_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1824, 1063);
            this.Controls.Add(this.btnPauseResume);
            this.Controls.Add(this.BtnDisk);
            this.Controls.Add(this.BtnMemory);
            this.Controls.Add(this.BtnCpu);
            this.Controls.Add(this.sysChart);
            this.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.Name = "Main";
            this.Text = "System Metrics";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sysChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart sysChart;
        private System.Windows.Forms.Button BtnCpu;
        private System.Windows.Forms.Button BtnMemory;
        private System.Windows.Forms.Button BtnDisk;
        private System.Windows.Forms.Button btnPauseResume;
    }
}

