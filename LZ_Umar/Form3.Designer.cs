namespace LZ_Umar
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.radioButtonSinh = new System.Windows.Forms.RadioButton();
            this.radioButtonX2 = new System.Windows.Forms.RadioButton();
            this.radioButtonExp = new System.Windows.Forms.RadioButton();
            this.textBoxX = new System.Windows.Forms.TextBox();
            this.textBoxQ = new System.Windows.Forms.TextBox();
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.labelResult = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(780, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "10 вариант";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // radioButtonSinh
            // 
            this.radioButtonSinh.AutoSize = true;
            this.radioButtonSinh.Location = new System.Drawing.Point(12, 25);
            this.radioButtonSinh.Name = "radioButtonSinh";
            this.radioButtonSinh.Size = new System.Drawing.Size(50, 17);
            this.radioButtonSinh.TabIndex = 6;
            this.radioButtonSinh.TabStop = true;
            this.radioButtonSinh.Text = "sin(h)";
            this.radioButtonSinh.UseVisualStyleBackColor = true;
            // 
            // radioButtonX2
            // 
            this.radioButtonX2.AutoSize = true;
            this.radioButtonX2.Location = new System.Drawing.Point(12, 48);
            this.radioButtonX2.Name = "radioButtonX2";
            this.radioButtonX2.Size = new System.Drawing.Size(42, 17);
            this.radioButtonX2.TabIndex = 7;
            this.radioButtonX2.TabStop = true;
            this.radioButtonX2.Text = "x^2";
            this.radioButtonX2.UseVisualStyleBackColor = true;
            // 
            // radioButtonExp
            // 
            this.radioButtonExp.AutoSize = true;
            this.radioButtonExp.Location = new System.Drawing.Point(12, 71);
            this.radioButtonExp.Name = "radioButtonExp";
            this.radioButtonExp.Size = new System.Drawing.Size(42, 17);
            this.radioButtonExp.TabIndex = 8;
            this.radioButtonExp.TabStop = true;
            this.radioButtonExp.Text = "e^x";
            this.radioButtonExp.UseVisualStyleBackColor = true;
            // 
            // textBoxX
            // 
            this.textBoxX.Location = new System.Drawing.Point(68, 25);
            this.textBoxX.Name = "textBoxX";
            this.textBoxX.Size = new System.Drawing.Size(100, 20);
            this.textBoxX.TabIndex = 9;
            this.textBoxX.Text = "x";
            // 
            // textBoxQ
            // 
            this.textBoxQ.Location = new System.Drawing.Point(68, 48);
            this.textBoxQ.Name = "textBoxQ";
            this.textBoxQ.Size = new System.Drawing.Size(100, 20);
            this.textBoxQ.TabIndex = 10;
            this.textBoxQ.Text = "q";
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.Location = new System.Drawing.Point(28, 94);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(75, 23);
            this.buttonCalculate.TabIndex = 11;
            this.buttonCalculate.Text = "Вычислить";
            this.buttonCalculate.UseVisualStyleBackColor = true;
            this.buttonCalculate.Click += new System.EventHandler(this.buttonCalculate_Click_1);
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Location = new System.Drawing.Point(109, 99);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(59, 13);
            this.labelResult.TabIndex = 12;
            this.labelResult.Text = "Результат";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(697, 376);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "Л\\З 4";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(784, 411);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.buttonCalculate);
            this.Controls.Add(this.textBoxQ);
            this.Controls.Add(this.textBoxX);
            this.Controls.Add(this.radioButtonExp);
            this.Controls.Add(this.radioButtonX2);
            this.Controls.Add(this.radioButtonSinh);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.Text = "Лабораторная работа 3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButtonSinh;
        private System.Windows.Forms.RadioButton radioButtonX2;
        private System.Windows.Forms.RadioButton radioButtonExp;
        private System.Windows.Forms.TextBox textBoxX;
        private System.Windows.Forms.TextBox textBoxQ;
        private System.Windows.Forms.Button buttonCalculate;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.Button button1;
    }
}