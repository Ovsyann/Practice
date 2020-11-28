using System;

namespace TimerTask
{
    public delegate void TaskTimeStarted(string taskName, int secondsAmount);

    public delegate void TaskTimeEnded(string taskName);

    public delegate void TimerEventHandler(string taskName, int secondsAmount);
    public class Timer
    {
        public string Name { get; set; }
        public int SecondsAmount { get; set; }

        public Timer(string name, int secondsAmount)
        {
            Name = name;
            SecondsAmount = secondsAmount;
        }

        public void OnEnd()
        {
            End?.Invoke(Name);
        }

        public void OnWork(int secondsAmount)
        {
            while (secondsAmount >= 0)
            {
                Tick?.Invoke(Name, SecondsAmount--);
            }
        }

        public void OnStart()
        {
            Start?.Invoke(Name, SecondsAmount);
        }

        public event TaskTimeStarted Start;
        public event TimerEventHandler Tick;
        public event TaskTimeEnded End;

    }
}
