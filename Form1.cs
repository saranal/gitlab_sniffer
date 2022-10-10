using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Windows.Forms;
using ClosedXML.Excel;
using System.Globalization;

namespace GitLabSniffer
{
    public partial class mainWindow : Form
    {
        private HttpClient client = new HttpClient();
        private string inputTxt = null;
        private HttpResponseMessage res;
        private HttpContent resC;
        private StreamReader reader;
        private string glApiOpened = "https://gitlab.com/api/v4/projects/projectId/merge_requests?state=opened&page=1&per_page=100";
        private string gitEndpoint = "", gitPat = "";
        private string stDate = "", enDate = "";

        private const int WM_NCHITTEST = 0x84;
        private const int HTCLIENT = 0x1;
        private const int HTCAPTION = 0x2;

        public mainWindow()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            resetDateBtn_Click(sender, e);
        }

        protected override void WndProc(ref Message message)
        {
            base.WndProc(ref message);

            if (message.Msg == WM_NCHITTEST && (int)message.Result == HTCLIENT)
                message.Result = (IntPtr)HTCAPTION;
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure you want to exit GitLab Sniffer?", "Exit GitLab Sniffer", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                Application.Exit();
        }

        private void inputFileBtn_Click(object sender, EventArgs e)
        {
            inputOpener.ShowDialog();
        }

        private async void startBtn_Click(object sender, EventArgs e)
        {
            if (inputTxt != null)
            {
                startBtn.Enabled = false;
                inputFileBtn.Enabled = false;
                gitTextBox.Enabled = false;
                patTextBox.Enabled = false;
                startDate.Enabled = false;
                endDate.Enabled = false;
                resetDateBtn.Enabled = false;

                string authProblems = "";

                try
                {
                    stateLabel.Text = "Starting...";
                    if (gitTextBox.Text != "")
                    {
                        gitEndpoint = gitTextBox.Text;
                        useCustomLabel.Visible = true;
                    }
                    if (patTextBox.Text != "")
                    {
                        gitPat = patTextBox.Text;
                        usePatLabel.Visible = true;
                        client.DefaultRequestHeaders.Add("PRIVATE-TOKEN", gitPat);
                    }
                    if (stDate != "" && enDate != "")
                        useDateLabel.Visible = true;

                    List<ProjectChart> charts = new List<ProjectChart>();
                    
                    string[] filelines = File.ReadAllLines(inputTxt);
                    string outputXlsx = Directory.GetCurrentDirectory() + "\\outputFile.xlsx";
                    if (File.Exists(outputXlsx)) File.Delete(outputXlsx);
                    XLWorkbook xlsWorkbook = new XLWorkbook();
                    IXLWorksheet xlsSheet;
                    string[] columns = new string[] {"A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z"};
                    
                    System.Collections.Hashtable revMerges = new System.Collections.Hashtable();
                    int tMerges = 0, tProjs = 0;

                    foreach(string line in filelines)
                    {
                        if(int.TryParse(line, out int value))
                        {
                            int totMerges = 0, yIndex = 2, cIndex = 1;
                            double totDays = 0.0;
                            string title = "";
                            System.Collections.Hashtable pRev = new System.Collections.Hashtable();

                            xlsSheet = xlsWorkbook.AddWorksheet("PID " + line + " - ");
                            xlsSheet.Cell("A1").Value = "Opened Merge Requests";
                            xlsSheet.Cell("A1").Style.Fill.SetBackgroundColor(XLColor.YellowGreen);
                            xlsSheet.Cell("B1").Value = "Reviewers";
                            xlsSheet.Cell("B1").Style.Fill.SetBackgroundColor(XLColor.YellowGreen);

                            string chosenApi = glApiOpened.Replace("projectId", line);
                            if (gitEndpoint != "") chosenApi = chosenApi.Replace("gitlab.com", gitEndpoint);
                            res = await client.GetAsync(chosenApi);
                            resC = res.Content;
                            stateLabel.Text = "Retrieving opened merges for project ID " + line + "...";
                            totMerges = 0;
                            using (reader = new StreamReader(await resC.ReadAsStreamAsync()))
                            {
                                var content = await reader.ReadToEndAsync();
                                dynamic contentJSON = JsonConvert.DeserializeObject(content);
                                reader.Close();
                                foreach (var merge in contentJSON)
                                {
                                    xlsSheet.Cell("A" + yIndex).Value = "MID " + merge.iid + " - " + merge.title;
                                    xlsSheet.Cell("A" + yIndex).Style.Alignment.WrapText = true;
                                    foreach (var rev in merge.reviewers)
                                    {
                                        if (pRev.Contains(rev.name))
                                        {
                                            int cRev = pRev[rev.name];
                                            pRev.Remove(rev.name);
                                            pRev.Add(rev.name, cRev + 1);
                                        }
                                        else pRev.Add(rev.name, 1);
                                        if (revMerges.Contains(rev.name))
                                        {
                                            int cRev = revMerges[rev.name];
                                            revMerges.Remove(rev.name);
                                            revMerges.Add(rev.name, cRev + 1);
                                        }
                                        else revMerges.Add(rev.name, 1);

                                        string reviewer = rev.name + " (" + rev.username + ")";
                                        xlsSheet.Cell(columns[cIndex] + yIndex).Value = reviewer;
                                        cIndex++;
                                        if(cIndex == 25)
                                        {
                                            cIndex = 1;
                                            yIndex++;
                                        }
                                    }
                                    if (cIndex == 1) xlsSheet.Cell(columns[cIndex] + yIndex).Value = "None";
                                    cIndex = 1;
                                    yIndex++;
                                    totMerges++;
                                    tMerges++;
                                }
                                if (contentJSON.Count != 0)
                                {
                                    string url = contentJSON[0].web_url;
                                    string[] urlSplit = url.Split('/');
                                    title = urlSplit[Array.IndexOf(urlSplit, "merge_requests") - 2];
                                }
                            }
                            yIndex += 2;
                            xlsSheet.Cell("A" + yIndex).Value = "- Total opened merges: " + totMerges;
                            xlsSheet.Cell("A" + yIndex).Style.Fill.SetBackgroundColor(XLColor.YellowGreen);
                            yIndex += 2;
                            xlsSheet.Cell("A" + yIndex).Value = "- Total opened merges per reviewer:";
                            xlsSheet.Cell("A" + yIndex).Style.Fill.SetBackgroundColor(XLColor.YellowGreen);
                            bool noneRev = true;
                            foreach (var rev in pRev.Keys)
                            {
                                xlsSheet.Cell(columns[cIndex] + yIndex).Value = rev + ", " + pRev[rev];
                                cIndex++;
                                if(cIndex == 7)
                                {
                                    yIndex++;
                                    cIndex = 1;
                                }
                                noneRev = false;
                            }
                            if (noneRev) xlsSheet.Cell(columns[cIndex] + yIndex).Value = "None";

                            int i = 0;
                            foreach (IXLColumn c in xlsSheet.Columns())
                            {
                                if (i == 0) c.Width = 50;
                                else c.Width = 35;
                                i++;
                            }
                            int openMerges = totMerges;

                            chosenApi = chosenApi.Replace("state=opened", "state=merged");
                            if (stDate != "" && enDate != "") chosenApi += "&updated_after=" + stDate + "&updated_before=" + enDate;
                            res = await client.GetAsync(chosenApi);
                            resC = res.Content;
                            stateLabel.Text = "Retrieving merged merges for project ID " + line + "...";
                            totMerges = 0;
                            totDays = 0.0;
                            using (reader = new StreamReader(await resC.ReadAsStreamAsync()))
                            {
                                var content = await reader.ReadToEndAsync();
                                dynamic contentJSON = JsonConvert.DeserializeObject(content);
                                reader.Close();

                                foreach (var merge in contentJSON)
                                {
                                    if (merge.merged_at == null || merge.created_at == null) continue;
                                    DateTime d1 = DateTime.Parse(Convert.ToString(merge.created_at));
                                    DateTime d2 = DateTime.Parse(Convert.ToString(merge.merged_at));
                                    totDays += d2.Subtract(d1).TotalDays;
                                    totMerges++;
                                }
                                if (contentJSON.Count != 0)
                                {
                                    string url = contentJSON[0].web_url;
                                    string[] urlSplit = url.Split('/');
                                    title = urlSplit[Array.IndexOf(urlSplit, "merge_requests") - 2];
                                }
                            }

                            double average = Math.Truncate(totDays / totMerges * 100) / 100;
                            yIndex += 2;
                            xlsSheet.Cell("A" + yIndex).Value = "- Average days to merge a request: " + average + " days";
                            xlsSheet.Cell("A" + yIndex).Style.Fill.SetBackgroundColor(XLColor.YellowGreen);
                            yIndex++;
                            xlsSheet.Cell("A" + yIndex).Value = "- Retrieved a total number of " + totMerges + " merged merges";
                            xlsSheet.Cell("A" + yIndex).Style.Fill.SetBackgroundColor(XLColor.YellowGreen);
                            if (stDate != "" && enDate != "")
                            {
                                yIndex ++;
                                xlsSheet.Cell("A" + yIndex).Value = "in the range date from " + stDate.Split('T')[0] + " to " + enDate.Split('T')[0];
                                xlsSheet.Cell("A" + yIndex).Style.Fill.SetBackgroundColor(XLColor.YellowGreen);
                            }

                            int rPipes = 0;
                            res = await client.GetAsync("https://gitlab.com/api/v4/projects/" + line + "/pipelines");
                            if (res.IsSuccessStatusCode)
                            {
                                resC = res.Content;
                                using (reader = new StreamReader(await resC.ReadAsStreamAsync()))
                                {
                                    var content = await reader.ReadToEndAsync();
                                    dynamic contentJSON = JsonConvert.DeserializeObject(content);
                                    reader.Close();
                                    if (contentJSON.Count != 0)
                                    {
                                        rPipes = contentJSON[0].iid;
                                        string url = contentJSON[0].web_url;
                                        string[] urlSplit = url.Split('/');
                                        title = urlSplit[Array.IndexOf(urlSplit, "pipelines") - 2];
                                    }
                                }
                            }
                            int rId = -1;
                            res = await client.GetAsync("https://gitlab.com/api/v4/projects/" + line + "/pipelines?status=success&per_page=100");
                            if (res.IsSuccessStatusCode)
                            {
                                resC = res.Content;
                                using (reader = new StreamReader(await resC.ReadAsStreamAsync()))
                                {
                                    var content = await reader.ReadToEndAsync();
                                    dynamic contentJSON = JsonConvert.DeserializeObject(content);
                                    reader.Close();
                                    if(contentJSON.Count != 0)
                                    {
                                        rId = contentJSON[0].id;
                                        string url = contentJSON[0].web_url;
                                        string[] urlSplit = url.Split('/');
                                        title = urlSplit[Array.IndexOf(urlSplit, "pipelines") - 2];
                                    }
                                }
                            }
                            double? rCov = 0.0;
                            if(rId != -1)
                            {
                                res = await client.GetAsync("https://gitlab.com/api/v4/projects/" + line + "/pipelines/" + rId);
                                if (res.IsSuccessStatusCode)
                                {
                                    resC = res.Content;
                                    using (reader = new StreamReader(await resC.ReadAsStreamAsync()))
                                    {
                                        var content = await reader.ReadToEndAsync();
                                        dynamic contentJSON = JsonConvert.DeserializeObject(content);
                                        reader.Close();
                                        rCov = contentJSON.coverage;
                                        string url = contentJSON.web_url;
                                        string[] urlSplit = url.Split('/');
                                        title = urlSplit[Array.IndexOf(urlSplit, "pipelines") - 2];
                                    }
                                }
                                if (rCov == null) rCov = 0.0;
                            }
                            int rTests = 0;
                            res = await client.GetAsync("https://gitlab.com/api/v4/projects/" + line + "/pipelines/" + rId + "/test_report");
                            if (res.IsSuccessStatusCode)
                            {
                                resC = res.Content;
                                using (reader = new StreamReader(await resC.ReadAsStreamAsync()))
                                {
                                    var content = await reader.ReadToEndAsync();
                                    dynamic contentJSON = JsonConvert.DeserializeObject(content);
                                    reader.Close();
                                    rTests = contentJSON.total_count;
                                }
                            }
                            string shTitle = xlsSheet.Name + title;
                            if (shTitle.Length > 30) shTitle = shTitle.Substring(0, 27) + "...";
                            xlsSheet.Name = shTitle;
                            if (title == "") title = line;
                            charts.Add(new ProjectChart(line, title, openMerges, totMerges, average, rPipes, rCov, rTests));
                            tProjs++;
                        }
                        else MessageBox.Show("ERROR: A wrong line was detected in the input file.\n\nFull line:\n" + line, "Error reading input file", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    if(authProblems != "")
                    {
                        stateLabel.Text = "Authentication error, please retry";
                        MessageBox.Show("ERROR: You provided a wrong token or you don't have access to some of the specified projects.\n\n" + authProblems, "Authentication error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        xlsSheet = xlsWorkbook.AddWorksheet("Summary of All Projects");
                        xlsSheet.Cell("A1").Value = "- Number of projects evaluated: " + tProjs;
                        xlsSheet.Cell("A1").Style.Fill.SetBackgroundColor(XLColor.YellowGreen);
                        xlsSheet.Cell("A3").Value = "- Total opened merges: " + tMerges;
                        xlsSheet.Cell("A3").Style.Fill.SetBackgroundColor(XLColor.YellowGreen);
                        xlsSheet.Cell("A5").Value = "- Total opened merges per reviewer:";
                        xlsSheet.Cell("A5").Style.Fill.SetBackgroundColor(XLColor.YellowGreen);

                        int yIndex = 5, cIndex = 1;
                        foreach (var rev in revMerges.Keys)
                        {
                            xlsSheet.Cell(columns[cIndex] + yIndex).Value = rev + ", " + revMerges[rev];
                            cIndex++;
                            if (cIndex == 7)
                            {
                                yIndex++;
                                cIndex = 1;
                            }
                        }
                        xlsSheet.SetTabColor(XLColor.CarrotOrange);
                        foreach (IXLColumn c in xlsSheet.Columns()) c.Width = 35;

                        xlsWorkbook.SaveAs("outputFile.xlsx");

                        stateLabel.Text = "Operation completed, ready for another input";
                        if (MessageBox.Show("Operation successfully completed, output was written to outputFile.xlsx in the same folder of this exe.\n\nWould you like to view the chart for this request?", "Operation success", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            chartsViewer chWin = new chartsViewer(charts);
                            chWin.Show();
                        }
                    }
                }
                catch (Exception ex)
                {
                    stateLabel.Text = "An error occurred, please restart";
                    MessageBox.Show("ERROR: Something went wrong with the process.\n\nError details:\n" + ex.Message, "Fatal error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                if (useCustomLabel.Visible)
                {
                    gitEndpoint = "";
                    useCustomLabel.Visible = false;
                }
                if (usePatLabel.Visible)
                {
                    gitPat = "";
                    usePatLabel.Visible = false;
                    client.DefaultRequestHeaders.Remove("PRIVATE-TOKEN");
                }
                if(useDateLabel.Visible)
                    useDateLabel.Visible = false;

                startBtn.Enabled = true;
                inputFileBtn.Enabled = true;
                gitTextBox.Enabled = true;
                patTextBox.Enabled = true;
                startDate.Enabled = true;
                endDate.Enabled = true;
                resetDateBtn.Enabled = true;
                resetDateBtn_Click(sender, new EventArgs());
            }
        }

        private void endDate_ValueChanged(object sender, EventArgs e)
        {
            string uDate = endDate.Value.ToUniversalTime().ToString("u").Split(' ')[0];
            enDate = uDate + "T23:59:59Z";
        }

        private void startDate_ValueChanged(object sender, EventArgs e)
        {
            string uDate = startDate.Value.ToUniversalTime().ToString("u").Split(' ')[0];
            stDate = uDate + "T00:00:00Z";
            endDate.MinDate = startDate.Value;
        }
        private void resetDateBtn_Click(object sender, EventArgs e)
        {
            startDate.Value = DateTime.Now;
            stDate = "";
            endDate.Value = DateTime.Now;
            string uDate = endDate.Value.ToUniversalTime().ToString("u").Split(' ')[0];
            enDate = uDate + "T23:59:59Z";
        }

        private void inputOpener_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            inputTxt = inputOpener.FileName;
            string[] fileName = inputTxt.Split('\\');
            inputFileLabel.Text = "| Input file selected: " + fileName[fileName.Length-1];
            stateLabel.Text = "Input file loaded, ready to start";
            startBtn.Enabled = true;
        }
    }

    public class ProjectChart
    {
        public string pid, title;
        public int om, cm, rp, nt;
        public double avg;
        public double? cov;

        public ProjectChart(string pid, string title, int om, int cm, double avg, int rp, double? cov, int nt)
        {
            this.pid = pid;
            this.title = title;
            this.om = om;
            this.cm = cm;
            this.avg = avg;
            this.rp = rp;
            this.cov = cov;
            this.nt = nt;
        }
    }
}
