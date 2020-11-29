using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimerTask
{
    public class LambdaProcessor :ICountDownNotifier
    {
        public LambdaProcessor(TimerEventArgs timer, TaskTimeStarted taskTimeStarted, Action<string> taskTimeEnded)
        {
            Timer = timer;
            TaskTimeStarted = taskTimeStarted;
            TaskTimeEnded = taskTimeEnded;

            TimerStarted = (object sender, TimerEventArgs e) => 
            { 
                TaskTimeStarted(e.Name, e.SecondsAmount); 
            };

            TimerChanged = (object sender, TimerEventArgs e) =>
            {
                int realSeconds = DateTime.Now.Second;
                Console.WriteLine("[{0}]:Timer: {1}: {2} seconds remaining", realSeconds, e.Name, e.SecondsAmount);
            };

            TimerEnded = (object sender, TimerEventArgs e) =>
            {
                TaskTimeEnded(e.Name);
            };
        }

        TimerEventArgs Timer { get; set; }
        TaskTimeStarted TaskTimeStarted { get; set; }
        Action<string> TaskTimeEnded { get; set; }
        EventHandler<TimerEventArgs> TimerChanged { get; set; }
        EventHandler<TimerEventArgs> TimerStarted { get; set; }
        EventHandler<TimerEventArgs> TimerEnded { get; set; }

        void ICountDownNotifier.Init()
        {
            Timer.Start += TimerStarted;
            Timer.Tick += TimerChanged;
            Timer.End += TimerEnded;
        }

        void ICountDownNotifier.Run()
        {
            Timer.OnStart();
        }

        void ICountDownNotifier.Unsubscribe()
        {
            Timer.Start -= TimerStarted;
            Timer.Tick -= TimerChanged;
            Timer.End -= TimerEnded;
        }
    }
}
