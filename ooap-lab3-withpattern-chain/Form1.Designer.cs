namespace ooap_lab3_withpattern_chain
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.inputNumberBox = new System.Windows.Forms.TextBox();
            this.ErrorLabel = new System.Windows.Forms.Label();
            this.oneNumberButton = new System.Windows.Forms.Button();
            this.twoNumberButton = new System.Windows.Forms.Button();
            this.threeNumberButton = new System.Windows.Forms.Button();
            this.fourNumberButton = new System.Windows.Forms.Button();
            this.fiveNumberButton = new System.Windows.Forms.Button();
            this.SixNumberButton = new System.Windows.Forms.Button();
            this.SevenNumberButton = new System.Windows.Forms.Button();
            this.EightNumberButton = new System.Windows.Forms.Button();
            this.NineNumberButton = new System.Windows.Forms.Button();
            this.ZeroNumberButton = new System.Windows.Forms.Button();
            this.getBacknoteBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.backNumberButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.SumErrorLabel = new System.Windows.Forms.Label();
            this.ClearButton = new System.Windows.Forms.Button();
            this.ErrorZeroLabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.plusFiveThousand = new System.Windows.Forms.Button();
            this.minusFiveThousand = new System.Windows.Forms.Button();
            this.minusOneThousand = new System.Windows.Forms.Button();
            this.plusOneThousand = new System.Windows.Forms.Button();
            this.minusFiveHundred = new System.Windows.Forms.Button();
            this.plusFiveHundred = new System.Windows.Forms.Button();
            this.minusOneHundred = new System.Windows.Forms.Button();
            this.plusOneHundred = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.minSumTextBox = new System.Windows.Forms.TextBox();
            this.maxSumTextBox = new System.Windows.Forms.TextBox();
            this.GapNumber = new System.Windows.Forms.Label();
            this.NullLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.pictureBox1.Location = new System.Drawing.Point(61, 33);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(700, 594);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(160, 102);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(496, 270);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.label1.Location = new System.Drawing.Point(191, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(439, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "Введите пятизначную сумму кратную 100";
            // 
            // inputNumberBox
            // 
            this.inputNumberBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F);
            this.inputNumberBox.Location = new System.Drawing.Point(274, 179);
            this.inputNumberBox.MaxLength = 5;
            this.inputNumberBox.Multiline = true;
            this.inputNumberBox.Name = "inputNumberBox";
            this.inputNumberBox.ReadOnly = true;
            this.inputNumberBox.Size = new System.Drawing.Size(274, 118);
            this.inputNumberBox.TabIndex = 3;
            this.inputNumberBox.TextChanged += new System.EventHandler(this.inputNumberBox_TextChanged);
            this.inputNumberBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.inputNumberBox_KeyPress);
            // 
            // ErrorLabel
            // 
            this.ErrorLabel.AutoSize = true;
            this.ErrorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.ErrorLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ErrorLabel.Location = new System.Drawing.Point(289, 323);
            this.ErrorLabel.Name = "ErrorLabel";
            this.ErrorLabel.Size = new System.Drawing.Size(247, 20);
            this.ErrorLabel.TabIndex = 4;
            this.ErrorLabel.Text = "Больше пяти знаков нельзя";
            this.ErrorLabel.Visible = false;
            // 
            // oneNumberButton
            // 
            this.oneNumberButton.Location = new System.Drawing.Point(196, 403);
            this.oneNumberButton.Name = "oneNumberButton";
            this.oneNumberButton.Size = new System.Drawing.Size(46, 41);
            this.oneNumberButton.TabIndex = 5;
            this.oneNumberButton.Text = "1";
            this.oneNumberButton.UseVisualStyleBackColor = true;
            this.oneNumberButton.Click += new System.EventHandler(this.oneNumberButton_Click);
            // 
            // twoNumberButton
            // 
            this.twoNumberButton.Location = new System.Drawing.Point(262, 403);
            this.twoNumberButton.Name = "twoNumberButton";
            this.twoNumberButton.Size = new System.Drawing.Size(46, 41);
            this.twoNumberButton.TabIndex = 6;
            this.twoNumberButton.Text = "2";
            this.twoNumberButton.UseVisualStyleBackColor = true;
            this.twoNumberButton.Click += new System.EventHandler(this.twoNumberButton_Click);
            // 
            // threeNumberButton
            // 
            this.threeNumberButton.Location = new System.Drawing.Point(325, 403);
            this.threeNumberButton.Name = "threeNumberButton";
            this.threeNumberButton.Size = new System.Drawing.Size(46, 41);
            this.threeNumberButton.TabIndex = 7;
            this.threeNumberButton.Text = "3";
            this.threeNumberButton.UseVisualStyleBackColor = true;
            this.threeNumberButton.Click += new System.EventHandler(this.threeNumberButton_Click);
            // 
            // fourNumberButton
            // 
            this.fourNumberButton.Location = new System.Drawing.Point(196, 459);
            this.fourNumberButton.Name = "fourNumberButton";
            this.fourNumberButton.Size = new System.Drawing.Size(46, 41);
            this.fourNumberButton.TabIndex = 8;
            this.fourNumberButton.Text = "4";
            this.fourNumberButton.UseVisualStyleBackColor = true;
            this.fourNumberButton.Click += new System.EventHandler(this.fourNumberButton_Click);
            // 
            // fiveNumberButton
            // 
            this.fiveNumberButton.Location = new System.Drawing.Point(262, 459);
            this.fiveNumberButton.Name = "fiveNumberButton";
            this.fiveNumberButton.Size = new System.Drawing.Size(46, 41);
            this.fiveNumberButton.TabIndex = 9;
            this.fiveNumberButton.Text = "5";
            this.fiveNumberButton.UseVisualStyleBackColor = true;
            this.fiveNumberButton.Click += new System.EventHandler(this.fiveNumberButton_Click);
            // 
            // SixNumberButton
            // 
            this.SixNumberButton.Location = new System.Drawing.Point(325, 459);
            this.SixNumberButton.Name = "SixNumberButton";
            this.SixNumberButton.Size = new System.Drawing.Size(46, 41);
            this.SixNumberButton.TabIndex = 10;
            this.SixNumberButton.Text = "6";
            this.SixNumberButton.UseVisualStyleBackColor = true;
            this.SixNumberButton.Click += new System.EventHandler(this.SixNumberButton_Click);
            // 
            // SevenNumberButton
            // 
            this.SevenNumberButton.Location = new System.Drawing.Point(196, 515);
            this.SevenNumberButton.Name = "SevenNumberButton";
            this.SevenNumberButton.Size = new System.Drawing.Size(46, 41);
            this.SevenNumberButton.TabIndex = 11;
            this.SevenNumberButton.Text = "7";
            this.SevenNumberButton.UseVisualStyleBackColor = true;
            this.SevenNumberButton.Click += new System.EventHandler(this.SevenNumberButton_Click);
            // 
            // EightNumberButton
            // 
            this.EightNumberButton.Location = new System.Drawing.Point(262, 515);
            this.EightNumberButton.Name = "EightNumberButton";
            this.EightNumberButton.Size = new System.Drawing.Size(46, 41);
            this.EightNumberButton.TabIndex = 12;
            this.EightNumberButton.Text = "8";
            this.EightNumberButton.UseVisualStyleBackColor = true;
            this.EightNumberButton.Click += new System.EventHandler(this.EightNumberButton_Click);
            // 
            // NineNumberButton
            // 
            this.NineNumberButton.Location = new System.Drawing.Point(325, 515);
            this.NineNumberButton.Name = "NineNumberButton";
            this.NineNumberButton.Size = new System.Drawing.Size(46, 41);
            this.NineNumberButton.TabIndex = 13;
            this.NineNumberButton.Text = "9";
            this.NineNumberButton.UseVisualStyleBackColor = true;
            this.NineNumberButton.Click += new System.EventHandler(this.NineNumberButton_Click);
            // 
            // ZeroNumberButton
            // 
            this.ZeroNumberButton.Location = new System.Drawing.Point(196, 571);
            this.ZeroNumberButton.Name = "ZeroNumberButton";
            this.ZeroNumberButton.Size = new System.Drawing.Size(46, 41);
            this.ZeroNumberButton.TabIndex = 14;
            this.ZeroNumberButton.Text = "0";
            this.ZeroNumberButton.UseVisualStyleBackColor = true;
            this.ZeroNumberButton.Click += new System.EventHandler(this.ZeroNumberButton_Click);
            // 
            // getBacknoteBox
            // 
            this.getBacknoteBox.Location = new System.Drawing.Point(465, 413);
            this.getBacknoteBox.Multiline = true;
            this.getBacknoteBox.Name = "getBacknoteBox";
            this.getBacknoteBox.ReadOnly = true;
            this.getBacknoteBox.Size = new System.Drawing.Size(278, 199);
            this.getBacknoteBox.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label3.Location = new System.Drawing.Point(461, 387);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(260, 17);
            this.label3.TabIndex = 16;
            this.label3.Text = "Пользователь получает купюры вида:";
            // 
            // backNumberButton
            // 
            this.backNumberButton.Location = new System.Drawing.Point(262, 571);
            this.backNumberButton.Name = "backNumberButton";
            this.backNumberButton.Size = new System.Drawing.Size(46, 41);
            this.backNumberButton.TabIndex = 17;
            this.backNumberButton.Text = "←";
            this.backNumberButton.UseVisualStyleBackColor = true;
            this.backNumberButton.Click += new System.EventHandler(this.backNumberButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.25F);
            this.label2.Location = new System.Drawing.Point(287, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(242, 36);
            this.label2.TabIndex = 18;
            this.label2.Text = "@Какой-тоБанк";
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(325, 571);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(46, 41);
            this.startButton.TabIndex = 19;
            this.startButton.Text = "Снять";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // SumErrorLabel
            // 
            this.SumErrorLabel.AutoSize = true;
            this.SumErrorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.SumErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.SumErrorLabel.Location = new System.Drawing.Point(290, 323);
            this.SumErrorLabel.Name = "SumErrorLabel";
            this.SumErrorLabel.Size = new System.Drawing.Size(246, 20);
            this.SumErrorLabel.TabIndex = 20;
            this.SumErrorLabel.Text = "Введите сумму кратную ста";
            this.SumErrorLabel.Visible = false;
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(388, 571);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(46, 41);
            this.ClearButton.TabIndex = 21;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // ErrorZeroLabel
            // 
            this.ErrorZeroLabel.AutoSize = true;
            this.ErrorZeroLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.ErrorZeroLabel.ForeColor = System.Drawing.Color.Red;
            this.ErrorZeroLabel.Location = new System.Drawing.Point(245, 323);
            this.ErrorZeroLabel.Name = "ErrorZeroLabel";
            this.ErrorZeroLabel.Size = new System.Drawing.Size(336, 20);
            this.ErrorZeroLabel.TabIndex = 22;
            this.ErrorZeroLabel.Text = "Значение не может начинаться с нуля";
            this.ErrorZeroLabel.Visible = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(789, 88);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(33, 20);
            this.textBox1.TabIndex = 23;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(789, 114);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(33, 20);
            this.textBox2.TabIndex = 24;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(789, 140);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(33, 20);
            this.textBox3.TabIndex = 25;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(789, 166);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(33, 20);
            this.textBox4.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.label4.Location = new System.Drawing.Point(784, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(175, 26);
            this.label4.TabIndex = 27;
            this.label4.Text = "Деньги в банке:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(828, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 28;
            this.label5.Text = "5000";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(828, 117);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 29;
            this.label6.Text = "1000";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(828, 143);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(25, 13);
            this.label7.TabIndex = 30;
            this.label7.Text = "500";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(828, 169);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(25, 13);
            this.label8.TabIndex = 31;
            this.label8.Text = "100";
            // 
            // plusFiveThousand
            // 
            this.plusFiveThousand.Location = new System.Drawing.Point(865, 88);
            this.plusFiveThousand.Name = "plusFiveThousand";
            this.plusFiveThousand.Size = new System.Drawing.Size(24, 20);
            this.plusFiveThousand.TabIndex = 32;
            this.plusFiveThousand.Text = "+";
            this.plusFiveThousand.UseVisualStyleBackColor = true;
            this.plusFiveThousand.Click += new System.EventHandler(this.plusFiveThousand_Click);
            // 
            // minusFiveThousand
            // 
            this.minusFiveThousand.Location = new System.Drawing.Point(895, 88);
            this.minusFiveThousand.Name = "minusFiveThousand";
            this.minusFiveThousand.Size = new System.Drawing.Size(24, 20);
            this.minusFiveThousand.TabIndex = 33;
            this.minusFiveThousand.Text = "-";
            this.minusFiveThousand.UseVisualStyleBackColor = true;
            this.minusFiveThousand.Click += new System.EventHandler(this.minusFiveThousand_Click);
            // 
            // minusOneThousand
            // 
            this.minusOneThousand.Location = new System.Drawing.Point(895, 114);
            this.minusOneThousand.Name = "minusOneThousand";
            this.minusOneThousand.Size = new System.Drawing.Size(24, 20);
            this.minusOneThousand.TabIndex = 35;
            this.minusOneThousand.Text = "-";
            this.minusOneThousand.UseVisualStyleBackColor = true;
            this.minusOneThousand.Click += new System.EventHandler(this.minusOneThousand_Click);
            // 
            // plusOneThousand
            // 
            this.plusOneThousand.Location = new System.Drawing.Point(865, 114);
            this.plusOneThousand.Name = "plusOneThousand";
            this.plusOneThousand.Size = new System.Drawing.Size(24, 20);
            this.plusOneThousand.TabIndex = 34;
            this.plusOneThousand.Text = "+";
            this.plusOneThousand.UseVisualStyleBackColor = true;
            this.plusOneThousand.Click += new System.EventHandler(this.plusOneThousand_Click);
            // 
            // minusFiveHundred
            // 
            this.minusFiveHundred.Location = new System.Drawing.Point(895, 140);
            this.minusFiveHundred.Name = "minusFiveHundred";
            this.minusFiveHundred.Size = new System.Drawing.Size(24, 20);
            this.minusFiveHundred.TabIndex = 37;
            this.minusFiveHundred.Text = "-";
            this.minusFiveHundred.UseVisualStyleBackColor = true;
            this.minusFiveHundred.Click += new System.EventHandler(this.minusFiveHundred_Click);
            // 
            // plusFiveHundred
            // 
            this.plusFiveHundred.Location = new System.Drawing.Point(865, 140);
            this.plusFiveHundred.Name = "plusFiveHundred";
            this.plusFiveHundred.Size = new System.Drawing.Size(24, 20);
            this.plusFiveHundred.TabIndex = 36;
            this.plusFiveHundred.Text = "+";
            this.plusFiveHundred.UseVisualStyleBackColor = true;
            this.plusFiveHundred.Click += new System.EventHandler(this.plusFiveHundred_Click);
            // 
            // minusOneHundred
            // 
            this.minusOneHundred.Location = new System.Drawing.Point(895, 166);
            this.minusOneHundred.Name = "minusOneHundred";
            this.minusOneHundred.Size = new System.Drawing.Size(24, 20);
            this.minusOneHundred.TabIndex = 39;
            this.minusOneHundred.Text = "-";
            this.minusOneHundred.UseVisualStyleBackColor = true;
            this.minusOneHundred.Click += new System.EventHandler(this.minusOneHundred_Click);
            // 
            // plusOneHundred
            // 
            this.plusOneHundred.Location = new System.Drawing.Point(865, 166);
            this.plusOneHundred.Name = "plusOneHundred";
            this.plusOneHundred.Size = new System.Drawing.Size(24, 20);
            this.plusOneHundred.TabIndex = 38;
            this.plusOneHundred.Text = "+";
            this.plusOneHundred.UseVisualStyleBackColor = true;
            this.plusOneHundred.Click += new System.EventHandler(this.plusOneHundred_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.label9.Location = new System.Drawing.Point(191, 140);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(110, 26);
            this.label9.TabIndex = 40;
            this.label9.Text = "Не менее";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.label10.Location = new System.Drawing.Point(397, 140);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(122, 26);
            this.label10.TabIndex = 41;
            this.label10.Text = "и не более";
            // 
            // minSumTextBox
            // 
            this.minSumTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.minSumTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.minSumTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.minSumTextBox.Location = new System.Drawing.Point(307, 140);
            this.minSumTextBox.Multiline = true;
            this.minSumTextBox.Name = "minSumTextBox";
            this.minSumTextBox.Size = new System.Drawing.Size(84, 30);
            this.minSumTextBox.TabIndex = 42;
            // 
            // maxSumTextBox
            // 
            this.maxSumTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.maxSumTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.maxSumTextBox.Location = new System.Drawing.Point(525, 140);
            this.maxSumTextBox.Multiline = true;
            this.maxSumTextBox.Name = "maxSumTextBox";
            this.maxSumTextBox.ReadOnly = true;
            this.maxSumTextBox.Size = new System.Drawing.Size(95, 30);
            this.maxSumTextBox.TabIndex = 43;
            // 
            // GapNumber
            // 
            this.GapNumber.AutoSize = true;
            this.GapNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.GapNumber.ForeColor = System.Drawing.Color.Red;
            this.GapNumber.Location = new System.Drawing.Point(183, 323);
            this.GapNumber.Name = "GapNumber";
            this.GapNumber.Size = new System.Drawing.Size(447, 20);
            this.GapNumber.TabIndex = 44;
            this.GapNumber.Text = "Ваше сумма не попадает в установленные границы";
            this.GapNumber.Visible = false;
            // 
            // NullLabel
            // 
            this.NullLabel.AutoSize = true;
            this.NullLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.NullLabel.ForeColor = System.Drawing.Color.Red;
            this.NullLabel.Location = new System.Drawing.Point(289, 323);
            this.NullLabel.Name = "NullLabel";
            this.NullLabel.Size = new System.Drawing.Size(256, 20);
            this.NullLabel.TabIndex = 45;
            this.NullLabel.Text = "Сумма не может быть пустой";
            this.NullLabel.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 657);
            this.Controls.Add(this.NullLabel);
            this.Controls.Add(this.GapNumber);
            this.Controls.Add(this.maxSumTextBox);
            this.Controls.Add(this.minSumTextBox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.minusOneHundred);
            this.Controls.Add(this.plusOneHundred);
            this.Controls.Add(this.minusFiveHundred);
            this.Controls.Add(this.plusFiveHundred);
            this.Controls.Add(this.minusOneThousand);
            this.Controls.Add(this.plusOneThousand);
            this.Controls.Add(this.minusFiveThousand);
            this.Controls.Add(this.plusFiveThousand);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.ErrorZeroLabel);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.SumErrorLabel);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.backNumberButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.getBacknoteBox);
            this.Controls.Add(this.ZeroNumberButton);
            this.Controls.Add(this.NineNumberButton);
            this.Controls.Add(this.EightNumberButton);
            this.Controls.Add(this.SevenNumberButton);
            this.Controls.Add(this.SixNumberButton);
            this.Controls.Add(this.fiveNumberButton);
            this.Controls.Add(this.fourNumberButton);
            this.Controls.Add(this.threeNumberButton);
            this.Controls.Add(this.twoNumberButton);
            this.Controls.Add(this.oneNumberButton);
            this.Controls.Add(this.ErrorLabel);
            this.Controls.Add(this.inputNumberBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox inputNumberBox;
        private System.Windows.Forms.Label ErrorLabel;
        private System.Windows.Forms.Button oneNumberButton;
        private System.Windows.Forms.Button twoNumberButton;
        private System.Windows.Forms.Button threeNumberButton;
        private System.Windows.Forms.Button fourNumberButton;
        private System.Windows.Forms.Button fiveNumberButton;
        private System.Windows.Forms.Button SixNumberButton;
        private System.Windows.Forms.Button SevenNumberButton;
        private System.Windows.Forms.Button EightNumberButton;
        private System.Windows.Forms.Button NineNumberButton;
        private System.Windows.Forms.Button ZeroNumberButton;
        private System.Windows.Forms.TextBox getBacknoteBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button backNumberButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Label SumErrorLabel;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Label ErrorZeroLabel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button plusFiveThousand;
        private System.Windows.Forms.Button minusFiveThousand;
        private System.Windows.Forms.Button minusOneThousand;
        private System.Windows.Forms.Button plusOneThousand;
        private System.Windows.Forms.Button minusFiveHundred;
        private System.Windows.Forms.Button plusFiveHundred;
        private System.Windows.Forms.Button minusOneHundred;
        private System.Windows.Forms.Button plusOneHundred;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox minSumTextBox;
        private System.Windows.Forms.TextBox maxSumTextBox;
        private System.Windows.Forms.Label GapNumber;
        private System.Windows.Forms.Label NullLabel;
    }
}

