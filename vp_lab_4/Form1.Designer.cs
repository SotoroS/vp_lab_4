namespace vp_lab_4
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
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonCreate = new System.Windows.Forms.Button();
            this.groupBoxTypeDate = new System.Windows.Forms.GroupBox();
            this.radioButtonFloat = new System.Windows.Forms.RadioButton();
            this.radioButtonInt = new System.Windows.Forms.RadioButton();
            this.radioButtonDecimal = new System.Windows.Forms.RadioButton();
            this.radioButtonDouble = new System.Windows.Forms.RadioButton();
            this.radioButtonChar = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBoxAddValue = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.textBoxValue = new System.Windows.Forms.TextBox();
            this.groupBoxGet = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxGetResult = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonGetElement = new System.Windows.Forms.Button();
            this.textBoxN = new System.Windows.Forms.TextBox();
            this.groupBoxCount = new System.Windows.Forms.GroupBox();
            this.buttonGetCount = new System.Windows.Forms.Button();
            this.textBoxCount = new System.Windows.Forms.TextBox();
            this.groupBoxTypeDate.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBoxAddValue.SuspendLayout();
            this.groupBoxGet.SuspendLayout();
            this.groupBoxCount.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonDelete
            // 
            this.buttonDelete.Enabled = false;
            this.buttonDelete.Location = new System.Drawing.Point(10, 48);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(105, 23);
            this.buttonDelete.TabIndex = 11;
            this.buttonDelete.Text = "Удалить";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonCreate
            // 
            this.buttonCreate.Location = new System.Drawing.Point(10, 19);
            this.buttonCreate.Name = "buttonCreate";
            this.buttonCreate.Size = new System.Drawing.Size(105, 23);
            this.buttonCreate.TabIndex = 10;
            this.buttonCreate.Text = "Создать";
            this.buttonCreate.UseVisualStyleBackColor = true;
            this.buttonCreate.Click += new System.EventHandler(this.buttonCreate_Click);
            // 
            // groupBoxTypeDate
            // 
            this.groupBoxTypeDate.Controls.Add(this.radioButtonFloat);
            this.groupBoxTypeDate.Controls.Add(this.radioButtonInt);
            this.groupBoxTypeDate.Controls.Add(this.radioButtonDecimal);
            this.groupBoxTypeDate.Controls.Add(this.radioButtonDouble);
            this.groupBoxTypeDate.Controls.Add(this.radioButtonChar);
            this.groupBoxTypeDate.Location = new System.Drawing.Point(12, 95);
            this.groupBoxTypeDate.Name = "groupBoxTypeDate";
            this.groupBoxTypeDate.Size = new System.Drawing.Size(124, 142);
            this.groupBoxTypeDate.TabIndex = 9;
            this.groupBoxTypeDate.TabStop = false;
            this.groupBoxTypeDate.Text = "Тип данных";
            // 
            // radioButtonFloat
            // 
            this.radioButtonFloat.AutoSize = true;
            this.radioButtonFloat.Location = new System.Drawing.Point(11, 40);
            this.radioButtonFloat.Name = "radioButtonFloat";
            this.radioButtonFloat.Size = new System.Drawing.Size(91, 17);
            this.radioButtonFloat.TabIndex = 9;
            this.radioButtonFloat.TabStop = true;
            this.radioButtonFloat.Text = "System.Single";
            this.radioButtonFloat.UseVisualStyleBackColor = true;
            // 
            // radioButtonInt
            // 
            this.radioButtonInt.AutoSize = true;
            this.radioButtonInt.Location = new System.Drawing.Point(10, 17);
            this.radioButtonInt.Name = "radioButtonInt";
            this.radioButtonInt.Size = new System.Drawing.Size(86, 17);
            this.radioButtonInt.TabIndex = 5;
            this.radioButtonInt.TabStop = true;
            this.radioButtonInt.Text = "System.Int32";
            this.radioButtonInt.UseVisualStyleBackColor = true;
            // 
            // radioButtonDecimal
            // 
            this.radioButtonDecimal.AutoSize = true;
            this.radioButtonDecimal.Location = new System.Drawing.Point(10, 86);
            this.radioButtonDecimal.Name = "radioButtonDecimal";
            this.radioButtonDecimal.Size = new System.Drawing.Size(100, 17);
            this.radioButtonDecimal.TabIndex = 8;
            this.radioButtonDecimal.TabStop = true;
            this.radioButtonDecimal.Text = "System.Decimal";
            this.radioButtonDecimal.UseVisualStyleBackColor = true;
            // 
            // radioButtonDouble
            // 
            this.radioButtonDouble.AutoSize = true;
            this.radioButtonDouble.Location = new System.Drawing.Point(11, 63);
            this.radioButtonDouble.Name = "radioButtonDouble";
            this.radioButtonDouble.Size = new System.Drawing.Size(96, 17);
            this.radioButtonDouble.TabIndex = 6;
            this.radioButtonDouble.TabStop = true;
            this.radioButtonDouble.Text = "System.Double";
            this.radioButtonDouble.UseVisualStyleBackColor = true;
            // 
            // radioButtonChar
            // 
            this.radioButtonChar.AutoSize = true;
            this.radioButtonChar.Location = new System.Drawing.Point(11, 109);
            this.radioButtonChar.Name = "radioButtonChar";
            this.radioButtonChar.Size = new System.Drawing.Size(84, 17);
            this.radioButtonChar.TabIndex = 7;
            this.radioButtonChar.TabStop = true;
            this.radioButtonChar.Text = "System.Char";
            this.radioButtonChar.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonCreate);
            this.groupBox2.Controls.Add(this.buttonDelete);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(124, 82);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Настройка списка";
            // 
            // groupBoxAddValue
            // 
            this.groupBoxAddValue.Controls.Add(this.label2);
            this.groupBoxAddValue.Controls.Add(this.buttonAdd);
            this.groupBoxAddValue.Controls.Add(this.textBoxValue);
            this.groupBoxAddValue.Enabled = false;
            this.groupBoxAddValue.Location = new System.Drawing.Point(142, 12);
            this.groupBoxAddValue.Name = "groupBoxAddValue";
            this.groupBoxAddValue.Size = new System.Drawing.Size(200, 82);
            this.groupBoxAddValue.TabIndex = 12;
            this.groupBoxAddValue.TabStop = false;
            this.groupBoxAddValue.Text = "Добавление элемента";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Значение";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(11, 48);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(180, 23);
            this.buttonAdd.TabIndex = 10;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // textBoxValue
            // 
            this.textBoxValue.Location = new System.Drawing.Point(69, 22);
            this.textBoxValue.Name = "textBoxValue";
            this.textBoxValue.Size = new System.Drawing.Size(122, 20);
            this.textBoxValue.TabIndex = 0;
            // 
            // groupBoxGet
            // 
            this.groupBoxGet.Controls.Add(this.label4);
            this.groupBoxGet.Controls.Add(this.textBoxGetResult);
            this.groupBoxGet.Controls.Add(this.label3);
            this.groupBoxGet.Controls.Add(this.buttonGetElement);
            this.groupBoxGet.Controls.Add(this.textBoxN);
            this.groupBoxGet.Enabled = false;
            this.groupBoxGet.Location = new System.Drawing.Point(142, 95);
            this.groupBoxGet.Name = "groupBoxGet";
            this.groupBoxGet.Size = new System.Drawing.Size(200, 81);
            this.groupBoxGet.TabIndex = 13;
            this.groupBoxGet.TabStop = false;
            this.groupBoxGet.Text = "Получение n-ого элемента";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Результат:";
            // 
            // textBoxGetResult
            // 
            this.textBoxGetResult.Location = new System.Drawing.Point(70, 51);
            this.textBoxGetResult.Name = "textBoxGetResult";
            this.textBoxGetResult.ReadOnly = true;
            this.textBoxGetResult.Size = new System.Drawing.Size(122, 20);
            this.textBoxGetResult.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "n:";
            // 
            // buttonGetElement
            // 
            this.buttonGetElement.Location = new System.Drawing.Point(100, 20);
            this.buttonGetElement.Name = "buttonGetElement";
            this.buttonGetElement.Size = new System.Drawing.Size(94, 23);
            this.buttonGetElement.TabIndex = 13;
            this.buttonGetElement.Text = "Найти";
            this.buttonGetElement.UseVisualStyleBackColor = true;
            this.buttonGetElement.Click += new System.EventHandler(this.buttonGetElement_Click);
            // 
            // textBoxN
            // 
            this.textBoxN.Location = new System.Drawing.Point(30, 22);
            this.textBoxN.Name = "textBoxN";
            this.textBoxN.Size = new System.Drawing.Size(66, 20);
            this.textBoxN.TabIndex = 12;
            // 
            // groupBoxCount
            // 
            this.groupBoxCount.Controls.Add(this.buttonGetCount);
            this.groupBoxCount.Controls.Add(this.textBoxCount);
            this.groupBoxCount.Enabled = false;
            this.groupBoxCount.Location = new System.Drawing.Point(142, 183);
            this.groupBoxCount.Name = "groupBoxCount";
            this.groupBoxCount.Size = new System.Drawing.Size(200, 54);
            this.groupBoxCount.TabIndex = 17;
            this.groupBoxCount.TabStop = false;
            this.groupBoxCount.Text = "Количество элементов в списке";
            // 
            // buttonGetCount
            // 
            this.buttonGetCount.Location = new System.Drawing.Point(100, 20);
            this.buttonGetCount.Name = "buttonGetCount";
            this.buttonGetCount.Size = new System.Drawing.Size(94, 23);
            this.buttonGetCount.TabIndex = 13;
            this.buttonGetCount.Text = "Обновить";
            this.buttonGetCount.UseVisualStyleBackColor = true;
            this.buttonGetCount.Click += new System.EventHandler(this.buttonGetCount_Click);
            // 
            // textBoxCount
            // 
            this.textBoxCount.Location = new System.Drawing.Point(11, 22);
            this.textBoxCount.Name = "textBoxCount";
            this.textBoxCount.ReadOnly = true;
            this.textBoxCount.Size = new System.Drawing.Size(83, 20);
            this.textBoxCount.TabIndex = 12;
            this.textBoxCount.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(353, 247);
            this.Controls.Add(this.groupBoxCount);
            this.Controls.Add(this.groupBoxGet);
            this.Controls.Add(this.groupBoxAddValue);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBoxTypeDate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.Text = "GenericsSet ";
            this.groupBoxTypeDate.ResumeLayout(false);
            this.groupBoxTypeDate.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBoxAddValue.ResumeLayout(false);
            this.groupBoxAddValue.PerformLayout();
            this.groupBoxGet.ResumeLayout(false);
            this.groupBoxGet.PerformLayout();
            this.groupBoxCount.ResumeLayout(false);
            this.groupBoxCount.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonCreate;
        private System.Windows.Forms.GroupBox groupBoxTypeDate;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBoxAddValue;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.GroupBox groupBoxGet;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxValue;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxGetResult;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonGetElement;
        private System.Windows.Forms.TextBox textBoxN;
        private System.Windows.Forms.GroupBox groupBoxCount;
        private System.Windows.Forms.Button buttonGetCount;
        private System.Windows.Forms.TextBox textBoxCount;
        private System.Windows.Forms.RadioButton radioButtonFloat;
        private System.Windows.Forms.RadioButton radioButtonInt;
        private System.Windows.Forms.RadioButton radioButtonDecimal;
        private System.Windows.Forms.RadioButton radioButtonDouble;
        private System.Windows.Forms.RadioButton radioButtonChar;
    }
}

