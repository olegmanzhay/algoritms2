namespace Homework1
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
            this.txtCountElement = new System.Windows.Forms.TextBox();
            this.txtStart = new System.Windows.Forms.TextBox();
            this.txtFinish = new System.Windows.Forms.TextBox();
            this.lblCountElement = new System.Windows.Forms.Label();
            this.lblStart = new System.Windows.Forms.Label();
            this.lblFinish = new System.Windows.Forms.Label();
            this.txtOldMassive = new System.Windows.Forms.TextBox();
            this.lblOldMassive = new System.Windows.Forms.Label();
            this.lblNewMassive = new System.Windows.Forms.Label();
            this.txtNewMassive = new System.Windows.Forms.TextBox();
            this.btnBubble = new System.Windows.Forms.Button();
            this.btnSuperBubble = new System.Windows.Forms.Button();
            this.lblCountOperation = new System.Windows.Forms.Label();
            this.txtCountOperation = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnBinarySearch = new System.Windows.Forms.Button();
            this.lblBinarySearch = new System.Windows.Forms.Label();
            this.txtBinarySearch = new System.Windows.Forms.TextBox();
            this.lblElement = new System.Windows.Forms.Label();
            this.txtElement = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtCountElement
            // 
            this.txtCountElement.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.txtCountElement.Location = new System.Drawing.Point(322, 25);
            this.txtCountElement.Name = "txtCountElement";
            this.txtCountElement.Size = new System.Drawing.Size(166, 26);
            this.txtCountElement.TabIndex = 0;
            this.txtCountElement.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtStart
            // 
            this.txtStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.txtStart.Location = new System.Drawing.Point(322, 68);
            this.txtStart.Name = "txtStart";
            this.txtStart.Size = new System.Drawing.Size(166, 26);
            this.txtStart.TabIndex = 1;
            this.txtStart.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtFinish
            // 
            this.txtFinish.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.txtFinish.Location = new System.Drawing.Point(322, 115);
            this.txtFinish.Name = "txtFinish";
            this.txtFinish.Size = new System.Drawing.Size(166, 26);
            this.txtFinish.TabIndex = 2;
            this.txtFinish.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblCountElement
            // 
            this.lblCountElement.AutoSize = true;
            this.lblCountElement.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lblCountElement.Location = new System.Drawing.Point(22, 25);
            this.lblCountElement.Name = "lblCountElement";
            this.lblCountElement.Size = new System.Drawing.Size(281, 20);
            this.lblCountElement.TabIndex = 3;
            this.lblCountElement.Text = "Количество элементов массива";
            // 
            // lblStart
            // 
            this.lblStart.AutoSize = true;
            this.lblStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lblStart.Location = new System.Drawing.Point(22, 68);
            this.lblStart.Name = "lblStart";
            this.lblStart.Size = new System.Drawing.Size(168, 20);
            this.lblStart.TabIndex = 4;
            this.lblStart.Text = "Начало диапазона";
            // 
            // lblFinish
            // 
            this.lblFinish.AutoSize = true;
            this.lblFinish.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lblFinish.Location = new System.Drawing.Point(22, 115);
            this.lblFinish.Name = "lblFinish";
            this.lblFinish.Size = new System.Drawing.Size(156, 20);
            this.lblFinish.TabIndex = 5;
            this.lblFinish.Text = "Конец диапазона";
            // 
            // txtOldMassive
            // 
            this.txtOldMassive.Enabled = false;
            this.txtOldMassive.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.txtOldMassive.Location = new System.Drawing.Point(25, 176);
            this.txtOldMassive.Name = "txtOldMassive";
            this.txtOldMassive.Size = new System.Drawing.Size(463, 26);
            this.txtOldMassive.TabIndex = 6;
            this.txtOldMassive.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtOldMassive.TextChanged += new System.EventHandler(this.txtOldMassive_TextChanged);
            // 
            // lblOldMassive
            // 
            this.lblOldMassive.AutoSize = true;
            this.lblOldMassive.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lblOldMassive.Location = new System.Drawing.Point(176, 153);
            this.lblOldMassive.Name = "lblOldMassive";
            this.lblOldMassive.Size = new System.Drawing.Size(156, 20);
            this.lblOldMassive.TabIndex = 7;
            this.lblOldMassive.Text = "Исходный массив";
            // 
            // lblNewMassive
            // 
            this.lblNewMassive.AutoSize = true;
            this.lblNewMassive.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lblNewMassive.Location = new System.Drawing.Point(148, 216);
            this.lblNewMassive.Name = "lblNewMassive";
            this.lblNewMassive.Size = new System.Drawing.Size(228, 20);
            this.lblNewMassive.TabIndex = 9;
            this.lblNewMassive.Text = "Отсортированный массив";
            // 
            // txtNewMassive
            // 
            this.txtNewMassive.Enabled = false;
            this.txtNewMassive.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.txtNewMassive.Location = new System.Drawing.Point(25, 239);
            this.txtNewMassive.Name = "txtNewMassive";
            this.txtNewMassive.Size = new System.Drawing.Size(463, 26);
            this.txtNewMassive.TabIndex = 8;
            this.txtNewMassive.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnBubble
            // 
            this.btnBubble.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnBubble.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.btnBubble.Location = new System.Drawing.Point(12, 360);
            this.btnBubble.Name = "btnBubble";
            this.btnBubble.Size = new System.Drawing.Size(140, 62);
            this.btnBubble.TabIndex = 10;
            this.btnBubble.Text = "Пузырек";
            this.btnBubble.UseVisualStyleBackColor = false;
            this.btnBubble.Click += new System.EventHandler(this.btnBubble_Click);
            // 
            // btnSuperBubble
            // 
            this.btnSuperBubble.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnSuperBubble.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.btnSuperBubble.Location = new System.Drawing.Point(158, 360);
            this.btnSuperBubble.Name = "btnSuperBubble";
            this.btnSuperBubble.Size = new System.Drawing.Size(184, 62);
            this.btnSuperBubble.TabIndex = 11;
            this.btnSuperBubble.Text = "Пузырек оптимизированный";
            this.btnSuperBubble.UseVisualStyleBackColor = false;
            this.btnSuperBubble.Click += new System.EventHandler(this.btnSuperBubble_Click);
            // 
            // lblCountOperation
            // 
            this.lblCountOperation.AutoSize = true;
            this.lblCountOperation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lblCountOperation.Location = new System.Drawing.Point(115, 285);
            this.lblCountOperation.Name = "lblCountOperation";
            this.lblCountOperation.Size = new System.Drawing.Size(288, 20);
            this.lblCountOperation.TabIndex = 13;
            this.lblCountOperation.Text = "Количество операций сравнения";
            // 
            // txtCountOperation
            // 
            this.txtCountOperation.Enabled = false;
            this.txtCountOperation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.txtCountOperation.Location = new System.Drawing.Point(26, 308);
            this.txtCountOperation.Name = "txtCountOperation";
            this.txtCountOperation.Size = new System.Drawing.Size(462, 26);
            this.txtCountOperation.TabIndex = 12;
            this.txtCountOperation.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.button1.Location = new System.Drawing.Point(348, 360);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 62);
            this.button1.TabIndex = 14;
            this.button1.Text = "Шейкерная сортировка";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnBinarySearch
            // 
            this.btnBinarySearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnBinarySearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.btnBinarySearch.Location = new System.Drawing.Point(348, 450);
            this.btnBinarySearch.Name = "btnBinarySearch";
            this.btnBinarySearch.Size = new System.Drawing.Size(143, 55);
            this.btnBinarySearch.TabIndex = 15;
            this.btnBinarySearch.Text = "Бинарный поиск";
            this.btnBinarySearch.UseVisualStyleBackColor = false;
            this.btnBinarySearch.Click += new System.EventHandler(this.btnBinarySearch_Click);
            // 
            // lblBinarySearch
            // 
            this.lblBinarySearch.AutoSize = true;
            this.lblBinarySearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lblBinarySearch.Location = new System.Drawing.Point(12, 482);
            this.lblBinarySearch.Name = "lblBinarySearch";
            this.lblBinarySearch.Size = new System.Drawing.Size(168, 20);
            this.lblBinarySearch.TabIndex = 17;
            this.lblBinarySearch.Text = "Позиция элемента";
            // 
            // txtBinarySearch
            // 
            this.txtBinarySearch.Enabled = false;
            this.txtBinarySearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.txtBinarySearch.Location = new System.Drawing.Point(205, 478);
            this.txtBinarySearch.Name = "txtBinarySearch";
            this.txtBinarySearch.Size = new System.Drawing.Size(137, 26);
            this.txtBinarySearch.TabIndex = 16;
            this.txtBinarySearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblElement
            // 
            this.lblElement.AutoSize = true;
            this.lblElement.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lblElement.Location = new System.Drawing.Point(12, 450);
            this.lblElement.Name = "lblElement";
            this.lblElement.Size = new System.Drawing.Size(187, 20);
            this.lblElement.TabIndex = 19;
            this.lblElement.Text = "Выбранный элемент ";
            // 
            // txtElement
            // 
            this.txtElement.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.txtElement.Location = new System.Drawing.Point(205, 450);
            this.txtElement.Name = "txtElement";
            this.txtElement.Size = new System.Drawing.Size(137, 26);
            this.txtElement.TabIndex = 18;
            this.txtElement.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(512, 536);
            this.Controls.Add(this.lblElement);
            this.Controls.Add(this.txtElement);
            this.Controls.Add(this.lblBinarySearch);
            this.Controls.Add(this.txtBinarySearch);
            this.Controls.Add(this.btnBinarySearch);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblCountOperation);
            this.Controls.Add(this.txtCountOperation);
            this.Controls.Add(this.btnSuperBubble);
            this.Controls.Add(this.btnBubble);
            this.Controls.Add(this.lblNewMassive);
            this.Controls.Add(this.txtNewMassive);
            this.Controls.Add(this.lblOldMassive);
            this.Controls.Add(this.txtOldMassive);
            this.Controls.Add(this.lblFinish);
            this.Controls.Add(this.lblStart);
            this.Controls.Add(this.lblCountElement);
            this.Controls.Add(this.txtFinish);
            this.Controls.Add(this.txtStart);
            this.Controls.Add(this.txtCountElement);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCountElement;
        private System.Windows.Forms.TextBox txtStart;
        private System.Windows.Forms.TextBox txtFinish;
        private System.Windows.Forms.Label lblCountElement;
        private System.Windows.Forms.Label lblStart;
        private System.Windows.Forms.Label lblFinish;
        private System.Windows.Forms.TextBox txtOldMassive;
        private System.Windows.Forms.Label lblOldMassive;
        private System.Windows.Forms.Label lblNewMassive;
        private System.Windows.Forms.TextBox txtNewMassive;
        private System.Windows.Forms.Button btnBubble;
        private System.Windows.Forms.Button btnSuperBubble;
        private System.Windows.Forms.Label lblCountOperation;
        private System.Windows.Forms.TextBox txtCountOperation;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnBinarySearch;
        private System.Windows.Forms.Label lblBinarySearch;
        private System.Windows.Forms.TextBox txtBinarySearch;
        private System.Windows.Forms.Label lblElement;
        private System.Windows.Forms.TextBox txtElement;
    }
}

