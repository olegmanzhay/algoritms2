namespace Homework10
{
    partial class Homework10
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
            this.bntStart = new System.Windows.Forms.Button();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.lblTrueOrFalse = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bntStart
            // 
            this.bntStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bntStart.Location = new System.Drawing.Point(84, 148);
            this.bntStart.Name = "bntStart";
            this.bntStart.Size = new System.Drawing.Size(158, 85);
            this.bntStart.TabIndex = 0;
            this.bntStart.Text = "Старт";
            this.bntStart.UseVisualStyleBackColor = true;
            this.bntStart.Click += new System.EventHandler(this.bntStart_Click);
            // 
            // txtNumber
            // 
            this.txtNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtNumber.Location = new System.Drawing.Point(68, 70);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(192, 31);
            this.txtNumber.TabIndex = 1;
            // 
            // lblTrueOrFalse
            // 
            this.lblTrueOrFalse.AutoSize = true;
            this.lblTrueOrFalse.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.lblTrueOrFalse.Location = new System.Drawing.Point(133, 104);
            this.lblTrueOrFalse.Name = "lblTrueOrFalse";
            this.lblTrueOrFalse.Size = new System.Drawing.Size(0, 26);
            this.lblTrueOrFalse.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.label1.Location = new System.Drawing.Point(133, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 26);
            this.label1.TabIndex = 3;
            this.label1.Text = "Число";
            // 
            // Homework10
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 260);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTrueOrFalse);
            this.Controls.Add(this.txtNumber);
            this.Controls.Add(this.bntStart);
            this.Name = "Homework10";
            this.Text = "Homework10";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bntStart;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.Label lblTrueOrFalse;
        private System.Windows.Forms.Label label1;
    }
}

