using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LZ_Umar
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            this.Text = "Лабораторная 4";
            this.Size = new System.Drawing.Size(800, 450);
            this.Load += new EventHandler(Form4_Load);
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        // Метод для вычисления значения y(x)
        private double CalculateY(double x, double b)
        {
            // Формула y = x * sin(sqrt(x + b - 0.0084))
            return x * Math.Sin(Math.Sqrt(x + b - 0.0084));
        }

        private void buttonCalculate_Click_1(object sender, EventArgs e)
        {
            // Очищаем старые результаты
            listBoxResults.Items.Clear();

            try
            {
                // Чтение входных данных
                double x0 = Convert.ToDouble(textBoxX0.Text);
                double xk = Convert.ToDouble(textBoxXk.Text);
                double dx = Convert.ToDouble(textBoxDx.Text);
                double b = Convert.ToDouble(textBoxB.Text);

                // Цикл для табулирования функции
                for (double x = x0; x >= xk; x += dx)
                {
                    double y = CalculateY(x, b);
                    // Добавляем результат в список
                    listBoxResults.Items.Add($"x = {x:F2}, y = {y:F4}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form5 f5 = new Form5();
            f5.ShowDialog();
        }
    }
}