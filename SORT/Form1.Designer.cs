namespace SORT
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.DGV = new System.Windows.Forms.DataGridView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.graphicCH = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.drawingPanel = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ClearBTN = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.DemonstrateBTN = new System.Windows.Forms.Button();
            this.SortBTN = new System.Windows.Forms.Button();
            this.MoveRBTN = new System.Windows.Forms.RadioButton();
            this.ShellRBTN = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.SravBTN = new System.Windows.Forms.Button();
            this.KSravRBTN = new System.Windows.Forms.RadioButton();
            this.KObmenRBTN = new System.Windows.Forms.RadioButton();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.graphicCH)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 58.97436F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 41.02564F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 654F));
            this.tableLayoutPanel1.Controls.Add(this.DGV, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tabControl1, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1045, 484);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // DGV
            // 
            this.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGV.Location = new System.Drawing.Point(3, 3);
            this.DGV.Name = "DGV";
            this.DGV.Size = new System.Drawing.Size(224, 478);
            this.DGV.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(393, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(649, 478);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.graphicCH);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(641, 452);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Сравнение";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // graphicCH
            // 
            chartArea1.Name = "ChartArea1";
            this.graphicCH.ChartAreas.Add(chartArea1);
            this.graphicCH.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.graphicCH.Legends.Add(legend1);
            this.graphicCH.Location = new System.Drawing.Point(3, 3);
            this.graphicCH.Name = "graphicCH";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.LegendText = "Сортировка подсчетом";
            series1.Name = "Series1";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.LegendText = "Сортировка Шелла";
            series2.Name = "Series2";
            this.graphicCH.Series.Add(series1);
            this.graphicCH.Series.Add(series2);
            this.graphicCH.Size = new System.Drawing.Size(635, 446);
            this.graphicCH.TabIndex = 0;
            this.graphicCH.Text = "chart1";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.drawingPanel);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(641, 452);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Визуализация";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // drawingPanel
            // 
            this.drawingPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.drawingPanel.Location = new System.Drawing.Point(3, 3);
            this.drawingPanel.Name = "drawingPanel";
            this.drawingPanel.Size = new System.Drawing.Size(635, 446);
            this.drawingPanel.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.40764F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 51.59236F));
            this.tableLayoutPanel2.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.groupBox2, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.groupBox3, 0, 2);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(233, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 34.32343F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 65.67657F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 186F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(154, 478);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ClearBTN);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(148, 94);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Операции";
            // 
            // ClearBTN
            // 
            this.ClearBTN.Location = new System.Drawing.Point(1, 62);
            this.ClearBTN.Name = "ClearBTN";
            this.ClearBTN.Size = new System.Drawing.Size(144, 23);
            this.ClearBTN.TabIndex = 2;
            this.ClearBTN.Text = "Очистить";
            this.ClearBTN.UseVisualStyleBackColor = true;
            this.ClearBTN.Click += new System.EventHandler(this.ClearBTN_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(144, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Заполнить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.DemonstrateBTN);
            this.groupBox2.Controls.Add(this.SortBTN);
            this.groupBox2.Controls.Add(this.MoveRBTN);
            this.groupBox2.Controls.Add(this.ShellRBTN);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(3, 103);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(148, 185);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Выбор Сортировки";
            // 
            // DemonstrateBTN
            // 
            this.DemonstrateBTN.Location = new System.Drawing.Point(1, 135);
            this.DemonstrateBTN.Name = "DemonstrateBTN";
            this.DemonstrateBTN.Size = new System.Drawing.Size(144, 23);
            this.DemonstrateBTN.TabIndex = 3;
            this.DemonstrateBTN.Text = "Демонстрация";
            this.DemonstrateBTN.UseVisualStyleBackColor = true;
            // 
            // SortBTN
            // 
            this.SortBTN.Location = new System.Drawing.Point(1, 89);
            this.SortBTN.Name = "SortBTN";
            this.SortBTN.Size = new System.Drawing.Size(144, 23);
            this.SortBTN.TabIndex = 2;
            this.SortBTN.Text = "Отсортировать";
            this.SortBTN.UseVisualStyleBackColor = true;
            this.SortBTN.Click += new System.EventHandler(this.SortBTN_Click);
            // 
            // MoveRBTN
            // 
            this.MoveRBTN.AutoSize = true;
            this.MoveRBTN.Location = new System.Drawing.Point(1, 52);
            this.MoveRBTN.Name = "MoveRBTN";
            this.MoveRBTN.Size = new System.Drawing.Size(144, 17);
            this.MoveRBTN.TabIndex = 1;
            this.MoveRBTN.TabStop = true;
            this.MoveRBTN.Text = "Сортировка Подсчетом";
            this.MoveRBTN.UseVisualStyleBackColor = true;
            // 
            // ShellRBTN
            // 
            this.ShellRBTN.AutoSize = true;
            this.ShellRBTN.Location = new System.Drawing.Point(1, 29);
            this.ShellRBTN.Name = "ShellRBTN";
            this.ShellRBTN.Size = new System.Drawing.Size(121, 17);
            this.ShellRBTN.TabIndex = 0;
            this.ShellRBTN.TabStop = true;
            this.ShellRBTN.Text = "Сортировка Шелла";
            this.ShellRBTN.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.SravBTN);
            this.groupBox3.Controls.Add(this.KSravRBTN);
            this.groupBox3.Controls.Add(this.KObmenRBTN);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(3, 294);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(148, 181);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Сравнение";
            // 
            // SravBTN
            // 
            this.SravBTN.Location = new System.Drawing.Point(7, 101);
            this.SravBTN.Name = "SravBTN";
            this.SravBTN.Size = new System.Drawing.Size(138, 23);
            this.SravBTN.TabIndex = 2;
            this.SravBTN.Text = "Сравнить";
            this.SravBTN.UseVisualStyleBackColor = true;
            this.SravBTN.Click += new System.EventHandler(this.SravBTN_Click);
            // 
            // KSravRBTN
            // 
            this.KSravRBTN.AutoSize = true;
            this.KSravRBTN.Location = new System.Drawing.Point(7, 65);
            this.KSravRBTN.Name = "KSravRBTN";
            this.KSravRBTN.Size = new System.Drawing.Size(141, 17);
            this.KSravRBTN.TabIndex = 1;
            this.KSravRBTN.TabStop = true;
            this.KSravRBTN.Text = "Количество сравнений";
            this.KSravRBTN.UseVisualStyleBackColor = true;
            // 
            // KObmenRBTN
            // 
            this.KObmenRBTN.AutoSize = true;
            this.KObmenRBTN.Location = new System.Drawing.Point(7, 30);
            this.KObmenRBTN.Name = "KObmenRBTN";
            this.KObmenRBTN.Size = new System.Drawing.Size(131, 17);
            this.KObmenRBTN.TabIndex = 0;
            this.KObmenRBTN.TabStop = true;
            this.KObmenRBTN.Text = "Количество обменов";
            this.KObmenRBTN.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 484);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.graphicCH)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView DGV;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataVisualization.Charting.Chart graphicCH;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel drawingPanel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button ClearBTN;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button DemonstrateBTN;
        private System.Windows.Forms.Button SortBTN;
        private System.Windows.Forms.RadioButton MoveRBTN;
        private System.Windows.Forms.RadioButton ShellRBTN;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button SravBTN;
        private System.Windows.Forms.RadioButton KSravRBTN;
        private System.Windows.Forms.RadioButton KObmenRBTN;
    }
}

