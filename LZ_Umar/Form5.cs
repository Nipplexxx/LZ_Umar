using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LZ_Umar
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();

            this.Text = "Динамическое создание элементов";
            this.Size = new System.Drawing.Size(800, 450);

            // Подключение обработчика событий для кликов мыши
            this.MouseClick += MainForm_MouseClick;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form6 f6 = new Form6();
            f6.ShowDialog();
        }

        private void MainForm_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) // Левая кнопка мыши
            {
                // Создаем элемент: кнопка или метка
                var random = new Random();
                if (random.Next(2) == 0) // 50% вероятность
                {
                    Button button = new Button
                    {
                        Text = "Кнопка",
                        Location = e.Location,
                        Size = new System.Drawing.Size(100, 30)
                    };
                    this.Controls.Add(button);
                }
                else
                {
                    Label label = new Label
                    {
                        Text = "Метка",
                        Location = e.Location,
                        AutoSize = true
                    };
                    this.Controls.Add(label);
                }
            }
            else if (e.Button == MouseButtons.Right) // Правая кнопка мыши
            {
                // Удаление всех кнопок
                for (int i = this.Controls.Count - 1; i >= 0; i--)
                {
                    if (this.Controls[i] is Button)
                    {
                        this.Controls.RemoveAt(i);
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form6 f6 = new Form6();
            f6.ShowDialog();
        }
    }
}
