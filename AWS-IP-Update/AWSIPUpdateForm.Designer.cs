namespace AWS_IP_Update
{
    partial class AWSIPUpdateForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AWSIPUpdateForm));
            textBoxAWSAccessKey = new TextBox();
            labelAWSAccessKey = new Label();
            labelAWSSecret = new Label();
            textBoxAWSSecret = new TextBox();
            labelZoneID = new Label();
            textBoxZoneID = new TextBox();
            labelRecordSet = new Label();
            textBoxRecordSet = new TextBox();
            labelIPProvider = new Label();
            textBoxIPProvider = new TextBox();
            labelLastIPAddress = new Label();
            textBoxLastIPAddress = new TextBox();
            button1 = new Button();
            notifyIcon1 = new NotifyIcon(components);
            timer1 = new System.Windows.Forms.Timer(components);
            checkBoxHideOnStart = new CheckBox();
            checkBoxTimerEnabled = new CheckBox();
            labelLogMessage = new Label();
            buttonOpenLogFolder = new Button();
            SuspendLayout();
            // 
            // textBoxAWSAccessKey
            // 
            textBoxAWSAccessKey.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxAWSAccessKey.Location = new Point(110, 12);
            textBoxAWSAccessKey.Name = "textBoxAWSAccessKey";
            textBoxAWSAccessKey.Size = new Size(500, 23);
            textBoxAWSAccessKey.TabIndex = 0;
            // 
            // labelAWSAccessKey
            // 
            labelAWSAccessKey.AutoSize = true;
            labelAWSAccessKey.Location = new Point(12, 15);
            labelAWSAccessKey.Name = "labelAWSAccessKey";
            labelAWSAccessKey.Size = new Size(92, 15);
            labelAWSAccessKey.TabIndex = 1;
            labelAWSAccessKey.Text = "AWS Access Key";
            // 
            // labelAWSSecret
            // 
            labelAWSSecret.AutoSize = true;
            labelAWSSecret.Location = new Point(12, 44);
            labelAWSSecret.Name = "labelAWSSecret";
            labelAWSSecret.Size = new Size(66, 15);
            labelAWSSecret.TabIndex = 3;
            labelAWSSecret.Text = "AWS Secret";
            // 
            // textBoxAWSSecret
            // 
            textBoxAWSSecret.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxAWSSecret.Location = new Point(110, 41);
            textBoxAWSSecret.Name = "textBoxAWSSecret";
            textBoxAWSSecret.PasswordChar = '●';
            textBoxAWSSecret.Size = new Size(500, 23);
            textBoxAWSSecret.TabIndex = 2;
            // 
            // labelZoneID
            // 
            labelZoneID.AutoSize = true;
            labelZoneID.Location = new Point(12, 73);
            labelZoneID.Name = "labelZoneID";
            labelZoneID.Size = new Size(48, 15);
            labelZoneID.TabIndex = 5;
            labelZoneID.Text = "Zone ID";
            // 
            // textBoxZoneID
            // 
            textBoxZoneID.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxZoneID.Location = new Point(110, 70);
            textBoxZoneID.Name = "textBoxZoneID";
            textBoxZoneID.Size = new Size(500, 23);
            textBoxZoneID.TabIndex = 4;
            // 
            // labelRecordSet
            // 
            labelRecordSet.AutoSize = true;
            labelRecordSet.Location = new Point(12, 102);
            labelRecordSet.Name = "labelRecordSet";
            labelRecordSet.Size = new Size(63, 15);
            labelRecordSet.TabIndex = 7;
            labelRecordSet.Text = "Record Set";
            // 
            // textBoxRecordSet
            // 
            textBoxRecordSet.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxRecordSet.Location = new Point(110, 99);
            textBoxRecordSet.Name = "textBoxRecordSet";
            textBoxRecordSet.Size = new Size(500, 23);
            textBoxRecordSet.TabIndex = 6;
            // 
            // labelIPProvider
            // 
            labelIPProvider.AutoSize = true;
            labelIPProvider.Location = new Point(12, 131);
            labelIPProvider.Name = "labelIPProvider";
            labelIPProvider.Size = new Size(64, 15);
            labelIPProvider.TabIndex = 9;
            labelIPProvider.Text = "IP Provider";
            // 
            // textBoxIPProvider
            // 
            textBoxIPProvider.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxIPProvider.Location = new Point(110, 128);
            textBoxIPProvider.Name = "textBoxIPProvider";
            textBoxIPProvider.Size = new Size(500, 23);
            textBoxIPProvider.TabIndex = 8;
            // 
            // labelLastIPAddress
            // 
            labelLastIPAddress.AutoSize = true;
            labelLastIPAddress.Location = new Point(12, 160);
            labelLastIPAddress.Name = "labelLastIPAddress";
            labelLastIPAddress.Size = new Size(86, 15);
            labelLastIPAddress.TabIndex = 11;
            labelLastIPAddress.Text = "Last IP Address";
            // 
            // textBoxLastIPAddress
            // 
            textBoxLastIPAddress.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxLastIPAddress.Location = new Point(110, 157);
            textBoxLastIPAddress.Name = "textBoxLastIPAddress";
            textBoxLastIPAddress.ReadOnly = true;
            textBoxLastIPAddress.Size = new Size(500, 23);
            textBoxLastIPAddress.TabIndex = 10;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button1.Location = new Point(535, 217);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 12;
            button1.Text = "Save";
            button1.UseVisualStyleBackColor = true;
            button1.Click += buttonSave_Click;
            // 
            // notifyIcon1
            // 
            notifyIcon1.Icon = (Icon)resources.GetObject("notifyIcon1.Icon");
            notifyIcon1.Text = "AWS IP Update";
            notifyIcon1.Visible = true;
            notifyIcon1.Click += notifyIcon1_Click;
            // 
            // timer1
            // 
            timer1.Interval = 300000;
            timer1.Tick += timer1_Tick;
            // 
            // checkBoxHideOnStart
            // 
            checkBoxHideOnStart.AutoSize = true;
            checkBoxHideOnStart.Location = new Point(15, 194);
            checkBoxHideOnStart.Name = "checkBoxHideOnStart";
            checkBoxHideOnStart.Size = new Size(121, 19);
            checkBoxHideOnStart.TabIndex = 13;
            checkBoxHideOnStart.Text = "Minimise On Start";
            checkBoxHideOnStart.UseVisualStyleBackColor = true;
            // 
            // checkBoxTimerEnabled
            // 
            checkBoxTimerEnabled.AutoSize = true;
            checkBoxTimerEnabled.Location = new Point(165, 194);
            checkBoxTimerEnabled.Name = "checkBoxTimerEnabled";
            checkBoxTimerEnabled.Size = new Size(101, 19);
            checkBoxTimerEnabled.TabIndex = 13;
            checkBoxTimerEnabled.Text = "Timer Enabled";
            checkBoxTimerEnabled.UseVisualStyleBackColor = true;
            checkBoxTimerEnabled.CheckedChanged += checkBoxTimerEnabled_CheckedChanged;
            // 
            // labelLogMessage
            // 
            labelLogMessage.AutoSize = true;
            labelLogMessage.Location = new Point(130, 225);
            labelLogMessage.Name = "labelLogMessage";
            labelLogMessage.Size = new Size(116, 15);
            labelLogMessage.TabIndex = 14;
            labelLogMessage.Text = "Latest Log Message: ";
            // 
            // buttonOpenLogFolder
            // 
            buttonOpenLogFolder.Location = new Point(15, 221);
            buttonOpenLogFolder.Name = "buttonOpenLogFolder";
            buttonOpenLogFolder.Size = new Size(109, 23);
            buttonOpenLogFolder.TabIndex = 15;
            buttonOpenLogFolder.Text = "Open Log Folder";
            buttonOpenLogFolder.UseVisualStyleBackColor = true;
            buttonOpenLogFolder.Click += buttonOpenLogFolder_Click;
            // 
            // AWSIPUpdateForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(622, 252);
            Controls.Add(buttonOpenLogFolder);
            Controls.Add(labelLogMessage);
            Controls.Add(checkBoxTimerEnabled);
            Controls.Add(checkBoxHideOnStart);
            Controls.Add(button1);
            Controls.Add(labelLastIPAddress);
            Controls.Add(textBoxLastIPAddress);
            Controls.Add(labelIPProvider);
            Controls.Add(textBoxIPProvider);
            Controls.Add(labelRecordSet);
            Controls.Add(textBoxRecordSet);
            Controls.Add(labelZoneID);
            Controls.Add(textBoxZoneID);
            Controls.Add(labelAWSSecret);
            Controls.Add(textBoxAWSSecret);
            Controls.Add(labelAWSAccessKey);
            Controls.Add(textBoxAWSAccessKey);
            MinimumSize = new Size(638, 291);
            Name = "AWSIPUpdateForm";
            Text = "AWS IP Update";
            Load += AWSIPUpdateForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxAWSAccessKey;
        private Label labelAWSAccessKey;
        private Label labelAWSSecret;
        private TextBox textBoxAWSSecret;
        private Label labelZoneID;
        private TextBox textBoxZoneID;
        private Label labelRecordSet;
        private TextBox textBoxRecordSet;
        private Label labelIPProvider;
        private TextBox textBoxIPProvider;
        private Label labelLastIPAddress;
        private TextBox textBoxLastIPAddress;
        private Button button1;
        private NotifyIcon notifyIcon1;
        private System.Windows.Forms.Timer timer1;
        private CheckBox checkBoxHideOnStart;
        private CheckBox checkBoxTimerEnabled;
        private Label labelLogMessage;
        private Button buttonOpenLogFolder;
    }
}