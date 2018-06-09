namespace Atta_2
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
            this.Opn = new System.Windows.Forms.Button();
            this.Resh = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Opn
            // 
            this.Opn.Location = new System.Drawing.Point(55, 241);
            this.Opn.Name = "Opn";
            this.Opn.Size = new System.Drawing.Size(75, 23);
            this.Opn.TabIndex = 0;
            this.Opn.Text = "Открыть";
            this.Opn.UseVisualStyleBackColor = true;
            this.Opn.Click += new System.EventHandler(this.Opn_Click);
            // 
            // Resh
            // 
            this.Resh.Location = new System.Drawing.Point(329, 241);
            this.Resh.Name = "Resh";
            this.Resh.Size = new System.Drawing.Size(75, 23);
            this.Resh.TabIndex = 1;
            this.Resh.Text = "Решить";
            this.Resh.UseVisualStyleBackColor = true;
            this.Resh.Click += new System.EventHandler(this.Resh_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(55, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(349, 212);
            this.textBox1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 296);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Resh);
            this.Controls.Add(this.Opn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Opn;
        private System.Windows.Forms.Button Resh;
        private System.Windows.Forms.TextBox textBox1;
    }
}

