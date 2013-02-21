using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PomodoroTimer
{
    public enum TimerStateEnum {
        Work, Break, LongBreak, Init, WaitWork, WaitBreak, WaitLongBreak
    }

    
    public class TimerState
    {
        //public const int WorkSeconds = 25 * 60;
        //public const int BreakSeconds = 3 * 60;
        //public const int LongBreakSeconds = 30 * 60;
        //public int WorkSeconds { get; set; }
        //public int BreakSeconds { get; set; }
        //public int LongBreakSeconds { get; set; }

        public int Seconds { get; set; }
        public TimerStateEnum State { get; set; }
        public bool Paused {get; set;}

        public delegate void TimerStateDelegate(TimerState timerState);


        //public event TimerStateDelegate ModeChanged;
        //public event TimerStateDelegate SessionDone;
        //public event TimerStateDelegate BreakDone;
        public event TimerStateDelegate TimerDoneEvent;

        private int sessionNumber = 1;
        private const int maxSessions = 4;
        public TimerState(){
            //this.WorkSeconds = 25 * 60;
            //this.LongBreakSeconds = 15 * 60;
            //this.BreakSeconds = 3 * 60;
            //this.WorkSeconds = 5;
            //this.LongBreakSeconds = 4;
            //this.BreakSeconds = 3;

            this.State = TimerStateEnum.Init;
            this.Paused = true;
            this.Next();

            

        }


        public void Next(){
            switch (this.State)
            {
                case TimerStateEnum.Work:
                    {
                        this.sessionNumber++;
                        if (this.sessionNumber > maxSessions)
                        {
                            this.sessionNumber = 1;
                            this.stateWaitLongBreak();

                        }
                        else
                            this.stateWaitBreak();

                    }
                    break;
                case TimerStateEnum.Break:
                case TimerStateEnum.LongBreak:
                case TimerStateEnum.Init:
                    this.stateWaitWork();
                    break;

            }
        }

        public void stateWork()
        {
            this.setState(TimerStateEnum.Work);
            this.Start();
        }

        public void stateBreak()
        {
            this.setState(TimerStateEnum.Break);
            this.Start();
        }

        public void stateLongBreak()
        {
            this.setState(TimerStateEnum.LongBreak);
            this.Start();
        }

        public void stateWaitBreak()
        {
            this.TakeBreak(TimerStateEnum.WaitBreak);
            this.Seconds = (int)Properties.Settings.Default["BreakSeconds"];

        }

        public void stateWaitLongBreak()
        {
            this.TakeBreak(TimerStateEnum.WaitLongBreak);
            this.Seconds = (int)Properties.Settings.Default["LongBreakSeconds"];
        }

        public void stateWaitWork()
        {
            this.TakeBreak(TimerStateEnum.WaitWork);
            this.Seconds = (int)Properties.Settings.Default["WorkSeconds"];
        }

        public void setState(TimerStateEnum state)
        {
            this.State = state;
        }

        private void TimerDone()
        {
            if (this.TimerDoneEvent != null)
                this.TimerDoneEvent(this);
        }

        private void TakeBreak(TimerStateEnum stateBreak)
        {
            this.setState(stateBreak);
            this.Pause();
            this.TimerDone();
        }

        public void Tick(){
            this.Seconds -= 1;
            if (this.Seconds <= 0)
            {
                this.Next();
                //if (this.ModeChanged != null)
                //  this.ModeChanged(this);
            }
        }

        public void Start()
        {
            this.Paused = false;
        }

        public void Pause()
        {
            this.Paused = true;
        }

        public void Reset()
        {
            this.Pause();
            this.State = TimerStateEnum.Init;
            this.Seconds = (int)Properties.Settings.Default["WorkSeconds"]; ;
            this.Next();
        }
    }
}
