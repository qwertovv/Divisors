namespace WindowsFormsDeliteli
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.labelDivN = new System.Windows.Forms.Label();
            this.textBoxDivN = new System.Windows.Forms.TextBox();
            this.buttonFindAllDiv = new System.Windows.Forms.Button();
            this.buttonFactorize = new System.Windows.Forms.Button();
            this.buttonFind5Div = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxM = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxN = new System.Windows.Forms.TextBox();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(291, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Проект \"Делители\"";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(-1, 9);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(971, 601);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.textBoxResult);
            this.tabPage1.Controls.Add(this.textBoxN);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.textBoxM);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.buttonFind5Div);
            this.tabPage1.Controls.Add(this.buttonFactorize);
            this.tabPage1.Controls.Add(this.buttonFindAllDiv);
            this.tabPage1.Controls.Add(this.textBoxDivN);
            this.tabPage1.Controls.Add(this.labelDivN);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(963, 575);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Делители числа";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(963, 575);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // labelDivN
            // 
            this.labelDivN.AutoSize = true;
            this.labelDivN.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDivN.Location = new System.Drawing.Point(45, 62);
            this.labelDivN.Name = "labelDivN";
            this.labelDivN.Size = new System.Drawing.Size(157, 22);
            this.labelDivN.TabIndex = 0;
            this.labelDivN.Text = "Введите число N";
            // 
            // textBoxDivN
            // 
            this.textBoxDivN.Location = new System.Drawing.Point(292, 62);
            this.textBoxDivN.Name = "textBoxDivN";
            this.textBoxDivN.Size = new System.Drawing.Size(445, 20);
            this.textBoxDivN.TabIndex = 1;
            // 
            // buttonFindAllDiv
            // 
            this.buttonFindAllDiv.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonFindAllDiv.Location = new System.Drawing.Point(79, 209);
            this.buttonFindAllDiv.Name = "buttonFindAllDiv";
            this.buttonFindAllDiv.Size = new System.Drawing.Size(153, 94);
            this.buttonFindAllDiv.TabIndex = 2;
            this.buttonFindAllDiv.Text = "Найти все делители";
            this.buttonFindAllDiv.UseVisualStyleBackColor = true;
            this.buttonFindAllDiv.Click += new System.EventHandler(this.buttonFindAllDiv_Click);
            // 
            // buttonFactorize
            // 
            this.buttonFactorize.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonFactorize.Location = new System.Drawing.Point(334, 209);
            this.buttonFactorize.Name = "buttonFactorize";
            this.buttonFactorize.Size = new System.Drawing.Size(153, 94);
            this.buttonFactorize.TabIndex = 3;
            this.buttonFactorize.Text = "Факторизовать";
            this.buttonFactorize.UseVisualStyleBackColor = true;
            // 
            // buttonFind5Div
            // 
            this.buttonFind5Div.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonFind5Div.Location = new System.Drawing.Point(584, 209);
            this.buttonFind5Div.Name = "buttonFind5Div";
            this.buttonFind5Div.Size = new System.Drawing.Size(153, 94);
            this.buttonFind5Div.TabIndex = 4;
            this.buttonFind5Div.Text = "Найти все числа с пятью делителями";
            this.buttonFind5Div.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(45, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 22);
            this.label2.TabIndex = 5;
            this.label2.Text = "Результат";
            // 
            // textBoxM
            // 
            this.textBoxM.Location = new System.Drawing.Point(292, 94);
            this.textBoxM.Name = "textBoxM";
            this.textBoxM.Size = new System.Drawing.Size(445, 20);
            this.textBoxM.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(45, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(241, 22);
            this.label3.TabIndex = 7;
            this.label3.Text = "Введите верхнюю границу";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(45, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(238, 22);
            this.label4.TabIndex = 8;
            this.label4.Text = "Введите нижнюю границу";
            // 
            // textBoxN
            // 
            this.textBoxN.Location = new System.Drawing.Point(292, 131);
            this.textBoxN.Name = "textBoxN";
            this.textBoxN.Size = new System.Drawing.Size(445, 20);
            this.textBoxN.TabIndex = 9;
            // 
            // textBoxResult
            // 
            this.textBoxResult.Location = new System.Drawing.Point(292, 168);
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.Size = new System.Drawing.Size(445, 20);
            this.textBoxResult.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 481);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Делители";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label labelDivN;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button buttonFactorize;
        private System.Windows.Forms.Button buttonFindAllDiv;
        private System.Windows.Forms.TextBox textBoxDivN;
        private System.Windows.Forms.TextBox textBoxM;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonFind5Div;
        private System.Windows.Forms.TextBox textBoxN;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxResult;
    }
}

