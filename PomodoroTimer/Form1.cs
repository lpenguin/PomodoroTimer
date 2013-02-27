using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Media;

namespace PomodoroTimer
{
    public enum TimerButtons { Work, Break, LongBreak, Pause, Resume };

    public partial class Form1 : Form
    {
        private readonly Timer _timer;
        private readonly TimerState _timerState;
        private const int TimerPeriod = 1000;
        private readonly SettingsForm _settingsForm = new SettingsForm();
        //private TimerButtons timerButton;

        private int _remindSeconds = 0;


        public Form1()
        {
            _timerState = new TimerState();

            _timer = new Timer();
            
            _timer.Tick += new EventHandler(TimerEventProcessor);
            _timer.Interval = TimerPeriod;
            this._timer.Start();


            _timerState.TimerDoneEvent += this.timerState_TimerDone;

            InitializeComponent();
            this.SetTimerButton(TimerButtons.Work);

            this.timerLabel.Text = this.GetFormattedTime(_timerState);
            this.stateLabel.Text = this.GetStatusString(_timerState);

            if (Properties.Settings.Default.ShowTimeCorrection)
            {
                this.timeCorrectionPanel.Visible = true;
            }
            //this.stateLabel.Text = this.GetStatusString(timerState);
        }

        private void ShowNotification(string text)
        {
            if (Properties.Settings.Default.ShowWindowNotif)
            {
                this.CenterToScreen();
                this.Show();
                this.WindowState = FormWindowState.Normal;
                
            }

            //this.notifyIcon1.
            this.notifyIcon1.BalloonTipText = text;
            this.notifyIcon1.ShowBalloonTip(Properties.Settings.Default.BaloonSeconds * 1000);
            
         
        }
        private void Pause()
        {
            this._timerState.Pause();
        }

        private void Resume()
        {
            this._timerState.Start();
        }
        private void SetTimerButton(TimerButtons timerButton)
        {
            //this.timerButton
            this.startButton.Visible = false;
            this.breakButton.Visible = false;
            this.longBreakButton.Visible = false;
            this.pauseButton.Visible = false;
            this.resumeButton.Visible = false;

            switch (timerButton)
            {
                case TimerButtons.Break:
                    this.breakButton.Visible = true;
                    break;
                case TimerButtons.LongBreak:
                    this.longBreakButton.Visible = true;
                    break;
                case TimerButtons.Pause:
                    this.pauseButton.Visible = true;
                    break;
                case TimerButtons.Work:
                    this.startButton.Visible = true;
                    break;
                case TimerButtons.Resume:
                    this.resumeButton.Visible = true;
                    break;
            }

        }

        private void TimerEventProcessor(Object myObject,
                                            EventArgs myEventArgs) 
        {
            //Console.WriteLine(_timerState.Paused);
            if (_timerState.Paused)
            {

                if (Properties.Settings.Default.RemindWhenPaused && Properties.Settings.Default.RemindPeriod != 0)
                {
                    this._remindSeconds++;
                    int p = Properties.Settings.Default.RemindPeriod;
                    if (this._remindSeconds % (p) == 0)
                    {
                        this.Show();
                        this.Activate();
                        this.WindowState = FormWindowState.Normal;
                        //this.ShowNotification(this.GetStatusString(timerState));
                        //this.PlaySoundDone();
                        
                    }
                }
                
            } 
            else
            {
                this._remindSeconds = 0;
                _timerState.Tick();
                this.timerLabel.Text = this.GetFormattedTime(_timerState);
            }

            this.notifyIcon1.Text = this.GetStatusString(_timerState) + ": " + this.GetFormattedTime(_timerState);
                ;
        }

        private string GetFormattedTime(TimerState timerState)
        {
            TimeSpan ts = new TimeSpan(0, 0, 0, timerState.Seconds, 0);

            return string.Format("{0:D2}:{1:D2}", ts.Minutes, ts.Seconds);
        }

        private string GetStatusString(TimerState timerState)
        {
            string paused = timerState.Paused ? ", paused" : "";
            string state = "";
            switch(timerState.State){
                case TimerStateEnum.Break:
                    state = "Time to break";
                    break;
                case TimerStateEnum.Work:
                    state = "Work in progress";
                    break;
                case TimerStateEnum.LongBreak:
                    state = "Time to long break";
                    break;
                case TimerStateEnum.WaitLongBreak:
                    state = "Waiting to take long break";
                    break;
                case TimerStateEnum.WaitBreak:
                    state = "Waiting to take break";
                    break;
                case TimerStateEnum.WaitWork:
                    state = "Waiting to begin work";
                    break;
            }
            return state; // +paused;
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            this._timerState.stateWork();
            
            this.stateLabel.Text = this.GetStatusString(_timerState);
            this.SetTimerButton(TimerButtons.Pause);
            this.Resume();
            if(Properties.Settings.Default.MinimizeAtStart)
                this.WindowState = FormWindowState.Minimized;
        }


        private void pauseButton_Click(object sender, EventArgs e)
        {
            this.Pause();
            this.stateLabel.Text = "Paused";//this.GetStatusString(timerState);
            this.SetTimerButton(TimerButtons.Resume);
        }


        private void timerState_TimerDone(TimerState timerState)
        {
            this.PlaySoundDone();
            this.Pause();
            if (this._timerState.State == TimerStateEnum.WaitWork)
            {
                this.SetTimerButton(TimerButtons.Work);

            }
            else if (this._timerState.State == TimerStateEnum.WaitBreak )
            {
                this.SetTimerButton(TimerButtons.Break);
            }
            else if (this._timerState.State == TimerStateEnum.WaitLongBreak)
            {
                this.SetTimerButton(TimerButtons.LongBreak);
            }
            this.stateLabel.Text = this.GetStatusString(timerState);
            this.ShowNotification(this.GetStatusString(timerState));
        }

        

        private void PlaySoundDone()
        {
            SoundPlayer player = new SoundPlayer();

            player.SoundLocation = "done.wav";
            player.Play();
        }

        private void breakButton_Click(object sender, EventArgs e)
        {
            this._timerState.stateBreak();
            this.SetTimerButton(TimerButtons.Pause);
            this.Resume();
            if(Properties.Settings.Default.MinimizeAtStart)
                this.WindowState = FormWindowState.Minimized;
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            this._timerState.Reset();
            this.timerLabel.Text = this.GetFormattedTime(_timerState);
            this.stateLabel.Text = this.GetStatusString(_timerState);
            this.Pause();
        }

        private void appToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this._settingsForm.ShowDialog();
            if (Properties.Settings.Default.ShowTimeCorrection)
            {
                this.timeCorrectionPanel.Visible = true;
            }
            else
            {
                this.timeCorrectionPanel.Visible = false;
            }

        }

        private void resumeButton_Click(object sender, EventArgs e)
        {
            this.Resume();
            this.SetTimerButton(TimerButtons.Pause);
            this.stateLabel.Text = this.GetStatusString(_timerState);
        }

        private void longBreakButton_Click(object sender, EventArgs e)
        {
            this._timerState.stateLongBreak();
            this.SetTimerButton(TimerButtons.Pause);
            this.Resume();
            if(Properties.Settings.Default.MinimizeAtStart)
                this.WindowState = FormWindowState.Minimized;
        }

        private void notifyIcon1_Click(object sender, EventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
            
        }

        private void notifyIcon1_BalloonTipClicked(object sender, EventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
            
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            if (FormWindowState.Minimized == this.WindowState)
            {
                notifyIcon1.Visible = true;
                if( Properties.Settings.Default.HideToTray )
                    this.Hide();
            }
            //else if (FormWindowState.Normal == this.WindowState)
            //{
            //    notifyIcon1.Visible = false;
            //}   
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this._timerState.Seconds -= 60;
            if (this._timerState.Seconds < 0)
                this._timerState.Seconds = 0;
            this.timerLabel.Text = this.GetFormattedTime(_timerState);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this._timerState.Seconds += 60;
            this.timerLabel.Text = this.GetFormattedTime(_timerState);
        }
    }
}
