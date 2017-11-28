using System;
using System.Text.RegularExpressions;
using System.Linq;
using System.Windows.Forms;
using System.ComponentModel;
using System.Threading;

namespace PingMetrics.GUI
{
    public partial class PingMetricsForm : Form
    {
        delegate void SetTextCallback(string text);
        private PingLog log;
        private readonly BackgroundWorker _pingBackgroundWorker;
        private int maxLogItems = 1000;
        public PingMetricsForm()
        {
            InitializeComponent();
            lblOutput.Text = "";
            _pingBackgroundWorker = new BackgroundWorker
            {
                WorkerSupportsCancellation = true
            };
            _pingBackgroundWorker.DoWork += _backgroundWorker_BeginPing;
            _pingBackgroundWorker.RunWorkerCompleted += _backgroundWorker_StopPing;
            Disposed += PingMetricsForm_Disposed;
            optFinite.Checked = true;
            InitializeMonitor();
        }
        private void PingMetricsForm_Disposed(object sender, EventArgs e)
        {
            _pingBackgroundWorker.Dispose();
        }
        private string GetCurrentTimeStamp()
        {
            return $"{DateTime.Now.ToLongTimeString()} on {DateTime.Now.ToLongDateString()}";
        }
        private void SetGroup(GroupBox groupBox, bool enabled)
        {
            foreach(Control ctrl in groupBox.Controls)
            {
                EnableOrDisableControl(ctrl, enabled);
            }
        }
        private void InitializeMonitor()
        {
            lstMonitor.View = View.Details;
            lstMonitor.GridLines = true;
            lstMonitor.FullRowSelect = true;
            string[] columns = new string[] {"No.", "Time Stamp", "Status", "Time", "Good Rx", "Bad Rx", "% Loss"};
            foreach(string column in columns)
            {
                lstMonitor.Columns.Add(column);
            }
        }
        private void lstMonitor_ColumnClick(object sender, System.Windows.Forms.ColumnClickEventArgs e)
        {
            lstMonitor.ListViewItemSorter = new ListViewItemComparer(e.Column);
            lstMonitor.Sort();
        }
        public void UpdateMonitor(string updateString, char stringDelimeter)
        {
            Invoke((MethodInvoker)delegate
            {
                string[] splitString = updateString.Split(stringDelimeter);
                lstMonitor.Items.Add(new ListViewItem(splitString));
                if(lstMonitor.Items.Count > maxLogItems)
                {
                    lstMonitor.Items.RemoveAt(0);
                }
                //foreach (ColumnHeader columnHeader in lstMonitor.Columns)
                //{
                //    columnHeader.Width = -2;
                //}
            });
        }
        private void _backgroundWorker_BeginPing(object sender, DoWorkEventArgs e)
        {
            if (FieldsAreValid())
            {
                ClearMonitor();
                var backgroundWorker = (BackgroundWorker)sender;
                char pingStringDelimiter = ';';
                string hostIPAddresss = txtHostIPAddress.Text;
                string logPath = txtLogPath.Text;
                int iterations = int.Parse(txtIterations.Text);
                int bytesToSend = int.Parse(txtBytesToSend.Text);
                int timeout = int.Parse(txtTimeout.Text);
                PingObject backgroundPingObject = new PingObject(hostIPAddresss, bytesToSend, timeout);
                SetGroup(grpPingSettings, false);
                EnableOrDisableControl(btnStopPing, true);
                UpdateLabel(lblOutput, "");
                if (chkLog.Checked)
                {
                    log = new PingLog(logPath, GetCurrentTimeStamp().Replace(":", "-"));
                }
                int loopCounter = 0;
                while (loopCounter < iterations)
                {
                    if (backgroundWorker.CancellationPending)
                    {
                        e.Cancel = true;
                        return;
                    }
                    bool pingSuccess = backgroundPingObject.DoOnePing();
                    UpdateDisplayedMetrics(backgroundPingObject);
                    string pingString = GeneratePingString(pingStringDelimiter, backgroundPingObject.TotalPings, GetCurrentTimeStamp(), (pingSuccess ? "success" : "failure"), backgroundPingObject.LastRoundTripTime, backgroundPingObject.GoodRx, backgroundPingObject.BadRx, backgroundPingObject.PercentLoss);
                    if (chkLog.Checked)
                    {
                        log.WriteLineToLog(pingString);
                    }
                    UpdateMonitor(pingString, pingStringDelimiter);
                    AppendOutputText(pingString);
                    Thread.Sleep(1000);
                    if (optFinite.Checked)
                    {
                        loopCounter++;
                    }
                }
            }
            else
            {
                MessageBox.Show("One of your fields is not right.  Make sure all information is correctly filled out.", "Field empty error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private string GeneratePingString(char delimiter, int totalPings, string timeStamp, string statusMessage, long lastPingTime, int goodRx, int badRx, double percentLoss)
        {
            return $"{totalPings}{delimiter}{timeStamp}{delimiter}{statusMessage}{delimiter}{lastPingTime}{delimiter}{goodRx}{delimiter}{badRx}{delimiter}{percentLoss}";
        }
        private void ClearMonitor()
        {
            if (lstMonitor.InvokeRequired)
            {
                lstMonitor.Invoke((MethodInvoker)(() => lstMonitor.Items.Clear()));
            }
            else
            {
                lstMonitor.Items.Clear();
            }
        }
        private void UpdateLabel(Label label, string updateText)
        {
            if (label.InvokeRequired)
            {
                label.Invoke((MethodInvoker)(() => label.Text = updateText));
            } else
            {
                label.Text = updateText;
            }
        }
        private void UpdateDisplayedMetrics(PingObject pingObject)
        {
            UpdateLabel(lblGoodRx, $"Good Rx: {pingObject.GoodRx}");
            UpdateLabel(lblBadRx, $"Bad Rx: {pingObject.BadRx}");
            UpdateLabel(lblPercentage, $"% Loss: {string.Format("{0:0.00}", pingObject.PercentLoss)}");
            UpdateLabel(lblLongestRx, $"Longest Rx: {pingObject.LongestRoundTripTime}");
            UpdateLabel(lblShortestRx, $"Shortest Rx: {pingObject.ShortestRoundTripTime}");
            UpdateLabel(lblAverage, $"Average Rx: { pingObject.AverageRoundTripTime}");
        }
        private void _backgroundWorker_StopPing(object sender, RunWorkerCompletedEventArgs e)
        {
            SetGroup(grpPingSettings, true);
            EnableOrDisableControl(btnStopPing, false);
        }
        private void AppendOutputText(string text)
        {
            if (lblOutput.InvokeRequired)
            {
                SetTextCallback textCallback = new SetTextCallback(AppendOutputText);
                Invoke(textCallback, new object[] { text });
            }
            else
            {
                if (GetNumberOfStringInString(lblOutput.Text, '\n') > 15)
                {
                    lblOutput.Text = RemoveLinesFromString(lblOutput.Text, 1);
                }
                lblOutput.Text += text;
            }
        }
        private string RemoveLinesFromString(string str, int numberOfLines)
        {
            var lines = Regex.Split(str, "\r\n|\r|\n").Skip(numberOfLines);
            return string.Join(Environment.NewLine, lines.ToArray());
        }
        private void EnableOrDisableControl(Control control, bool enabled)
        {
            if (control.InvokeRequired)
            {
                control.Invoke((MethodInvoker)(() => control.Enabled = enabled));
            } else
            {
                control.Enabled = enabled;
            }
        }
        private void btnDefault_Click(object sender, EventArgs e)
        {
            ApplyDefaultSettings();
        }
        private void BeginPing()
        {
            if (!_pingBackgroundWorker.IsBusy)
            {
                _pingBackgroundWorker.RunWorkerAsync();
            }
        }
        private void btnBeginPing_Click(object sender, EventArgs e)
        {
            BeginPing();
        }
        private void btnStopPing_Click(object sender, EventArgs e)
        {
            _pingBackgroundWorker.CancelAsync();
        }
        private void tsmApplyDefaultSettings_Click(object sender, EventArgs e)
        {
            ApplyDefaultSettings();
        }
        public bool FieldsAreValid()
        {
            return  (txtHostIPAddress.Text == "" || 
                    txtBytesToSend.Text == "" || 
                    txtTimeout.Text == "" || 
                    (optFinite.Checked && txtIterations.Text == "") ? false : true);
        }
        private void ApplyDefaultSettings()
        {
            txtHostIPAddress.Text = "8.8.8.8";
            txtBytesToSend.Text = "32";
            txtTimeout.Text = "1000";
            txtIterations.Text = "4";
            optFinite.Checked = true;
            chkLog.Checked = true;
            txtLogPath.Text = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments).ToString();
        }
        private void chkLog_CheckedChanged(object sender, EventArgs e)
        {
            txtLogPath.Enabled = chkLog.Checked;
            btnPathBrowse.Enabled = chkLog.Checked;
        }
        private void optIndefinite_CheckedChanged(object sender, EventArgs e)
        {
            ToggleIterations();
        }
        private void optFintie_CheckedChanged(object sender, EventArgs e)
        {
            ToggleIterations();
        }
        private void ToggleIterations()
        {
            txtIterations.Enabled = optFinite.Checked;
        }
        private void tsmStartPing_Click(object sender, EventArgs e)
        {
            BeginPing();
        }
        private void tsmStopPing_Click(object sender, EventArgs e)
        {
            _pingBackgroundWorker.CancelAsync();
        }
        private int GetNumberOfStringInString(string stringToLookIn, char stringToLookFor)
        {
            return stringToLookIn.Split(stringToLookFor).Length;
        }
        private void btnPathBrowse_Click(object sender, EventArgs e)
        {
            string path = BrowseForFile();
            if(path != null)
            {
                txtLogPath.Text = path;
            }
        }
        private string BrowseForFile()
        {
            FolderBrowserDialog browser = new FolderBrowserDialog();
            browser.Description = "Log Folder Location";
            return (browser.ShowDialog() == DialogResult.OK ? browser.SelectedPath : null);
        }

        private void tsmAbout_Click(object sender, EventArgs e)
        {
            AboutForm aboutForm = new AboutForm();
            aboutForm.Show();
        }

        private void tsmExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
