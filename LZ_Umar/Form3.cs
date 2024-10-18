using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LZ_Umar
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            this.Text = "Лабораторная 3";
            this.Size = new System.Drawing.Size(800, 450);
            this.Load += new EventHandler(Form3_Load);
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        // Метод для вычисления значения f(x)
        private double ComputeFunction(double x)
        {
            if (radioButtonSinh.Checked)
            {
                return Math.Sinh(x); // sh(x)
            }
            else if (radioButtonX2.Checked)
            {
                return Math.Pow(x, 2); // x^2
            }
            else if (radioButtonExp.Checked)
            {
                return Math.Exp(x); // e^x
            }
            return 0;
        }

        // Метод для вычисления значения k
        private double ComputeK(double x, double q)
        {
            double f_x = ComputeFunction(x);
            double xq = Math.Abs(x * q);

            if (xq > 10)
            {
                return Math.Log(Math.Abs(f_x) + Math.Abs(q));
            }
            else if (xq < 10)
            {
                return Math.Exp(f_x + q);
            }
            else // xq == 10
            {
                return f_x + q;
            }
        }

        // Метод, который выполняется при нажатии кнопки "Вычислить"
        private void buttonCalculate_Click_1(object sender, EventArgs e)
        {
            try
            {
                // Чтение входных значений
                double x = Convert.ToDouble(textBoxX.Text);
                double q = Convert.ToDouble(textBoxQ.Text);

                // Вычисление k
                double k = ComputeK(x, q);

                // Отображение результата
                labelResult.Text = "Результат: k = " + k.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 f4 = new Form4();
            f4.ShowDialog();
        }
    }
}