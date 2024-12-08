namespace Tyuiu.NovikovaVA.Sprint6.Task5.V15
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            groupBoxRes_NVA = new GroupBox();
            dataGridViewResult_NVA = new DataGridView();
            chartRes_NVA = new System.Windows.Forms.DataVisualization.Charting.Chart();
            buttonDone_NVA = new Button();
            buttonHelp_NVA = new Button();
            groupBoxTask_NVA = new GroupBox();
            textBoxUslovie_NVA = new TextBox();
            buttonOpenFile_NVA = new Button();
            groupBoxRes_NVA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewResult_NVA).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chartRes_NVA).BeginInit();
            groupBoxTask_NVA.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxRes_NVA
            // 
            groupBoxRes_NVA.Controls.Add(dataGridViewResult_NVA);
            groupBoxRes_NVA.Location = new Point(12, 137);
            groupBoxRes_NVA.Name = "groupBoxRes_NVA";
            groupBoxRes_NVA.Size = new Size(225, 459);
            groupBoxRes_NVA.TabIndex = 6;
            groupBoxRes_NVA.TabStop = false;
            groupBoxRes_NVA.Text = "Вывод данных:";
            // 
            // dataGridViewResult_NVA
            // 
            dataGridViewResult_NVA.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewResult_NVA.Location = new Point(6, 22);
            dataGridViewResult_NVA.Name = "dataGridViewResult_NVA";
            dataGridViewResult_NVA.ReadOnly = true;
            dataGridViewResult_NVA.RowHeadersVisible = false;
            dataGridViewResult_NVA.Size = new Size(213, 431);
            dataGridViewResult_NVA.TabIndex = 2;
            // 
            // chartRes_NVA
            // 
            chartArea1.Name = "ChartArea1";
            chartRes_NVA.ChartAreas.Add(chartArea1);
            legend1.Enabled = false;
            legend1.Name = "Legend1";
            chartRes_NVA.Legends.Add(legend1);
            chartRes_NVA.Location = new Point(283, 148);
            chartRes_NVA.Name = "chartRes_NVA";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartRes_NVA.Series.Add(series1);
            chartRes_NVA.Size = new Size(687, 437);
            chartRes_NVA.TabIndex = 7;
            chartRes_NVA.Text = "chart1";
            // 
            // buttonDone_NVA
            // 
            buttonDone_NVA.BackColor = Color.Lime;
            buttonDone_NVA.Location = new Point(645, 54);
            buttonDone_NVA.Name = "buttonDone_NVA";
            buttonDone_NVA.Size = new Size(105, 63);
            buttonDone_NVA.TabIndex = 10;
            buttonDone_NVA.Text = "Выполнить";
            buttonDone_NVA.UseVisualStyleBackColor = false;
            buttonDone_NVA.Click += buttonDone_NVA_Click;
            // 
            // buttonHelp_NVA
            // 
            buttonHelp_NVA.BackColor = SystemColors.HotTrack;
            buttonHelp_NVA.Location = new Point(873, 54);
            buttonHelp_NVA.Name = "buttonHelp_NVA";
            buttonHelp_NVA.Size = new Size(115, 63);
            buttonHelp_NVA.TabIndex = 11;
            buttonHelp_NVA.Text = "Справка";
            buttonHelp_NVA.UseVisualStyleBackColor = false;
            buttonHelp_NVA.Click += buttonHelp_NVA_Click;
            // 
            // groupBoxTask_NVA
            // 
            groupBoxTask_NVA.Controls.Add(textBoxUslovie_NVA);
            groupBoxTask_NVA.Location = new Point(18, 32);
            groupBoxTask_NVA.Name = "groupBoxTask_NVA";
            groupBoxTask_NVA.Size = new Size(611, 99);
            groupBoxTask_NVA.TabIndex = 13;
            groupBoxTask_NVA.TabStop = false;
            groupBoxTask_NVA.Text = "Условие";
            // 
            // textBoxUslovie_NVA
            // 
            textBoxUslovie_NVA.BackColor = SystemColors.Menu;
            textBoxUslovie_NVA.Location = new Point(6, 22);
            textBoxUslovie_NVA.Multiline = true;
            textBoxUslovie_NVA.Name = "textBoxUslovie_NVA";
            textBoxUslovie_NVA.ReadOnly = true;
            textBoxUslovie_NVA.Size = new Size(599, 63);
            textBoxUslovie_NVA.TabIndex = 0;
            textBoxUslovie_NVA.Text = "Прочитать данные из файла InPutFileTask5V15.txt. Вывести в dataGridView все числа от 2 до 7. Построить диаграмму по этим значениям. ";
            // 
            // buttonOpenFile_NVA
            // 
            buttonOpenFile_NVA.BackColor = Color.FromArgb(255, 128, 0);
            buttonOpenFile_NVA.Location = new Point(756, 54);
            buttonOpenFile_NVA.Name = "buttonOpenFile_NVA";
            buttonOpenFile_NVA.Size = new Size(111, 63);
            buttonOpenFile_NVA.TabIndex = 14;
            buttonOpenFile_NVA.Text = "Открыть файл";
            buttonOpenFile_NVA.UseVisualStyleBackColor = false;
            buttonOpenFile_NVA.Click += buttonOpenFile_NVA_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1024, 597);
            Controls.Add(buttonOpenFile_NVA);
            Controls.Add(groupBoxTask_NVA);
            Controls.Add(buttonHelp_NVA);
            Controls.Add(buttonDone_NVA);
            Controls.Add(chartRes_NVA);
            Controls.Add(groupBoxRes_NVA);
            Name = "FormMain";
            Text = "Спринт 6 | Таск 5 | Вариант 15 | Новикова В. А.";
            groupBoxRes_NVA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewResult_NVA).EndInit();
            ((System.ComponentModel.ISupportInitialize)chartRes_NVA).EndInit();
            groupBoxTask_NVA.ResumeLayout(false);
            groupBoxTask_NVA.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxRes_NVA;
        private DataGridView dataGridViewResult_NVA;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartRes_NVA;
        private Button buttonDone_NVA;
        private Button buttonHelp_NVA;
        private GroupBox groupBoxTask_NVA;
        private TextBox textBoxUslovie_NVA;
        private Button buttonOpenFile_NVA;
    }
}
