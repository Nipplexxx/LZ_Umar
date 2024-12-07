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
    public partial class FormInd : Form
    {
        private Label celsiusLabel;
        private TextBox celsiusTextBox;
        private Button convertButton;
        private Label resultLabel;

        public FormInd()
        {
            InitializeComponent();

            // Настройка формы
            this.Text = "Конвертер температуры";
            this.Size = new System.Drawing.Size(800, 450);

            // Метка для ввода температуры
            celsiusLabel = new Label
            {
                Text = "Введите температуру (°C):",
                Location = new System.Drawing.Point(20, 40),
                AutoSize = true
            };
            this.Controls.Add(celsiusLabel);

            // Поле для ввода температуры
            celsiusTextBox = new TextBox
            {
                Location = new System.Drawing.Point(20, 70),
                Width = 200
            };
            this.Controls.Add(celsiusTextBox);

            // Кнопка для выполнения преобразования
            convertButton = new Button
            {
                Text = "Конвертировать",
                Location = new System.Drawing.Point(20, 110),
                Width = 200
            };
            convertButton.Click += ConvertButton_Click;
            this.Controls.Add(convertButton);

            // Метка для отображения результата
            resultLabel = new Label
            {
                Text = "Результат: ",
                Location = new System.Drawing.Point(20, 150),
                AutoSize = true
            };
            this.Controls.Add(resultLabel);
        }

        private void ConvertButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Получение температуры в Цельсиях
                string input = celsiusTextBox.Text;
                if (double.TryParse(input, out double celsius))
                {
                    // Преобразование в Фаренгейты
                    double fahrenheit = celsius * 9 / 5 + 32;

                    // Отображение результата
                    resultLabel.Text = $"Результат: {fahrenheit:F2} °F";
                }
                else
                {
                    MessageBox.Show("Введите корректное числовое значение температуры!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла ошибка: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormInd_Load(object sender, EventArgs e)
        {

        }
    }
}
