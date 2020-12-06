using System;
using TimerTask;

namespace TimerUI
{
    

    class Program
    {
        private const string startMessageFormat = "[{0}]:Timer: {1} has started for {2} seconds";
        private const string finiishMessageFormat = "[{0}]:Timer: {1} has finished";

        static void Main(string[] args)
        {
            TimerEventArgs timerA = SetupTimer();
            TimerEventArgs timerB = SetupTimer();
            TimerEventArgs timerC = SetupTimer();

            ICountDownNotifier[] notifiers = GetNotifiers(timerA, timerB, timerC);

            foreach (ICountDownNotifier notifier in notifiers)
            {
                notifier.Init();
            }

            NotifyTicks<MethodProcessor>(notifiers);
            NotifyTicks<DelegateProcessor>(notifiers);
            NotifyTicks<LambdaProcessor>(notifiers);
        }

        private static void NotifyTicks<T>(ICountDownNotifier[] notifiers) where T: class
        {
            Array.Find(notifiers, p => (p as T) != null).Run();
            Type methodProcessor = typeof(T);
            Array.Find(notifiers, p => FindType(p, methodProcessor)).Unsubscribe();
        }

        private static bool FindType(ICountDownNotifier notifier , Type type)
        {
            Type a = notifier.GetType();

            return a.Equals(type);
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
            Console.WriteLine("Input timer name");
            string timerName = Console.ReadLine();

            int min = 0;
            int secondsAmount = InputInteger("input seconds amount for timer", "input positive integral number!", min);

            TimerEventArgs timer = new TimerEventArgs(timerName, secondsAmount);

            return timer;
        }

        private static void SayEnd(string taskName)
        {
            int realSeconds = DateTime.Now.Second;
            Console.WriteLine(finiishMessageFormat, realSeconds, taskName);
        }

        delegate void Starting(string name, int seconds);

        public static void SayStart(string taskName, int secondsAmount)
        {
            int realSeconds = DateTime.Now.Second;
            Console.WriteLine(startMessageFormat, realSeconds, taskName, secondsAmount);
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
