namespace Tree
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
            this.generateBTN = new System.Windows.Forms.Button();
            this.clearBTN = new System.Windows.Forms.Button();
            this.solveBTN = new System.Windows.Forms.Button();
            this.drawingPanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // generateBTN
            // 
            this.generateBTN.Location = new System.Drawing.Point(109, 13);
            this.generateBTN.Name = "generateBTN";
            this.generateBTN.Size = new System.Drawing.Size(141, 40);
            this.generateBTN.TabIndex = 0;
            this.generateBTN.Text = "Построение Дерева";
            this.generateBTN.UseVisualStyleBackColor = true;
            this.generateBTN.Click += new System.EventHandler(this.generateBTN_Click);
            // 
            // clearBTN
            // 
            this.clearBTN.Location = new System.Drawing.Point(290, 14);
            this.clearBTN.Name = "clearBTN";
            this.clearBTN.Size = new System.Drawing.Size(141, 39);
            this.clearBTN.TabIndex = 1;
            this.clearBTN.Text = "Очистка";
            this.clearBTN.UseVisualStyleBackColor = true;
            this.clearBTN.Click += new System.EventHandler(this.clearBTN_Click);
            // 
            // solveBTN
            // 
            this.solveBTN.Location = new System.Drawing.Point(473, 13);
            this.solveBTN.Name = "solveBTN";
            this.solveBTN.Size = new System.Drawing.Size(141, 39);
            this.solveBTN.TabIndex = 2;
            this.solveBTN.Text = "Решение задачи";
            this.solveBTN.UseVisualStyleBackColor = true;
            this.solveBTN.Click += new System.EventHandler(this.solveBTN_Click);
            // 
            // drawingPanel
            // 
            this.drawingPanel.Location = new System.Drawing.Point(12, 58);
            this.drawingPanel.Name = "drawingPanel";
            this.drawingPanel.Size = new System.Drawing.Size(784, 454);
            this.drawingPanel.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 524);
            this.Controls.Add(this.drawingPanel);
            this.Controls.Add(this.solveBTN);
            this.Controls.Add(this.clearBTN);
            this.Controls.Add(this.generateBTN);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button generateBTN;
        private System.Windows.Forms.Button clearBTN;
        private System.Windows.Forms.Button solveBTN;
        private System.Windows.Forms.Panel drawingPanel;
    }
}

