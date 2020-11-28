using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimerTask
{
    public class MethodProcessor : ICountDownNotifier
    {
        public MethodProcessor(Timer timer, TaskTimeStarted timeStarted, Action<string> timeEnded)
        {
            Timer = timer;
            TimeStarted = timeStarted;
            TimeEnded = timeEnded;
        }

        Timer Timer { get; set; }
        TaskTimeStarted TimeStarted { get; set; }
        Action<string> TimeEnded { get; set; }

        void ICountDownNotifier.Init()
        {
            Timer.Start += OnTimerStart;
            Timer.Tick += OnTimerTick;
            Timer.End += OnTimerEnd;
        }

        void ICountDownNotifier.Run()
        {
            Timer.OnStart();
        }

        void ICountDownNotifier.Unsubscribe()
        {
            Timer.Start -= OnTimerStart;
            Timer.Tick -= OnTimerTick;
            Timer.End -= OnTimerEnd;
        }

        private void OnTimerStart(string name, int secondsAmount)
        {
            TimeStarted(name, secondsAmount);
        }


        private void OnTimerTick(string name, int secondsAmount)
        {
            int realSeconds = DateTime.Now.Second;
            Console.WriteLine("[{0}]:Timer: {1}: {2} seconds remaining", realSeconds, name, secondsAmount);
        }

        private void OnTimerEnd(string name)
        {
            TimeEnded(name);
        }
    }
}
