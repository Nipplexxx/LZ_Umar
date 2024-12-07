using System;
using System.Linq;
using System.Windows.Forms;

namespace LZ_Umar
{
    public partial class Form6 : Form
    {
        private TextBox inputTextBox;
        private Button processButton;
        private Button nextButton;
        private Label resultLabel;

        public Form6()
        {
            // Инициализация формы
            this.Text = "Вывод строчных русских букв";
            this.Size = new System.Drawing.Size(800, 450);

            // Поле ввода текста
            inputTextBox = new TextBox
            {
                Location = new System.Drawing.Point(20, 20),
                Width = 340
            };
            this.Controls.Add(inputTextBox);

            // Кнопка обработки
            processButton = new Button
            {
                Text = "Обработать",
                Location = new System.Drawing.Point(20, 60),
                Width = 100
            };
            processButton.Click += ProcessButton_Click;
            this.Controls.Add(processButton);

            // Метка для результата
            resultLabel = new Label
            {
                Text = "Результат:",
                Location = new System.Drawing.Point(20, 100),   
                AutoSize = true
            };
            this.Controls.Add(resultLabel);

            // Кнопка обработки
            nextButton = new Button
            {
                Text = "Инд. зад.",
                Location = new System.Drawing.Point(20, 140),
                Width = 100
            };
            nextButton.Click += nextButton_Click;
            this.Controls.Add(nextButton);
        }

        private void ProcessButton_Click(object sender, EventArgs e)
        {
            string input = inputTextBox.Text;

            // Фильтрация: только строчные русские буквы
            string result = new string(input.Where(c => c >= 'а' && c <= 'я').ToArray());

            // Вывод результата
            resultLabel.Text = "Результат: " + result;
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormInd find = new FormInd();
            find.ShowDialog();
        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }
    }
}
