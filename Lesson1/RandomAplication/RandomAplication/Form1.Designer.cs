namespace RandomAplication
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
            this.btnRandom = new System.Windows.Forms.Button();
            this.TextNumber1 = new System.Windows.Forms.Label();
            this.TextNumber2 = new System.Windows.Forms.Label();
            this.Number1 = new System.Windows.Forms.Label();
            this.Number2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnRandom
            // 
            this.btnRandom.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.btnRandom.Location = new System.Drawing.Point(101, 116);
            this.btnRandom.Name = "btnRandom";
            this.btnRandom.Size = new System.Drawing.Size(172, 115);
            this.btnRandom.TabIndex = 0;
            this.btnRandom.Text = "Рандом";
            this.btnRandom.UseVisualStyleBackColor = true;
            this.btnRandom.Click += new System.EventHandler(this.btnRandom_Click);
            // 
            // TextNumber1
            // 
            this.TextNumber1.AutoSize = true;
            this.TextNumber1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.TextNumber1.Location = new System.Drawing.Point(21, 18);
            this.TextNumber1.Name = "TextNumber1";
            this.TextNumber1.Size = new System.Drawing.Size(266, 24);
            this.TextNumber1.TabIndex = 1;
            this.TextNumber1.Text = "Число стандартной функции";
            this.TextNumber1.Click += new System.EventHandler(this.label1_Click);
            // 
            // TextNumber2
            // 
            this.TextNumber2.AutoSize = true;
            this.TextNumber2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.TextNumber2.Location = new System.Drawing.Point(21, 55);
            this.TextNumber2.Name = "TextNumber2";
            this.TextNumber2.Size = new System.Drawing.Size(210, 24);
            this.TextNumber2.TabIndex = 2;
            this.TextNumber2.Text = "Число своего способа";
            // 
            // Number1
            // 
            this.Number1.AutoSize = true;
            this.Number1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.Number1.Location = new System.Drawing.Point(304, 18);
            this.Number1.Name = "Number1";
            this.Number1.Size = new System.Drawing.Size(20, 24);
            this.Number1.TabIndex = 3;
            this.Number1.Text = "0";
            // 
            // Number2
            // 
            this.Number2.AutoSize = true;
            this.Number2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.Number2.Location = new System.Drawing.Point(304, 55);
            this.Number2.Name = "Number2";
            this.Number2.Size = new System.Drawing.Size(20, 24);
            this.Number2.TabIndex = 4;
            this.Number2.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 269);
            this.Controls.Add(this.Number2);
            this.Controls.Add(this.Number1);
            this.Controls.Add(this.TextNumber2);
            this.Controls.Add(this.TextNumber1);
            this.Controls.Add(this.btnRandom);
            this.Name = "Form1";
            this.Text = "Рандомайзер";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRandom;
        private System.Windows.Forms.Label TextNumber1;
        private System.Windows.Forms.Label TextNumber2;
        private System.Windows.Forms.Label Number1;
        private System.Windows.Forms.Label Number2;
    }
}

