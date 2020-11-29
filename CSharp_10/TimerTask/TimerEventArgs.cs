using System;
using System.Threading;

namespace TimerTask
{
    public delegate void TaskTimeStarted(string taskName, int secondsAmount);
    public delegate void TimerEventHandler(string taskName, int secondsAmount);

    public class TimerEventArgs : EventArgs
    {
        public string Name { get; set; }
        public int SecondsAmount { get; set; }

        public TimerEventArgs(string name, int secondsAmount)
        {
            Name = name;
            SecondsAmount = secondsAmount;
        }

        public void OnStart()
        {
            Start?.Invoke(EventArgs.Empty, this);
            OnWork();
        }

        public void OnWork()
        {
            while (SecondsAmount >= 0)
            {
                Tick?.Invoke(EventArgs.Empty,this);
                SecondsAmount--;
                Thread.Sleep(1000);
            }

            OnEnd();
        }

        public void OnEnd()
        {
            End?.Invoke(EventArgs.Empty, this);
        }

        public event EventHandler<TimerEventArgs> Start;
        public event EventHandler<TimerEventArgs> Tick;
        public event EventHandler<TimerEventArgs> End;

    }
}
