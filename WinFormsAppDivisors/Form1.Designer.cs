namespace WinFormsAppDivisors
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            button1 = new Button();
            buttonFirstNEratosfen = new Button();
            buttonFirstN = new Button();
            buttonFind5Div = new Button();
            buttonFactorize = new Button();
            buttonFindAllDiv = new Button();
            textBoxResult = new TextBox();
            label5 = new Label();
            textBoxN = new TextBox();
            label4 = new Label();
            textBoxM = new TextBox();
            label3 = new Label();
            textBoxDivN = new TextBox();
            label2 = new Label();
            tabPage2 = new TabPage();
            button2 = new Button();
            buttonNOK = new Button();
            buttonNOD = new Button();
            textBoxResult1 = new TextBox();
            label8 = new Label();
            textBoxN1 = new TextBox();
            label7 = new Label();
            textBoxM1 = new TextBox();
            label6 = new Label();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(268, 9);
            label1.Name = "label1";
            label1.Size = new Size(228, 26);
            label1.TabIndex = 0;
            label1.Text = "Проект \"Делители\"";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(-3, 24);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(791, 480);
            tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.FromArgb(247, 224, 171);
            tabPage1.Controls.Add(button1);
            tabPage1.Controls.Add(buttonFirstNEratosfen);
            tabPage1.Controls.Add(buttonFirstN);
            tabPage1.Controls.Add(buttonFind5Div);
            tabPage1.Controls.Add(buttonFactorize);
            tabPage1.Controls.Add(buttonFindAllDiv);
            tabPage1.Controls.Add(textBoxResult);
            tabPage1.Controls.Add(label5);
            tabPage1.Controls.Add(textBoxN);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(textBoxM);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(textBoxDivN);
            tabPage1.Controls.Add(label2);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(783, 452);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Делители числа";
            // 
            // button1
            // 
            button1.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button1.Location = new Point(718, 397);
            button1.Name = "button1";
            button1.Size = new Size(48, 45);
            button1.TabIndex = 13;
            button1.Text = "?";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // buttonFirstNEratosfen
            // 
            buttonFirstNEratosfen.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonFirstNEratosfen.Location = new Point(432, 329);
            buttonFirstNEratosfen.Name = "buttonFirstNEratosfen";
            buttonFirstNEratosfen.Size = new Size(187, 107);
            buttonFirstNEratosfen.TabIndex = 12;
            buttonFirstNEratosfen.Text = "Список первых N простых чисел (Эратосфен)";
            buttonFirstNEratosfen.UseVisualStyleBackColor = true;
            buttonFirstNEratosfen.Click += buttonFirstNEratosfen_Click;
            // 
            // buttonFirstN
            // 
            buttonFirstN.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonFirstN.Location = new Point(166, 329);
            buttonFirstN.Name = "buttonFirstN";
            buttonFirstN.Size = new Size(187, 107);
            buttonFirstN.TabIndex = 11;
            buttonFirstN.Text = "Список первых N простых чисел";
            buttonFirstN.UseVisualStyleBackColor = true;
            buttonFirstN.Click += buttonFirstN_Click;
            // 
            // buttonFind5Div
            // 
            buttonFind5Div.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonFind5Div.Location = new Point(540, 216);
            buttonFind5Div.Name = "buttonFind5Div";
            buttonFind5Div.Size = new Size(187, 107);
            buttonFind5Div.TabIndex = 10;
            buttonFind5Div.Text = "Найти все числа с пятью делителями";
            buttonFind5Div.UseVisualStyleBackColor = true;
            buttonFind5Div.Click += buttonFind5Div_Click;
            // 
            // buttonFactorize
            // 
            buttonFactorize.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonFactorize.Location = new Point(304, 216);
            buttonFactorize.Name = "buttonFactorize";
            buttonFactorize.Size = new Size(187, 107);
            buttonFactorize.TabIndex = 9;
            buttonFactorize.Text = "Факторизовать";
            buttonFactorize.UseVisualStyleBackColor = true;
            buttonFactorize.Click += buttonFactorize_Click;
            // 
            // buttonFindAllDiv
            // 
            buttonFindAllDiv.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonFindAllDiv.Location = new Point(58, 216);
            buttonFindAllDiv.Name = "buttonFindAllDiv";
            buttonFindAllDiv.Size = new Size(187, 107);
            buttonFindAllDiv.TabIndex = 8;
            buttonFindAllDiv.Text = "Найти все делители";
            buttonFindAllDiv.UseVisualStyleBackColor = true;
            buttonFindAllDiv.Click += buttonFindAllDiv_Click;
            // 
            // textBoxResult
            // 
            textBoxResult.Location = new Point(325, 164);
            textBoxResult.Name = "textBoxResult";
            textBoxResult.Size = new Size(331, 23);
            textBoxResult.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label5.Location = new Point(73, 162);
            label5.Name = "label5";
            label5.Size = new Size(96, 22);
            label5.TabIndex = 6;
            label5.Text = "Результат";
            // 
            // textBoxN
            // 
            textBoxN.Location = new Point(325, 123);
            textBoxN.Name = "textBoxN";
            textBoxN.Size = new Size(331, 23);
            textBoxN.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label4.Location = new Point(73, 123);
            label4.Name = "label4";
            label4.Size = new Size(238, 22);
            label4.TabIndex = 4;
            label4.Text = "Введите нижнюю границу";
            // 
            // textBoxM
            // 
            textBoxM.Location = new Point(325, 82);
            textBoxM.Name = "textBoxM";
            textBoxM.Size = new Size(331, 23);
            textBoxM.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label3.Location = new Point(73, 80);
            label3.Name = "label3";
            label3.Size = new Size(241, 22);
            label3.TabIndex = 2;
            label3.Text = "Введите верхнюю границу";
            // 
            // textBoxDivN
            // 
            textBoxDivN.Location = new Point(325, 42);
            textBoxDivN.Name = "textBoxDivN";
            textBoxDivN.Size = new Size(331, 23);
            textBoxDivN.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label2.Location = new Point(73, 43);
            label2.Name = "label2";
            label2.Size = new Size(157, 22);
            label2.TabIndex = 0;
            label2.Text = "Введите число N";
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.FromArgb(247, 224, 171);
            tabPage2.Controls.Add(button2);
            tabPage2.Controls.Add(buttonNOK);
            tabPage2.Controls.Add(buttonNOD);
            tabPage2.Controls.Add(textBoxResult1);
            tabPage2.Controls.Add(label8);
            tabPage2.Controls.Add(textBoxN1);
            tabPage2.Controls.Add(label7);
            tabPage2.Controls.Add(textBoxM1);
            tabPage2.Controls.Add(label6);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(772, 448);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "НОД/НОК";
            // 
            // button2
            // 
            button2.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button2.Location = new Point(718, 397);
            button2.Name = "button2";
            button2.Size = new Size(48, 45);
            button2.TabIndex = 14;
            button2.Text = "?";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // buttonNOK
            // 
            buttonNOK.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonNOK.Location = new Point(417, 202);
            buttonNOK.Name = "buttonNOK";
            buttonNOK.Size = new Size(291, 111);
            buttonNOK.TabIndex = 11;
            buttonNOK.Text = "НОК";
            buttonNOK.UseVisualStyleBackColor = true;
            buttonNOK.Click += buttonNOK_Click;
            // 
            // buttonNOD
            // 
            buttonNOD.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonNOD.Location = new Point(72, 202);
            buttonNOD.Name = "buttonNOD";
            buttonNOD.Size = new Size(303, 111);
            buttonNOD.TabIndex = 10;
            buttonNOD.Text = "НОД";
            buttonNOD.UseVisualStyleBackColor = true;
            buttonNOD.Click += buttonNOD_Click;
            // 
            // textBoxResult1
            // 
            textBoxResult1.Location = new Point(341, 132);
            textBoxResult1.Name = "textBoxResult1";
            textBoxResult1.Size = new Size(331, 23);
            textBoxResult1.TabIndex = 9;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label8.Location = new Point(89, 130);
            label8.Name = "label8";
            label8.Size = new Size(96, 22);
            label8.TabIndex = 8;
            label8.Text = "Результат";
            // 
            // textBoxN1
            // 
            textBoxN1.Location = new Point(341, 81);
            textBoxN1.Name = "textBoxN1";
            textBoxN1.Size = new Size(331, 23);
            textBoxN1.TabIndex = 5;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label7.Location = new Point(89, 82);
            label7.Name = "label7";
            label7.Size = new Size(157, 22);
            label7.TabIndex = 4;
            label7.Text = "Введите число N";
            // 
            // textBoxM1
            // 
            textBoxM1.Location = new Point(341, 38);
            textBoxM1.Name = "textBoxM1";
            textBoxM1.Size = new Size(331, 23);
            textBoxM1.TabIndex = 3;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label6.Location = new Point(89, 39);
            label6.Name = "label6";
            label6.Size = new Size(161, 22);
            label6.TabIndex = 2;
            label6.Text = "Введите число M";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(247, 224, 171);
            ClientSize = new Size(787, 502);
            Controls.Add(label1);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Делители";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Label label2;
        private TextBox textBoxResult;
        private Label label5;
        private TextBox textBoxN;
        private Label label4;
        private TextBox textBoxM;
        private Label label3;
        private TextBox textBoxDivN;
        private Button buttonFindAllDiv;
        private Button buttonFind5Div;
        private Button buttonFactorize;
        private Button buttonFirstNEratosfen;
        private Button buttonFirstN;
        private Button buttonNOK;
        private Button buttonNOD;
        private TextBox textBoxResult1;
        private Label label8;
        private TextBox textBoxN1;
        private Label label7;
        private TextBox textBoxM1;
        private Label label6;
        private Button button1;
        private Button button2;
    }
}
