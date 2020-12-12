using System;
using System.Diagnostics;
using System.Linq;

namespace Reliability_Lab6
{
    public class Device
    {
        // Количество элементов в системе
        public const int AmountOfElementsInTheDevice = 5;
        // Число отказавших элементов, вызывающих отказ системы
        public const int AmountOfFailedElementsCausingDeviceFailure = 3;

        // Количество отказов
        private int _failureCount = 0;
        // Общее время восстановления
        private Stopwatch _totalRecoveryTime;
        // Элементы системы
        private readonly Element[] _elements;

        // Состояния элементов (работает или восстанавливается)
        public ElementState[] ElementStates
        {
            get
            {
                ElementState[] elementStates = new ElementState[AmountOfElementsInTheDevice];
                for (int i = 0; i < _elements.Length; i++)
                {
                    elementStates[i] = _elements[i].ElementState;
                }

                return elementStates;
            }
        }

        // Система работает?
        public bool IsTheDeviceWorking
        {
            get
            {
                return ElementStates.Count(state => state == ElementState.Works) >=
                    AmountOfFailedElementsCausingDeviceFailure;
            }
        }

        // Среднее время восстановления системы
        public TimeSpan AverageDeviceRecoveryTime
        {
            get
            {
                TimeSpan averageDeviceRecoveryTime = _failureCount == 0 ?
                    _totalRecoveryTime.Elapsed :
                    new TimeSpan(_totalRecoveryTime.ElapsedTicks / _failureCount);

                // Ускоряем процесс моделирования
                return TransformSeconds.ToHours(averageDeviceRecoveryTime);
            }
        }

        public Device()
        {
            _totalRecoveryTime = new Stopwatch();

            _elements = new Element[AmountOfElementsInTheDevice];
            for (int i = 0; i < _elements.Length; i++)
            {
                _elements[i] = new Element();
            }
        }

        public void UpdateProperties()
        {
            for (int i = 0; i < _elements.Length; i++)
            {
                _elements[i].UpdateProperties(i);
            }

            // Отказ системы
            if (!IsTheDeviceWorking)
            {
                // Увеличиваем счетчик отказа системы
                _failureCount++;
                // Возобновление секундомера
                _totalRecoveryTime.Start();
            }
            else
            {
                // Ставим на паузу секундомер
                _totalRecoveryTime.Stop();
            }
        }
    }
}
