namespace AWS_IP_Update
{
    public partial class AWSIPUpdateForm : Form
    {
        public AWSIPUpdateForm()
        {
            InitializeComponent();

            labelLogMessage.Text = "";
            Logger.LogAdded += Logger_LogAdded;

            textBoxAWSAccessKey.DataBindings.Add(new Binding("Text",
                Settings.Default, "AccessKeyID", true, DataSourceUpdateMode.OnPropertyChanged));
            textBoxAWSSecret.DataBindings.Add(new Binding("Text",
                Settings.Default, "SecretAccessKey", true, DataSourceUpdateMode.OnPropertyChanged));
            textBoxZoneID.DataBindings.Add(new Binding("Text",
                Settings.Default, "ZoneID", true, DataSourceUpdateMode.OnPropertyChanged));
            textBoxRecordSet.DataBindings.Add(new Binding("Text",
                Settings.Default, "RecordSet", true, DataSourceUpdateMode.OnPropertyChanged));
            textBoxIPProvider.DataBindings.Add(new Binding("Text",
                Settings.Default, "IPProvider", true, DataSourceUpdateMode.OnPropertyChanged));
            textBoxLastIPAddress.DataBindings.Add(new Binding("Text",
                Settings.Default, "LastIPAddress", true, DataSourceUpdateMode.OnPropertyChanged));

            checkBoxHideOnStart.DataBindings.Add(new Binding("Checked",
                Settings.Default, "HideOnStart", true, DataSourceUpdateMode.OnPropertyChanged));
            checkBoxTimerEnabled.DataBindings.Add(new Binding("Checked",
                Settings.Default, "TimerEnabled", true, DataSourceUpdateMode.OnPropertyChanged));

        }

        private void Logger_LogAdded(string message)
        {
            this.Invoke(new Action(() =>
            {
                labelLogMessage.Text = message;
            }));
        }

        private void AWSIPUpdateForm_Load(object sender, EventArgs e)
        {
            if (Settings.Default.HideOnStart)
            {
                SendToTray();
            }
        }

        private void SendToTray()
        {
            if (this.WindowState != FormWindowState.Minimized)
                this.WindowState = FormWindowState.Minimized;
            // this.notifyIcon1.Visible = true;
            this.Hide();
            this.ShowInTaskbar = false;
        }

        private void RestoreFromTray()
        {
            this.ShowInTaskbar = true;
            this.Show();
            this.WindowState = FormWindowState.Normal;
            // this.notifyIcon1.Visible = false;
        }

        private void notifyIcon1_Click(object sender, EventArgs e)
        {
            RestoreFromTray();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            Settings.Default.Save();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            IPUpdater.Update();
        }

        private void checkBoxTimerEnabled_CheckedChanged(object sender, EventArgs e)
        {
            timer1.Enabled = checkBoxTimerEnabled.Checked;
            if (timer1.Enabled)
            {
                timer1_Tick(sender, e);
            }
        }

        private void buttonOpenLogFolder_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("explorer.exe", Logger.LogPath);
        }
    }
}