using System;
using System.Windows.Forms;

namespace LZ_Umar
{
    public partial class Form1 : Form
    {
        private Button fillButton;
        private Button clearButton;
        private TextBox inputBox;

        public Form1()
        {
            InitializeComponent();
            fillButton = new Button();
            clearButton = new Button();
            inputBox = new TextBox();

            this.Text = "Лабораторная 1";
            this.Size = new System.Drawing.Size(800, 450);
            this.Load += new EventHandler(Form_Load);

            inputBox.Location = new System.Drawing.Point(50, 30);
            inputBox.Width = 200;

            fillButton.Text = "заполнить";
            fillButton.Location = new System.Drawing.Point(50, 70);
            fillButton.Click += new EventHandler(FillButton_Click);

            clearButton.Text = "очистить";
            clearButton.Location = new System.Drawing.Point(150, 70);
            clearButton.Click += new EventHandler(ClearButton_Click);

            this.Controls.Add(inputBox);
            this.Controls.Add(fillButton);
            this.Controls.Add(clearButton);
        }

        private void Form_Load(object sender, EventArgs e)
        {
            this.BackColor = System.Drawing.Color.LightBlue;
            inputBox.Text = "+++++";
        }

        private void FillButton_Click(object sender, EventArgs e)
        {
            inputBox.Text = "******";
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            inputBox.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f2 = new Form2();
            f2.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
