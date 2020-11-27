using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lib_9;

namespace Практическая_работа__1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

         // Рассчёт

        private void button1_Click(object sender, EventArgs e)
        {
            textBox3.Clear();
            int Rez,
                n;
            // Проверка конвертации
            if (Int32.TryParse(textBox1.Text, out n))
            {
                // Вызов функции из библиотеки
                Rez = Lib_9.Class.Summ(n, textBox3);
                // Вывод суммы
                textBox2.Text = Rez.ToString();
            }
            // При неудачной конвертации выводим подсказку и очищаем поле
            else
            {
                textBox1.Clear();
                MessageBox.Show("Ошибка конвертации!");
            }
        }

        // Сброс

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }

        // О программе

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Практическая работа № 1\n" +
                "С помощью библиотеки сформировать n целых чисел в диапазоне 2-14. Найти сумму чисел < 8. Результат вывести на экран. \n" +
                "Разработчик: Гусев Ярослав ИСП-31");
        }

        // Выход

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Изменение входного текстбокса

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox2.Clear();
            textBox3.Clear();
        }
    }
}
