using System;
using System.Windows.Forms;

namespace LZ_Umar
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

            this.Text = "Лабораторная 2";
            this.Size = new System.Drawing.Size(800, 450);
            this.Load += new EventHandler(Form2_Load);
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void calculateButton_Click_1(object sender, EventArgs e)
        {
            double x = double.Parse(xTextBox.Text); //0,03981
            double y = double.Parse(yTextBox.Text); //-1625
            double z = double.Parse(zTextBox.Text); //0,512

            // Вычисление значения a по формуле
            double a = Math.Pow(2, -x) * Math.Sqrt(x + Math.Pow(Math.Abs(y), 1.0 / 4)) *
                        Math.Pow(Math.Exp((x - 1) / Math.Sin(z)), 1.0 / 3);

            // Выводим результат в resultTextBox
            resultTextBox.Text = a.ToString("F5"); // Форматируем результат до 5 знаков после запятой
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 f3 = new Form3();
            f3.ShowDialog();
        }
    }
}
