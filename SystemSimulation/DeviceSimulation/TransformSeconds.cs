using System;

namespace Reliability_Lab6
{
    // Увеличиваем скорость моделирования: будем считать одну секунду за HourAmount часов
    public static class TransformSeconds
    {
        private const int AmountSecondsInHour = 3600;

        // 1 секунда равна этому количеству часов
        public static int HourAmount { get; set; }

        static TransformSeconds()
        {
            HourAmount = 1;
        }

        public static TimeSpan ToHours(TimeSpan timeSpan)
        {
            long ticks = timeSpan.Ticks * AmountSecondsInHour * HourAmount;
            return new TimeSpan(ticks);
        }
    }
}
