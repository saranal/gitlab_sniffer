namespace GitLabSniffer
{
    partial class chartsViewer
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
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(chartsViewer));
            this.openedChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.averageChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.button1 = new System.Windows.Forms.Button();
            this.prevBtn = new System.Windows.Forms.Button();
            this.nextBtn = new System.Windows.Forms.Button();
            this.currentGLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.openedChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.averageChart)).BeginInit();
            this.SuspendLayout();
            // 
            // openedChart
            // 
            this.openedChart.BackColor = System.Drawing.Color.MediumSlateBlue;
            chartArea1.AxisX.IsLabelAutoFit = false;
            chartArea1.AxisX.LabelStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea1.AxisX.ScaleView.Size = 7D;
            chartArea1.AxisX.ScrollBar.ButtonStyle = System.Windows.Forms.DataVisualization.Charting.ScrollBarButtonStyles.None;
            chartArea1.AxisX.ScrollBar.Size = 16D;
            chartArea1.AxisX.Title = "Project Names";
            chartArea1.AxisX.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea1.BackColor = System.Drawing.Color.SlateBlue;
            chartArea1.Name = "ChartArea1";
            this.openedChart.ChartAreas.Add(chartArea1);
            legend1.BackColor = System.Drawing.Color.WhiteSmoke;
            legend1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            legend1.IsTextAutoFit = false;
            legend1.Name = "Legend1";
            this.openedChart.Legends.Add(legend1);
            this.openedChart.Location = new System.Drawing.Point(-4, 22);
            this.openedChart.Name = "openedChart";
            series1.ChartArea = "ChartArea1";
            series1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series1.IsValueShownAsLabel = true;
            series1.LabelBackColor = System.Drawing.Color.SkyBlue;
            series1.Legend = "Legend1";
            series1.Name = "#OM";
            this.openedChart.Series.Add(series1);
            this.openedChart.Size = new System.Drawing.Size(1216, 280);
            this.openedChart.TabIndex = 0;
            this.openedChart.Text = "chart1";
            title1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title1.Name = "OpenedTitle";
            title1.Text = "Number of opened merges";
            this.openedChart.Titles.Add(title1);
            // 
            // averageChart
            // 
            this.averageChart.BackColor = System.Drawing.Color.MediumSlateBlue;
            chartArea2.AxisX.IsLabelAutoFit = false;
            chartArea2.AxisX.LabelStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea2.AxisX.ScaleView.Size = 7D;
            chartArea2.AxisX.ScrollBar.ButtonStyle = System.Windows.Forms.DataVisualization.Charting.ScrollBarButtonStyles.None;
            chartArea2.AxisX.ScrollBar.Size = 16D;
            chartArea2.AxisX.Title = "Project Names";
            chartArea2.AxisX.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea2.BackColor = System.Drawing.Color.SlateBlue;
            chartArea2.Name = "ChartArea1";
            this.averageChart.ChartAreas.Add(chartArea2);
            legend2.BackColor = System.Drawing.Color.WhiteSmoke;
            legend2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            legend2.IsTextAutoFit = false;
            legend2.Name = "Legend1";
            this.averageChart.Legends.Add(legend2);
            this.averageChart.Location = new System.Drawing.Point(-4, 323);
            this.averageChart.Name = "averageChart";
            this.averageChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series2.ChartArea = "ChartArea1";
            series2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series2.IsValueShownAsLabel = true;
            series2.LabelBackColor = System.Drawing.Color.DarkSeaGreen;
            series2.Legend = "Legend1";
            series2.Name = "AVG";
            this.averageChart.Series.Add(series2);
            this.averageChart.Size = new System.Drawing.Size(1216, 280);
            this.averageChart.TabIndex = 1;
            this.averageChart.Text = "chart2";
            title2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title2.Name = "Title1";
            title2.Text = "Average days to close a merge request";
            this.averageChart.Titles.Add(title2);
            this.averageChart.Visible = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Firebrick;
            this.button1.BackgroundImage = global::GitLabSniffer.Properties.Resources._52728_wrong_cross_white;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(-4, 719);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(1216, 93);
            this.button1.TabIndex = 2;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // prevBtn
            // 
            this.prevBtn.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.prevBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.prevBtn.Enabled = false;
            this.prevBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.prevBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prevBtn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.prevBtn.Location = new System.Drawing.Point(125, 622);
            this.prevBtn.Name = "prevBtn";
            this.prevBtn.Size = new System.Drawing.Size(355, 75);
            this.prevBtn.TabIndex = 3;
            this.prevBtn.Text = "<<";
            this.prevBtn.UseVisualStyleBackColor = false;
            this.prevBtn.Click += new System.EventHandler(this.prevBtn_Click);
            // 
            // nextBtn
            // 
            this.nextBtn.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.nextBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.nextBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.nextBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nextBtn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.nextBtn.Location = new System.Drawing.Point(728, 622);
            this.nextBtn.Name = "nextBtn";
            this.nextBtn.Size = new System.Drawing.Size(355, 75);
            this.nextBtn.TabIndex = 4;
            this.nextBtn.Text = ">>";
            this.nextBtn.UseVisualStyleBackColor = false;
            this.nextBtn.Click += new System.EventHandler(this.nextBtn_Click);
            // 
            // currentGLabel
            // 
            this.currentGLabel.AutoSize = true;
            this.currentGLabel.BackColor = System.Drawing.Color.Transparent;
            this.currentGLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentGLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.currentGLabel.Location = new System.Drawing.Point(554, 637);
            this.currentGLabel.Name = "currentGLabel";
            this.currentGLabel.Size = new System.Drawing.Size(97, 46);
            this.currentGLabel.TabIndex = 5;
            this.currentGLabel.Text = "1 / 4";
            // 
            // chartsViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::GitLabSniffer.Properties.Resources.SNIFFER_charts;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1208, 827);
            this.Controls.Add(this.currentGLabel);
            this.Controls.Add(this.nextBtn);
            this.Controls.Add(this.prevBtn);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.averageChart);
            this.Controls.Add(this.openedChart);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "chartsViewer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Charts Viewer";
            this.Load += new System.EventHandler(this.chartsViewer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.openedChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.averageChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart openedChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart averageChart;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button prevBtn;
        private System.Windows.Forms.Button nextBtn;
        private System.Windows.Forms.Label currentGLabel;
    }
}