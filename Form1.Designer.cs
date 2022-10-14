namespace GitLabSniffer
{
    partial class mainWindow
    {
        /// <summary>
        /// </summary>
        private System.ComponentModel.IContainer components = null;


        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form


        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainWindow));
            this.closeButton = new System.Windows.Forms.Button();
            this.inputOpener = new System.Windows.Forms.OpenFileDialog();
            this.infoLabel = new System.Windows.Forms.Label();
            this.inputFileBtn = new System.Windows.Forms.Button();
            this.startBtn = new System.Windows.Forms.Button();
            this.inputFileLabel = new System.Windows.Forms.Label();
            this.stateLabel = new System.Windows.Forms.Label();
            this.gitTextBox = new System.Windows.Forms.TextBox();
            this.gitTextLabel = new System.Windows.Forms.Label();
            this.patTextLabel = new System.Windows.Forms.Label();
            this.patTextBox = new System.Windows.Forms.TextBox();
            this.infotextLabel = new System.Windows.Forms.Label();
            this.useCustomLabel = new System.Windows.Forms.Label();
            this.usePatLabel = new System.Windows.Forms.Label();
            this.startDate = new System.Windows.Forms.DateTimePicker();
            this.endDate = new System.Windows.Forms.DateTimePicker();
            this.dateLabel = new System.Windows.Forms.Label();
            this.useDateLabel = new System.Windows.Forms.Label();
            this.resetDateBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.Color.Firebrick;
            this.closeButton.BackgroundImage = global::GitLabSniffer.Properties.Resources._52728_wrong_cross_white;
            this.closeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.closeButton.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.closeButton.FlatAppearance.BorderSize = 2;
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.closeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeButton.Location = new System.Drawing.Point(872, -5);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(110, 533);
            this.closeButton.TabIndex = 0;
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // inputOpener
            // 
            this.inputOpener.Filter = "Plain Text file| *.txt";
            this.inputOpener.Title = "Choose your txt input file";
            this.inputOpener.FileOk += new System.ComponentModel.CancelEventHandler(this.inputOpener_FileOk);
            // 
            // infoLabel
            // 
            this.infoLabel.AutoSize = true;
            this.infoLabel.BackColor = System.Drawing.Color.Transparent;
            this.infoLabel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.infoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoLabel.ForeColor = System.Drawing.Color.LightGray;
            this.infoLabel.Location = new System.Drawing.Point(25, 99);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(599, 120);
            this.infoLabel.TabIndex = 3;
            this.infoLabel.Text = resources.GetString("infoLabel.Text");
            // 
            // inputFileBtn
            // 
            this.inputFileBtn.BackColor = System.Drawing.Color.SlateBlue;
            this.inputFileBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.inputFileBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputFileBtn.Location = new System.Drawing.Point(630, 358);
            this.inputFileBtn.Name = "inputFileBtn";
            this.inputFileBtn.Size = new System.Drawing.Size(177, 50);
            this.inputFileBtn.TabIndex = 4;
            this.inputFileBtn.Text = "Choose input file";
            this.inputFileBtn.UseVisualStyleBackColor = false;
            this.inputFileBtn.Click += new System.EventHandler(this.inputFileBtn_Click);
            // 
            // startBtn
            // 
            this.startBtn.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.startBtn.Enabled = false;
            this.startBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.startBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startBtn.Location = new System.Drawing.Point(630, 423);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(177, 85);
            this.startBtn.TabIndex = 5;
            this.startBtn.Text = "START";
            this.startBtn.UseVisualStyleBackColor = false;
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // inputFileLabel
            // 
            this.inputFileLabel.BackColor = System.Drawing.Color.Transparent;
            this.inputFileLabel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.inputFileLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputFileLabel.ForeColor = System.Drawing.Color.LightGray;
            this.inputFileLabel.Location = new System.Drawing.Point(29, 474);
            this.inputFileLabel.Name = "inputFileLabel";
            this.inputFileLabel.Size = new System.Drawing.Size(576, 24);
            this.inputFileLabel.TabIndex = 6;
            this.inputFileLabel.Text = "| No input file selected";
            this.inputFileLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // stateLabel
            // 
            this.stateLabel.BackColor = System.Drawing.Color.SlateBlue;
            this.stateLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.stateLabel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.stateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stateLabel.Location = new System.Drawing.Point(0, 527);
            this.stateLabel.Name = "stateLabel";
            this.stateLabel.Size = new System.Drawing.Size(980, 33);
            this.stateLabel.TabIndex = 7;
            this.stateLabel.Text = "Ready for input file";
            this.stateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gitTextBox
            // 
            this.gitTextBox.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.gitTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gitTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gitTextBox.Location = new System.Drawing.Point(436, 251);
            this.gitTextBox.Name = "gitTextBox";
            this.gitTextBox.Size = new System.Drawing.Size(371, 29);
            this.gitTextBox.TabIndex = 8;
            // 
            // gitTextLabel
            // 
            this.gitTextLabel.AutoSize = true;
            this.gitTextLabel.BackColor = System.Drawing.Color.Transparent;
            this.gitTextLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gitTextLabel.ForeColor = System.Drawing.Color.Gainsboro;
            this.gitTextLabel.Location = new System.Drawing.Point(433, 232);
            this.gitTextLabel.Name = "gitTextLabel";
            this.gitTextLabel.Size = new System.Drawing.Size(324, 16);
            this.gitTextLabel.TabIndex = 9;
            this.gitTextLabel.Text = "Custom GitLab endpoint (gitlab.example.com):";
            // 
            // patTextLabel
            // 
            this.patTextLabel.AutoSize = true;
            this.patTextLabel.BackColor = System.Drawing.Color.Transparent;
            this.patTextLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patTextLabel.ForeColor = System.Drawing.Color.Gainsboro;
            this.patTextLabel.Location = new System.Drawing.Point(433, 294);
            this.patTextLabel.Name = "patTextLabel";
            this.patTextLabel.Size = new System.Drawing.Size(274, 16);
            this.patTextLabel.TabIndex = 11;
            this.patTextLabel.Text = "Your Private / Personal Access Token:";
            // 
            // patTextBox
            // 
            this.patTextBox.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.patTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.patTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patTextBox.Location = new System.Drawing.Point(436, 313);
            this.patTextBox.Name = "patTextBox";
            this.patTextBox.Size = new System.Drawing.Size(371, 29);
            this.patTextBox.TabIndex = 10;
            // 
            // infotextLabel
            // 
            this.infotextLabel.AutoSize = true;
            this.infotextLabel.BackColor = System.Drawing.Color.Transparent;
            this.infotextLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infotextLabel.ForeColor = System.Drawing.Color.Gainsboro;
            this.infotextLabel.Location = new System.Drawing.Point(106, 255);
            this.infotextLabel.Name = "infotextLabel";
            this.infotextLabel.Size = new System.Drawing.Size(326, 80);
            this.infotextLabel.TabIndex = 12;
            this.infotextLabel.Text = "If they\'re empty, it will be used the default |\r\nendpoint and no token. You can a" +
    "lso fill |\r\nonly the token part, so you can use it with |\r\npersonal projects and" +
    " default endpoint. |";
            this.infotextLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // useCustomLabel
            // 
            this.useCustomLabel.BackColor = System.Drawing.Color.BlueViolet;
            this.useCustomLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.useCustomLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.useCustomLabel.Location = new System.Drawing.Point(63, 368);
            this.useCustomLabel.Name = "useCustomLabel";
            this.useCustomLabel.Size = new System.Drawing.Size(190, 26);
            this.useCustomLabel.TabIndex = 13;
            this.useCustomLabel.Text = "Using custom endpoint";
            this.useCustomLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.useCustomLabel.Visible = false;
            // 
            // usePatLabel
            // 
            this.usePatLabel.BackColor = System.Drawing.Color.BlueViolet;
            this.usePatLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.usePatLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usePatLabel.Location = new System.Drawing.Point(63, 393);
            this.usePatLabel.Name = "usePatLabel";
            this.usePatLabel.Size = new System.Drawing.Size(190, 26);
            this.usePatLabel.TabIndex = 14;
            this.usePatLabel.Text = "Using private token";
            this.usePatLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.usePatLabel.Visible = false;
            // 
            // startDate
            // 
            this.startDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startDate.Location = new System.Drawing.Point(363, 383);
            this.startDate.Name = "startDate";
            this.startDate.Size = new System.Drawing.Size(234, 24);
            this.startDate.TabIndex = 16;
            this.startDate.Value = new System.DateTime(2022, 6, 4, 15, 23, 27, 0);
            this.startDate.ValueChanged += new System.EventHandler(this.startDate_ValueChanged);
            // 
            // endDate
            // 
            this.endDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endDate.Location = new System.Drawing.Point(363, 414);
            this.endDate.Name = "endDate";
            this.endDate.Size = new System.Drawing.Size(234, 24);
            this.endDate.TabIndex = 17;
            this.endDate.Value = new System.DateTime(2022, 6, 4, 15, 23, 32, 0);
            this.endDate.ValueChanged += new System.EventHandler(this.endDate_ValueChanged);
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.BackColor = System.Drawing.Color.Transparent;
            this.dateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateLabel.ForeColor = System.Drawing.Color.Gainsboro;
            this.dateLabel.Location = new System.Drawing.Point(363, 364);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(223, 16);
            this.dateLabel.TabIndex = 18;
            this.dateLabel.Text = "Date range for merged merges:";
            // 
            // useDateLabel
            // 
            this.useDateLabel.BackColor = System.Drawing.Color.BlueViolet;
            this.useDateLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.useDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.useDateLabel.Location = new System.Drawing.Point(63, 418);
            this.useDateLabel.Name = "useDateLabel";
            this.useDateLabel.Size = new System.Drawing.Size(190, 26);
            this.useDateLabel.TabIndex = 19;
            this.useDateLabel.Text = "Using date range";
            this.useDateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.useDateLabel.Visible = false;
            // 
            // resetDateBtn
            // 
            this.resetDateBtn.BackColor = System.Drawing.Color.DarkOrchid;
            this.resetDateBtn.BackgroundImage = global::GitLabSniffer.Properties.Resources._52728_wrong_cross_white;
            this.resetDateBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.resetDateBtn.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.resetDateBtn.FlatAppearance.BorderSize = 2;
            this.resetDateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.resetDateBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetDateBtn.Location = new System.Drawing.Point(331, 383);
            this.resetDateBtn.Name = "resetDateBtn";
            this.resetDateBtn.Size = new System.Drawing.Size(26, 55);
            this.resetDateBtn.TabIndex = 20;
            this.resetDateBtn.UseVisualStyleBackColor = false;
            this.resetDateBtn.Click += new System.EventHandler(this.resetDateBtn_Click);
            // 
            // mainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::GitLabSniffer.Properties.Resources.SNIFFER;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(980, 560);
            this.Controls.Add(this.resetDateBtn);
            this.Controls.Add(this.useDateLabel);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.endDate);
            this.Controls.Add(this.startDate);
            this.Controls.Add(this.usePatLabel);
            this.Controls.Add(this.useCustomLabel);
            this.Controls.Add(this.infotextLabel);
            this.Controls.Add(this.patTextLabel);
            this.Controls.Add(this.patTextBox);
            this.Controls.Add(this.gitTextLabel);
            this.Controls.Add(this.gitTextBox);
            this.Controls.Add(this.stateLabel);
            this.Controls.Add(this.inputFileLabel);
            this.Controls.Add(this.startBtn);
            this.Controls.Add(this.inputFileBtn);
            this.Controls.Add(this.infoLabel);
            this.Controls.Add(this.closeButton);
            this.Cursor = System.Windows.Forms.Cursors.PanNW;
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "mainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GitLab Merge Sniffer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.OpenFileDialog inputOpener;
        private System.Windows.Forms.Label infoLabel;
        private System.Windows.Forms.Button inputFileBtn;
        private System.Windows.Forms.Button startBtn;
        private System.Windows.Forms.Label inputFileLabel;
        private System.Windows.Forms.Label stateLabel;
        private System.Windows.Forms.TextBox gitTextBox;
        private System.Windows.Forms.Label gitTextLabel;
        private System.Windows.Forms.Label patTextLabel;
        private System.Windows.Forms.TextBox patTextBox;
        private System.Windows.Forms.Label infotextLabel;
        private System.Windows.Forms.Label useCustomLabel;
        private System.Windows.Forms.Label usePatLabel;
        private System.Windows.Forms.DateTimePicker startDate;
        private System.Windows.Forms.DateTimePicker endDate;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Label useDateLabel;
        private System.Windows.Forms.Button resetDateBtn;
    }
}

