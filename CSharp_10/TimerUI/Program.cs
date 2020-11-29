using System;
using TimerTask;

namespace TimerUI
{
    

    class Program
    {
        string timerName;


        static void Main(string[] args)
        {
            TimerEventArgs timerA = SetupTimer();
            TimerEventArgs timerB = SetupTimer();
            TimerEventArgs timerC = SetupTimer();

            ICountDownNotifier[] notifiers = GetNotifiers(timerA, timerB, timerC);
            
            foreach(ICountDownNotifier notifier in notifiers)
            {
                notifier.Init();
            }

            ICountDownNotifier methodProcessor = Array.Find(notifiers, p => p as MethodProcessor != null);
            methodProcessor.Run();
            // Метод массива, который принимает делегат??
        }

        private static ICountDownNotifier[] GetNotifiers(
            TimerEventArgs timerA, TimerEventArgs timerB, TimerEventArgs timerC)
        {
            return new ICountDownNotifier[]
                { new MethodProcessor(timerA,SayStart,SayEnd),
                  new DelegateProcessor(timerB,SayStart,SayEnd),
                  new LambdaProcessor(timerC,SayStart,SayEnd) };
        }

        private static TimerEventArgs SetupTimer()
        {
            string timerName = Console.ReadLine();
            int secondsAmount = InputInteger("input seconds amount for timer", "input positive integral number!", 0);
            TimerEventArgs timer = new TimerEventArgs(timerName, secondsAmount);
            return timer;
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

        private static int InputInteger(string inputMessage, string failMessage, int? min = null)
        {
            Console.WriteLine(inputMessage);
            int number;
            while (!int.TryParse(Console.ReadLine(), out number) || (min.HasValue && number < min))
            {
                Console.WriteLine(failMessage);
            }

            return number;
        }
    }
}
