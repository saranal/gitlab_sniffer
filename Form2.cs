using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace GitLabSniffer
{
    public partial class chartsViewer : Form
    {
        private List<ProjectChart> pcs;
        private int currentIndex = 1;

        private const int WM_NCHITTEST = 0x84;
        private const int HTCLIENT = 0x1;
        private const int HTCAPTION = 0x2;

        public chartsViewer(List<ProjectChart> pcs)
        {
            InitializeComponent();
            this.pcs = pcs;
        }

        private void chartsViewer_Load(object sender, EventArgs e)
        {
            currentIndex = 1;

            openedChart.ChartAreas[0].AxisX.Interval = 1;
            averageChart.ChartAreas[0].AxisX.Interval = 1;

            handleCharts(currentIndex);
        }

        protected override void WndProc(ref Message message)
        {
            base.WndProc(ref message);

            if (message.Msg == WM_NCHITTEST && (int)message.Result == HTCLIENT)
                message.Result = (IntPtr)HTCAPTION;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to exit chart view?", "Exit chart view", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                this.Close();
        }

        private void prevBtn_Click(object sender, EventArgs e)
        {
            currentIndex--;
            if(currentIndex != 1) prevBtn.Enabled = true;
            else prevBtn.Enabled = false;
            if (currentIndex != 4) nextBtn.Enabled = true;
            else nextBtn.Enabled = false;
            currentGLabel.Text = currentIndex + " / 4";
            handleCharts(currentIndex);
        }
        private void nextBtn_Click(object sender, EventArgs e)
        {
            currentIndex++;
            if (currentIndex != 1) prevBtn.Enabled = true;
            else prevBtn.Enabled = false;
            if (currentIndex != 4) nextBtn.Enabled = true;
            else nextBtn.Enabled = false;
            currentGLabel.Text = currentIndex + " / 4";
            handleCharts(currentIndex);
            
        }

        private void handleCharts(int index)
        {
            openedChart.Series[0].Points.Clear();
            averageChart.Series[0].Points.Clear();
            switch (currentIndex)
            {
                case 1:
                    openedChart.Series[0].Name = "#OM";
                    openedChart.Titles[0].Text = "Number of opened merges";
                    foreach (ProjectChart pc in pcs)
                        openedChart.Series["#OM"].Points.AddXY(pc.title, pc.om);

                    averageChart.Visible = false;
                    break;

                case 2:
                    openedChart.Series[0].Name = "#MM";
                    averageChart.Series[0].Name = "AVG";
                    openedChart.Titles[0].Text = "Number of merged merges";
                    averageChart.Titles[0].Text = "Average days to merge a request";
                    foreach (ProjectChart pc in pcs)
                    {
                        openedChart.Series["#MM"].Points.AddXY(pc.title, pc.cm);
                        averageChart.Series["AVG"].Points.AddXY(pc.title, pc.avg);
                    }
                    averageChart.Visible = true;
                    break;

                case 3:
                    openedChart.Series[0].Name = "#PIPES";
                    openedChart.Titles[0].Text = "Number of pipelines executed";
                    foreach (ProjectChart pc in pcs)
                        openedChart.Series["#PIPES"].Points.AddXY(pc.title, pc.rp);

                    averageChart.Visible = false;
                    break;

                case 4:
                    openedChart.Series[0].Name = "#TESTS";
                    averageChart.Series[0].Name = "%COVG";
                    openedChart.Titles[0].Text = "Number of tests executed";
                    averageChart.Titles[0].Text = "Total amount of coverage";
                    foreach (ProjectChart pc in pcs)
                    {
                        openedChart.Series["#TESTS"].Points.AddXY(pc.title, pc.nt);
                        averageChart.Series["%COVG"].Points.AddXY(pc.title, pc.cov);
                    }
                    averageChart.Visible = true;
                    break;
            }
        }
    }
}
