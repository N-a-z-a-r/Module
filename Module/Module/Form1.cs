using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Module
{
    // Клас форми
    public partial class Form1 : Form
    {
        // Поле для екземпляра класу Car
        private Car car;

        // Конструктор форми
        public Form1()
        {
            InitializeComponent();

            // Ініціалізація екземпляра класу Car при створенні форми
            car = new Car();
        }

        // Обробник події для кнопки "Запустити двигун"
        private void button1_Click(object sender, EventArgs e)
        {
            // Виклик методу StartEngine для запуску двигуна
            car.StartEngine();
            // Оновлення інтерфейсу стану двигуна
            UpdateEngineStatus();
        }

        // Обробник події для кнопки "Зупинити двигун"
        private void button2_Click(object sender, EventArgs e)
        {
            // Виклик методу StopEngine для зупинки двигуна
            car.StopEngine();
            // Оновлення інтерфейсу стану двигуна
            UpdateEngineStatus();
        }

        // Обробник події для кнопки "Почати рух"
        private void button3_Click(object sender, EventArgs e)
        {
            // Перевірка, чи двигун запущено
            if (car.IsEngineRunning)
            {
                // Виклик методу StartMoving для початку руху
                car.StartMoving();
                // Оновлення інтерфейсу стану руху
                UpdateMovementStatus();
            }
            else
            {
                // Виведення повідомлення, якщо двигун не запущено
                textBox5.Text = "Необхідно запустити двигун!";
            }
        }

        // Обробник події для кнопки "Зупинити рух"
        private void button4_Click(object sender, EventArgs e)
        {
            // Виклик методу StopMoving для зупинки руху
            car.StopMoving();
            // Оновлення інтерфейсу стану руху
            UpdateMovementStatus();
        }

        // Метод для оновлення інтерфейсу стану двигуна
        private void UpdateEngineStatus()
        {
            if (car.IsEngineRunning)
            {
                textBox1.Text = "Двигун працює";
                textBox2.Text = string.Empty;
            }
            else
            {
                textBox2.Text = "Двигун не працює";
                textBox1.Text = string.Empty;
            }
        }

        // Метод для оновлення інтерфейсу стану руху
        private void UpdateMovementStatus()
        {
            if (car.IsMoving)
            {
                textBox3.Text = "Автомобіль рухається";
                textBox4.Text = string.Empty;
            }
            else
            {
                textBox4.Text = "Автомобіль зупинився";
                textBox3.Text = string.Empty;
            }
        }
    }
}
