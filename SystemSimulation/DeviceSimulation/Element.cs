using System;
using System.Diagnostics;

namespace Reliability_Lab6
{
    public class Element
    {
        // Интенсивность отказов (1 / час)
        public const double FailureRate = 0.04;
        // Интенсивность восстановления (1 / час)
        public const double RecoveryRate = 0.5;

        // ГСПЧ
        private static readonly Random _random;
        // Таймер пребывания элемента в рабочем состоянии
        private readonly Stopwatch _stopwatchWorkTime;
        // Таймер пребывания элемента в состоянии восстановления
        private readonly Stopwatch _stopwatchRecoveryTime;

        // Состояние элемента (работает или восстанавливается)
        public ElementState ElementState { get; private set; }
        // Время в рабочем состоянии
        public TimeSpan TimeInTheWorkState
        {
            get
            {
                // Ускоряем процесс моделирования
                return TransformSeconds.ToHours(_stopwatchWorkTime.Elapsed);
            }
        }
        // Время в состоянии восстановления
        public TimeSpan TimeInTheRecoveryState
        {
            get
            {
                // Ускоряем процесс моделирования
                return TransformSeconds.ToHours(_stopwatchRecoveryTime.Elapsed);
            }
        }

        static Element()
        {
            _random = new Random();
        }

        public Element()
        {
            _stopwatchRecoveryTime = new Stopwatch();
            _stopwatchWorkTime = new Stopwatch();

            ElementState = ElementState.Works;
            _stopwatchWorkTime.Start();
        }

        public void UpdateProperties(int seed)
        {
            double probability = _random.NextDouble();
            if (ElementState == ElementState.Works)
            {
                // Отказ элемента
                if (probability < ProbabilityOfFailure(TimeInTheWorkState))
                {
                    ElementState = ElementState.Recovers;
                    // Останавливаем и сбрасываем таймер времени работы элемента
                    _stopwatchWorkTime.Reset();
                    // Запускаем таймер времени восстановления элемента
                    _stopwatchRecoveryTime.Start();
                }
            }
            else
            {
                // Элемента восстановился
                if (probability < ProbabilityOfRecovery(TimeInTheRecoveryState))
                {
                    ElementState = ElementState.Works;
                    // Останавливаем и сбрасываем таймер времени восстановления элемента
                    _stopwatchRecoveryTime.Reset();
                    // Запускаем таймер времени работы элемента
                    _stopwatchWorkTime.Start();
                }
            }
        }

        // Вероятность отказа
        private double ProbabilityOfFailure(TimeSpan operatingTime)
        {
            return 1 - Math.Exp(-operatingTime.TotalHours * FailureRate);
        }

        // Вероятность восстановления
        private double ProbabilityOfRecovery(TimeSpan recoveryTime)
        {
            return 1 - Math.Exp(-recoveryTime.TotalHours * RecoveryRate);
        }
    }
}
