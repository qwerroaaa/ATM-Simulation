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
            this.label1.Location = new System.Drawing.Point(191, 125);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 657);
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
    }
}

