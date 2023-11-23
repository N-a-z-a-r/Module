using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module
{
    // Клас "Автомобіль"
    public class Car
    {
        // Поле, яке вказує, чи працює двигун автомобіля
        private bool isEngineRunning;

        // Властивість, яка повертає стан роботи двигуна
        public bool IsEngineRunning
        {
            get { return isEngineRunning; }
            private set
            {
                // При зміні стану двигуна, також змінюємо стан руху автомобіля
                isEngineRunning = value;
                IsMoving = false; // Зупинити рух при зупинці двигуна
            }
        }

        // Властивість, яка вказує, чи рухається автомобіль
        public bool IsMoving { get; private set; }

        // Метод для запуску двигуна
        public void StartEngine()
        {
            IsEngineRunning = true;
        }

        // Метод для зупинки двигуна
        public void StopEngine()
        {
            IsEngineRunning = false;
            StopMoving(); // Зупинити рух при зупинці двигуна
        }

        // Метод для початку руху автомобіля
        public void StartMoving()
        {
            if (IsEngineRunning)
            {
                IsMoving = true;
            }
        }

        // Метод для зупинки руху автомобіля
        public void StopMoving()
        {
            IsMoving = false;
        }
    }

}

