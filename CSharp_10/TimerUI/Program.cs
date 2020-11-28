using System;
using TimerTask;

namespace TimerUI
{
    

    class Program
    {
        string timerName;


        static void Main(string[] args)
        {
            Timer timer = new Timer("JOPA", 10);

            MethodProcessor methodProcessor = new MethodProcessor(timer, SayStart, SayEnd);

        }

        private static void SayEnd(string taskName)
        {
            int realSeconds = DateTime.Now.Second;
            Console.WriteLine("[{0}]:Timer: {1} has finished", realSeconds, taskName);
        }

        delegate void Starting(string name, int seconds);

        public static void SayStart(string taskName, int secondsAmount)
        {
            int realSeconds = DateTime.Now.Second;
            Console.WriteLine("[{0}]:Timer: {1} has started for {2} seconds", realSeconds, taskName, secondsAmount);
        }
    }
}
