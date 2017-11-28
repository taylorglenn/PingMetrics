namespace PingMetrics.GUI
{
    partial class PingMetricsForm
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.grpPingSettings = new System.Windows.Forms.GroupBox();
            this.txtTimeout = new System.Windows.Forms.TextBox();
            this.lblTimeout = new System.Windows.Forms.Label();
            this.btnPathBrowse = new System.Windows.Forms.Button();
            this.chkLog = new System.Windows.Forms.CheckBox();
            this.txtLogPath = new System.Windows.Forms.TextBox();
            this.btnStopPing = new System.Windows.Forms.Button();
            this.lblLogPath = new System.Windows.Forms.Label();
            this.btnBeginPing = new System.Windows.Forms.Button();
            this.btnDefault = new System.Windows.Forms.Button();
            this.txtIterations = new System.Windows.Forms.TextBox();
            this.txtBytesToSend = new System.Windows.Forms.TextBox();
            this.txtHostIPAddress = new System.Windows.Forms.TextBox();
            this.optFinite = new System.Windows.Forms.RadioButton();
            this.optIndefinite = new System.Windows.Forms.RadioButton();
            this.lblIterations = new System.Windows.Forms.Label();
            this.lblBytesToSend = new System.Windows.Forms.Label();
            this.lblHostIPAddress = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmFile = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmLogOptions = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmSaveLogAs = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmPingOptions = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmStartPing = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmStopPing = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmApplyDefaultSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmView = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.lblOutput = new System.Windows.Forms.Label();
            this.lblGoodRx = new System.Windows.Forms.Label();
            this.lblBadRx = new System.Windows.Forms.Label();
            this.lblPercentage = new System.Windows.Forms.Label();
            this.lblLongestRx = new System.Windows.Forms.Label();
            this.lblShortestRx = new System.Windows.Forms.Label();
            this.lblAverage = new System.Windows.Forms.Label();
            this.lstMonitor = new System.Windows.Forms.ListView();
            this.tsmExit = new System.Windows.Forms.ToolStripMenuItem();
            this.grpPingSettings.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(12, 47);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(204, 37);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Ping Metrics";
            // 
            // grpPingSettings
            // 
            this.grpPingSettings.Controls.Add(this.txtTimeout);
            this.grpPingSettings.Controls.Add(this.lblTimeout);
            this.grpPingSettings.Controls.Add(this.btnPathBrowse);
            this.grpPingSettings.Controls.Add(this.chkLog);
            this.grpPingSettings.Controls.Add(this.txtLogPath);
            this.grpPingSettings.Controls.Add(this.btnStopPing);
            this.grpPingSettings.Controls.Add(this.lblLogPath);
            this.grpPingSettings.Controls.Add(this.btnBeginPing);
            this.grpPingSettings.Controls.Add(this.btnDefault);
            this.grpPingSettings.Controls.Add(this.txtIterations);
            this.grpPingSettings.Controls.Add(this.txtBytesToSend);
            this.grpPingSettings.Controls.Add(this.txtHostIPAddress);
            this.grpPingSettings.Controls.Add(this.optFinite);
            this.grpPingSettings.Controls.Add(this.optIndefinite);
            this.grpPingSettings.Controls.Add(this.lblIterations);
            this.grpPingSettings.Controls.Add(this.lblBytesToSend);
            this.grpPingSettings.Controls.Add(this.lblHostIPAddress);
            this.grpPingSettings.Location = new System.Drawing.Point(16, 96);
            this.grpPingSettings.Name = "grpPingSettings";
            this.grpPingSettings.Size = new System.Drawing.Size(484, 299);
            this.grpPingSettings.TabIndex = 1;
            this.grpPingSettings.TabStop = false;
            this.grpPingSettings.Text = "Ping Settings";
            // 
            // txtTimeout
            // 
            this.txtTimeout.Location = new System.Drawing.Point(142, 93);
            this.txtTimeout.Name = "txtTimeout";
            this.txtTimeout.Size = new System.Drawing.Size(57, 26);
            this.txtTimeout.TabIndex = 12;
            // 
            // lblTimeout
            // 
            this.lblTimeout.AutoSize = true;
            this.lblTimeout.Location = new System.Drawing.Point(12, 96);
            this.lblTimeout.Name = "lblTimeout";
            this.lblTimeout.Size = new System.Drawing.Size(101, 20);
            this.lblTimeout.TabIndex = 11;
            this.lblTimeout.Text = "Timeout (ms)";
            // 
            // btnPathBrowse
            // 
            this.btnPathBrowse.Enabled = false;
            this.btnPathBrowse.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPathBrowse.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPathBrowse.Location = new System.Drawing.Point(418, 204);
            this.btnPathBrowse.Name = "btnPathBrowse";
            this.btnPathBrowse.Size = new System.Drawing.Size(60, 38);
            this.btnPathBrowse.TabIndex = 7;
            this.btnPathBrowse.Text = "...";
            this.btnPathBrowse.UseVisualStyleBackColor = true;
            this.btnPathBrowse.Click += new System.EventHandler(this.btnPathBrowse_Click);
            // 
            // chkLog
            // 
            this.chkLog.AutoSize = true;
            this.chkLog.Location = new System.Drawing.Point(17, 188);
            this.chkLog.Name = "chkLog";
            this.chkLog.Size = new System.Drawing.Size(71, 24);
            this.chkLog.TabIndex = 10;
            this.chkLog.Text = "Log?";
            this.chkLog.UseVisualStyleBackColor = true;
            this.chkLog.CheckedChanged += new System.EventHandler(this.chkLog_CheckedChanged);
            // 
            // txtLogPath
            // 
            this.txtLogPath.Enabled = false;
            this.txtLogPath.Location = new System.Drawing.Point(94, 209);
            this.txtLogPath.Name = "txtLogPath";
            this.txtLogPath.Size = new System.Drawing.Size(318, 26);
            this.txtLogPath.TabIndex = 6;
            // 
            // btnStopPing
            // 
            this.btnStopPing.Enabled = false;
            this.btnStopPing.Location = new System.Drawing.Point(143, 252);
            this.btnStopPing.Name = "btnStopPing";
            this.btnStopPing.Size = new System.Drawing.Size(121, 35);
            this.btnStopPing.TabIndex = 3;
            this.btnStopPing.Text = "Stop Ping";
            this.btnStopPing.UseVisualStyleBackColor = true;
            this.btnStopPing.Click += new System.EventHandler(this.btnStopPing_Click);
            // 
            // lblLogPath
            // 
            this.lblLogPath.AutoSize = true;
            this.lblLogPath.Location = new System.Drawing.Point(13, 215);
            this.lblLogPath.Name = "lblLogPath";
            this.lblLogPath.Size = new System.Drawing.Size(77, 20);
            this.lblLogPath.TabIndex = 5;
            this.lblLogPath.Text = "Log Path:";
            // 
            // btnBeginPing
            // 
            this.btnBeginPing.Location = new System.Drawing.Point(16, 252);
            this.btnBeginPing.Name = "btnBeginPing";
            this.btnBeginPing.Size = new System.Drawing.Size(121, 35);
            this.btnBeginPing.TabIndex = 9;
            this.btnBeginPing.Text = "Begin Ping";
            this.btnBeginPing.UseVisualStyleBackColor = true;
            this.btnBeginPing.Click += new System.EventHandler(this.btnBeginPing_Click);
            // 
            // btnDefault
            // 
            this.btnDefault.Location = new System.Drawing.Point(300, 19);
            this.btnDefault.Name = "btnDefault";
            this.btnDefault.Size = new System.Drawing.Size(177, 64);
            this.btnDefault.TabIndex = 2;
            this.btnDefault.Text = "Apply Default Settings";
            this.btnDefault.UseVisualStyleBackColor = true;
            this.btnDefault.Click += new System.EventHandler(this.btnDefault_Click);
            // 
            // txtIterations
            // 
            this.txtIterations.Enabled = false;
            this.txtIterations.Location = new System.Drawing.Point(215, 157);
            this.txtIterations.Name = "txtIterations";
            this.txtIterations.Size = new System.Drawing.Size(57, 26);
            this.txtIterations.TabIndex = 8;
            // 
            // txtBytesToSend
            // 
            this.txtBytesToSend.Location = new System.Drawing.Point(142, 60);
            this.txtBytesToSend.Name = "txtBytesToSend";
            this.txtBytesToSend.Size = new System.Drawing.Size(57, 26);
            this.txtBytesToSend.TabIndex = 7;
            // 
            // txtHostIPAddress
            // 
            this.txtHostIPAddress.Location = new System.Drawing.Point(142, 28);
            this.txtHostIPAddress.Name = "txtHostIPAddress";
            this.txtHostIPAddress.Size = new System.Drawing.Size(152, 26);
            this.txtHostIPAddress.TabIndex = 6;
            // 
            // optFinite
            // 
            this.optFinite.AutoSize = true;
            this.optFinite.Location = new System.Drawing.Point(143, 158);
            this.optFinite.Name = "optFinite";
            this.optFinite.Size = new System.Drawing.Size(77, 24);
            this.optFinite.TabIndex = 5;
            this.optFinite.TabStop = true;
            this.optFinite.Text = "Finite:";
            this.optFinite.UseVisualStyleBackColor = true;
            this.optFinite.CheckedChanged += new System.EventHandler(this.optFintie_CheckedChanged);
            // 
            // optIndefinite
            // 
            this.optIndefinite.AutoSize = true;
            this.optIndefinite.Location = new System.Drawing.Point(143, 128);
            this.optIndefinite.Name = "optIndefinite";
            this.optIndefinite.Size = new System.Drawing.Size(100, 24);
            this.optIndefinite.TabIndex = 4;
            this.optIndefinite.TabStop = true;
            this.optIndefinite.Text = "Indefinite";
            this.optIndefinite.UseVisualStyleBackColor = true;
            this.optIndefinite.CheckedChanged += new System.EventHandler(this.optIndefinite_CheckedChanged);
            // 
            // lblIterations
            // 
            this.lblIterations.AutoSize = true;
            this.lblIterations.Location = new System.Drawing.Point(12, 128);
            this.lblIterations.Name = "lblIterations";
            this.lblIterations.Size = new System.Drawing.Size(76, 20);
            this.lblIterations.TabIndex = 3;
            this.lblIterations.Text = "Iterations";
            // 
            // lblBytesToSend
            // 
            this.lblBytesToSend.AutoSize = true;
            this.lblBytesToSend.Location = new System.Drawing.Point(11, 63);
            this.lblBytesToSend.Name = "lblBytesToSend";
            this.lblBytesToSend.Size = new System.Drawing.Size(109, 20);
            this.lblBytesToSend.TabIndex = 1;
            this.lblBytesToSend.Text = "Bytes to Send";
            // 
            // lblHostIPAddress
            // 
            this.lblHostIPAddress.AutoSize = true;
            this.lblHostIPAddress.Location = new System.Drawing.Point(11, 31);
            this.lblHostIPAddress.Name = "lblHostIPAddress";
            this.lblHostIPAddress.Size = new System.Drawing.Size(125, 20);
            this.lblHostIPAddress.TabIndex = 0;
            this.lblHostIPAddress.Text = "Host IP Address";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmFile,
            this.tsmView,
            this.tsmHelp});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1418, 33);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmFile
            // 
            this.tsmFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmLogOptions,
            this.tsmPingOptions,
            this.tsmExit});
            this.tsmFile.Name = "tsmFile";
            this.tsmFile.Size = new System.Drawing.Size(50, 29);
            this.tsmFile.Text = "File";
            // 
            // tsmLogOptions
            // 
            this.tsmLogOptions.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmSaveLogAs});
            this.tsmLogOptions.Name = "tsmLogOptions";
            this.tsmLogOptions.Size = new System.Drawing.Size(211, 30);
            this.tsmLogOptions.Text = "Log Options";
            // 
            // tsmSaveLogAs
            // 
            this.tsmSaveLogAs.Name = "tsmSaveLogAs";
            this.tsmSaveLogAs.Size = new System.Drawing.Size(206, 30);
            this.tsmSaveLogAs.Text = "Save Log As...";
            // 
            // tsmPingOptions
            // 
            this.tsmPingOptions.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmStartPing,
            this.tsmStopPing,
            this.tsmApplyDefaultSettings});
            this.tsmPingOptions.Name = "tsmPingOptions";
            this.tsmPingOptions.Size = new System.Drawing.Size(211, 30);
            this.tsmPingOptions.Text = "Ping Options";
            // 
            // tsmStartPing
            // 
            this.tsmStartPing.Name = "tsmStartPing";
            this.tsmStartPing.Size = new System.Drawing.Size(275, 30);
            this.tsmStartPing.Text = "Start Ping";
            this.tsmStartPing.Click += new System.EventHandler(this.tsmStartPing_Click);
            // 
            // tsmStopPing
            // 
            this.tsmStopPing.Name = "tsmStopPing";
            this.tsmStopPing.Size = new System.Drawing.Size(275, 30);
            this.tsmStopPing.Text = "Stop Ping";
            this.tsmStopPing.Click += new System.EventHandler(this.tsmStopPing_Click);
            // 
            // tsmApplyDefaultSettings
            // 
            this.tsmApplyDefaultSettings.Name = "tsmApplyDefaultSettings";
            this.tsmApplyDefaultSettings.Size = new System.Drawing.Size(275, 30);
            this.tsmApplyDefaultSettings.Text = "Apply Default Settings";
            this.tsmApplyDefaultSettings.Click += new System.EventHandler(this.tsmApplyDefaultSettings_Click);
            // 
            // tsmView
            // 
            this.tsmView.Name = "tsmView";
            this.tsmView.Size = new System.Drawing.Size(61, 29);
            this.tsmView.Text = "View";
            // 
            // tsmHelp
            // 
            this.tsmHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmAbout});
            this.tsmHelp.Name = "tsmHelp";
            this.tsmHelp.Size = new System.Drawing.Size(61, 29);
            this.tsmHelp.Text = "Help";
            // 
            // tsmAbout
            // 
            this.tsmAbout.Name = "tsmAbout";
            this.tsmAbout.Size = new System.Drawing.Size(211, 30);
            this.tsmAbout.Text = "About";
            this.tsmAbout.Click += new System.EventHandler(this.tsmAbout_Click);
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.Location = new System.Drawing.Point(430, 64);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(73, 20);
            this.lblOutput.TabIndex = 5;
            this.lblOutput.Text = "lblOutput";
            this.lblOutput.Visible = false;
            // 
            // lblGoodRx
            // 
            this.lblGoodRx.AutoSize = true;
            this.lblGoodRx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGoodRx.Location = new System.Drawing.Point(519, 55);
            this.lblGoodRx.Name = "lblGoodRx";
            this.lblGoodRx.Size = new System.Drawing.Size(119, 29);
            this.lblGoodRx.TabIndex = 6;
            this.lblGoodRx.Text = "Good Rx: ";
            // 
            // lblBadRx
            // 
            this.lblBadRx.AutoSize = true;
            this.lblBadRx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBadRx.Location = new System.Drawing.Point(519, 84);
            this.lblBadRx.Name = "lblBadRx";
            this.lblBadRx.Size = new System.Drawing.Size(102, 29);
            this.lblBadRx.TabIndex = 7;
            this.lblBadRx.Text = "Bad Rx: ";
            // 
            // lblPercentage
            // 
            this.lblPercentage.AutoSize = true;
            this.lblPercentage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPercentage.Location = new System.Drawing.Point(519, 113);
            this.lblPercentage.Name = "lblPercentage";
            this.lblPercentage.Size = new System.Drawing.Size(91, 29);
            this.lblPercentage.TabIndex = 7;
            this.lblPercentage.Text = "% loss:";
            // 
            // lblLongestRx
            // 
            this.lblLongestRx.AutoSize = true;
            this.lblLongestRx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLongestRx.Location = new System.Drawing.Point(519, 156);
            this.lblLongestRx.Name = "lblLongestRx";
            this.lblLongestRx.Size = new System.Drawing.Size(145, 29);
            this.lblLongestRx.TabIndex = 6;
            this.lblLongestRx.Text = "Longest Rx: ";
            // 
            // lblShortestRx
            // 
            this.lblShortestRx.AutoSize = true;
            this.lblShortestRx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShortestRx.Location = new System.Drawing.Point(519, 186);
            this.lblShortestRx.Name = "lblShortestRx";
            this.lblShortestRx.Size = new System.Drawing.Size(136, 29);
            this.lblShortestRx.TabIndex = 7;
            this.lblShortestRx.Text = "ShortestRx:";
            // 
            // lblAverage
            // 
            this.lblAverage.AutoSize = true;
            this.lblAverage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAverage.Location = new System.Drawing.Point(519, 215);
            this.lblAverage.Name = "lblAverage";
            this.lblAverage.Size = new System.Drawing.Size(142, 29);
            this.lblAverage.TabIndex = 7;
            this.lblAverage.Text = "Average Rx:";
            // 
            // lstMonitor
            // 
            this.lstMonitor.Location = new System.Drawing.Point(708, 47);
            this.lstMonitor.Name = "lstMonitor";
            this.lstMonitor.Size = new System.Drawing.Size(702, 348);
            this.lstMonitor.TabIndex = 10;
            this.lstMonitor.UseCompatibleStateImageBehavior = false;
            this.lstMonitor.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.lstMonitor_ColumnClick);
            // 
            // tsmExit
            // 
            this.tsmExit.Name = "tsmExit";
            this.tsmExit.Size = new System.Drawing.Size(211, 30);
            this.tsmExit.Text = "Exit";
            this.tsmExit.Click += new System.EventHandler(this.tsmExit_Click);
            // 
            // PingMetricsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1418, 403);
            this.Controls.Add(this.lstMonitor);
            this.Controls.Add(this.lblAverage);
            this.Controls.Add(this.lblPercentage);
            this.Controls.Add(this.lblShortestRx);
            this.Controls.Add(this.lblBadRx);
            this.Controls.Add(this.lblLongestRx);
            this.Controls.Add(this.lblGoodRx);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.grpPingSettings);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "PingMetricsForm";
            this.Text = "Ping Logging Tool";
            this.grpPingSettings.ResumeLayout(false);
            this.grpPingSettings.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox grpPingSettings;
        private System.Windows.Forms.Button btnBeginPing;
        private System.Windows.Forms.TextBox txtIterations;
        private System.Windows.Forms.TextBox txtBytesToSend;
        private System.Windows.Forms.TextBox txtHostIPAddress;
        private System.Windows.Forms.RadioButton optFinite;
        private System.Windows.Forms.RadioButton optIndefinite;
        private System.Windows.Forms.Label lblIterations;
        private System.Windows.Forms.Label lblBytesToSend;
        private System.Windows.Forms.Label lblHostIPAddress;
        private System.Windows.Forms.Button btnDefault;
        private System.Windows.Forms.Button btnStopPing;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmFile;
        private System.Windows.Forms.ToolStripMenuItem tsmLogOptions;
        private System.Windows.Forms.ToolStripMenuItem tsmPingOptions;
        private System.Windows.Forms.ToolStripMenuItem tsmHelp;
        private System.Windows.Forms.ToolStripMenuItem tsmAbout;
        private System.Windows.Forms.ToolStripMenuItem tsmSaveLogAs;
        private System.Windows.Forms.ToolStripMenuItem tsmStartPing;
        private System.Windows.Forms.ToolStripMenuItem tsmStopPing;
        private System.Windows.Forms.Button btnPathBrowse;
        private System.Windows.Forms.CheckBox chkLog;
        private System.Windows.Forms.TextBox txtLogPath;
        private System.Windows.Forms.Label lblLogPath;
        private System.Windows.Forms.ToolStripMenuItem tsmApplyDefaultSettings;
        private System.Windows.Forms.TextBox txtTimeout;
        private System.Windows.Forms.Label lblTimeout;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.Label lblGoodRx;
        private System.Windows.Forms.Label lblBadRx;
        private System.Windows.Forms.Label lblPercentage;
        private System.Windows.Forms.Label lblLongestRx;
        private System.Windows.Forms.Label lblShortestRx;
        private System.Windows.Forms.Label lblAverage;
        private System.Windows.Forms.ToolStripMenuItem tsmView;
        private System.Windows.Forms.ListView lstMonitor;
        private System.Windows.Forms.ToolStripMenuItem tsmExit;
    }
}

