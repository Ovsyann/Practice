using System;

namespace Lab1
{
    public class GenerationMethod
    {
        //Это класс для получения случайного числа и массива этих чисел

        public int sampleSize = 6000;
        public int numberOfSubdivisions = 16;
        private double[] _Rand;
        private int _R=6;
        public GenerationMethod()
        {
            _Rand = new double[_R];
        }

        //Получить случайное число
        private double NextRandom()
        {
            double s = 0.0D;
            for (int k = 0; k < _R; k++)
            {
                s += _Rand[k]; // сумма случайных чисел
            }
            for (int k = 1; k < _R; k++)
            {
                // сдвиг случайных чисел
                _Rand[k - 1] = _Rand[k];
            }
            s -= Math.Truncate(s);
            // новое случайное число
            _Rand[_R - 1] = s;
            return s;
        }

        //Получить массив случайных чисел
        public double[] GetRandomArray()
        {
            double[] randomArray = new double[sampleSize];
            // инициализация стандартного датчика
            Random random = new Random();

            for (int i = 0; i < _R; i++)
            {
                // генерация первых случайных чисел
                _Rand[i] = random.NextDouble();
            }

            for (int i = 0; i < sampleSize; i++)
            {
                randomArray[i] = NextRandom();
            }

            return randomArray;
        }
    }
}
