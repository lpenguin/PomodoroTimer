using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PomodoroTimer
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
        }

        private void SettingsForm_Shown(object sender, EventArgs e)
        {
            this.workSecomndsTextbox.Text = ((int)(Properties.Settings.Default.WorkSeconds) / 60).ToString();
            this.breakMinutesTextBox.Text = ((int)(Properties.Settings.Default.BreakSeconds) / 60).ToString();
            this.longBreakMinutesTextBox.Text = ((int)(Properties.Settings.Default.LongBreakSeconds) / 60).ToString();
            this.hideToTrayCheckBox.Checked = Properties.Settings.Default.HideToTray;
            this.showTimeCorrectionCheckBox.Checked = Properties.Settings.Default.ShowTimeCorrection;
            this.windowNotifCheckBox.Checked = Properties.Settings.Default.ShowWindowNotif;
            this.minimizeWhenStartCheckBox.Checked = Properties.Settings.Default.MinimizeAtStart;
            this.cb_remind.Checked = Properties.Settings.Default.RemindWhenPaused;
            this.tb_remindPeriod.Text = ((int)(Properties.Settings.Default.RemindPeriod)).ToString();
            //this.baloonSecondsTextBox.Text = Properties.Settings.Default.BaloonSeconds.ToString();
        }


        private void Save()
        {
            Properties.Settings.Default.WorkSeconds = int.Parse(this.workSecomndsTextbox.Text) * 60;
            Properties.Settings.Default.BreakSeconds = int.Parse(this.breakMinutesTextBox.Text) * 60;
            Properties.Settings.Default.LongBreakSeconds = int.Parse(this.longBreakMinutesTextBox.Text) * 60;

            Properties.Settings.Default.HideToTray = this.hideToTrayCheckBox.Checked;
            Properties.Settings.Default.ShowTimeCorrection = this.showTimeCorrectionCheckBox.Checked;
            Properties.Settings.Default.ShowWindowNotif = this.windowNotifCheckBox.Checked;
            Properties.Settings.Default.MinimizeAtStart = this.minimizeWhenStartCheckBox.Checked;
            Properties.Settings.Default.RemindWhenPaused = this.cb_remind.Checked;
            Properties.Settings.Default.RemindPeriod = int.Parse(this.tb_remindPeriod.Text);
            //Properties.Settings.Default.BaloonSeconds = int.Parse(this.baloonSecondsTextBox.Text);
            Properties.Settings.Default.Save();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            this.Save();
            this.Close();
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {

        }
    }
}
