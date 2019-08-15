namespace Homework6
{
    partial class Homework6
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
            this.btnStart = new System.Windows.Forms.Button();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.lblAge = new System.Windows.Forms.Label();
            this.lblAgeString = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.btnStart.Location = new System.Drawing.Point(113, 81);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(144, 66);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Нажми";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // txtAge
            // 
            this.txtAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.txtAge.Location = new System.Drawing.Point(113, 25);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(144, 32);
            this.txtAge.TabIndex = 1;
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.lblAge.Location = new System.Drawing.Point(12, 25);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(95, 26);
            this.lblAge.TabIndex = 2;
            this.lblAge.Text = "Возраст";
            // 
            // lblAgeString
            // 
            this.lblAgeString.AutoSize = true;
            this.lblAgeString.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.lblAgeString.Location = new System.Drawing.Point(12, 181);
            this.lblAgeString.Name = "lblAgeString";
            this.lblAgeString.Size = new System.Drawing.Size(0, 26);
            this.lblAgeString.TabIndex = 3;
            // 
            // Homework6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 237);
            this.Controls.Add(this.lblAgeString);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.btnStart);
            this.Name = "Homework6";
            this.Text = "Homework6";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Label lblAgeString;
    }
}

