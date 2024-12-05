namespace Tyuiu.NovikovaVA.Sprint6.Task2.V10
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
            groupBoxTask_NVA = new GroupBox();
            textBoxUslovie_NVA = new TextBox();
            groupBoxData_NVA = new GroupBox();
            textBoxEnd_NVA = new TextBox();
            labelNamedTwo_NVA = new Label();
            textBoxStart_NVA = new TextBox();
            labelNamedOne_NVA = new Label();
            groupBoxRes_NVA = new GroupBox();
            dataGridViewFunction_NVA = new DataGridView();
            X = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            labelNamesThree_NVA = new Label();
            buttonHelp_NVA = new Button();
            buttonDone_NVA = new Button();
            chartFunction = new System.Windows.Forms.DataVisualization.Charting.Chart();
            groupBoxTask_NVA.SuspendLayout();
            groupBoxData_NVA.SuspendLayout();
            groupBoxRes_NVA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewFunction_NVA).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chartFunction).BeginInit();
            SuspendLayout();
            // 
            // groupBoxTask_NVA
            // 
            groupBoxTask_NVA.Controls.Add(textBoxUslovie_NVA);
            groupBoxTask_NVA.Location = new Point(31, 29);
            groupBoxTask_NVA.Name = "groupBoxTask_NVA";
            groupBoxTask_NVA.Size = new Size(384, 205);
            groupBoxTask_NVA.TabIndex = 2;
            groupBoxTask_NVA.TabStop = false;
            groupBoxTask_NVA.Text = "Условие";
            // 
            // textBoxUslovie_NVA
            // 
            textBoxUslovie_NVA.BackColor = SystemColors.Menu;
            textBoxUslovie_NVA.Location = new Point(11, 22);
            textBoxUslovie_NVA.Multiline = true;
            textBoxUslovie_NVA.Name = "textBoxUslovie_NVA";
            textBoxUslovie_NVA.ReadOnly = true;
            textBoxUslovie_NVA.Size = new Size(337, 123);
            textBoxUslovie_NVA.TabIndex = 0;
            textBoxUslovie_NVA.Text = "Протабулировать функцию на заданном диапазоне.\r\nРезультат выести в виде таблицы.";
            // 
            // groupBoxData_NVA
            // 
            groupBoxData_NVA.Controls.Add(textBoxEnd_NVA);
            groupBoxData_NVA.Controls.Add(labelNamedTwo_NVA);
            groupBoxData_NVA.Controls.Add(textBoxStart_NVA);
            groupBoxData_NVA.Controls.Add(labelNamedOne_NVA);
            groupBoxData_NVA.Location = new Point(31, 240);
            groupBoxData_NVA.Name = "groupBoxData_NVA";
            groupBoxData_NVA.Size = new Size(307, 99);
            groupBoxData_NVA.TabIndex = 3;
            groupBoxData_NVA.TabStop = false;
            groupBoxData_NVA.Text = "Ввод данных";
            // 
            // textBoxEnd_NVA
            // 
            textBoxEnd_NVA.Location = new Point(172, 47);
            textBoxEnd_NVA.Name = "textBoxEnd_NVA";
            textBoxEnd_NVA.Size = new Size(100, 23);
            textBoxEnd_NVA.TabIndex = 3;
            // 
            // labelNamedTwo_NVA
            // 
            labelNamedTwo_NVA.AutoSize = true;
            labelNamedTwo_NVA.Location = new Point(172, 29);
            labelNamedTwo_NVA.Name = "labelNamedTwo_NVA";
            labelNamedTwo_NVA.Size = new Size(75, 15);
            labelNamedTwo_NVA.TabIndex = 2;
            labelNamedTwo_NVA.Text = "Конец шага:";
            // 
            // textBoxStart_NVA
            // 
            textBoxStart_NVA.Location = new Point(15, 47);
            textBoxStart_NVA.Name = "textBoxStart_NVA";
            textBoxStart_NVA.Size = new Size(100, 23);
            textBoxStart_NVA.TabIndex = 1;
            // 
            // labelNamedOne_NVA
            // 
            labelNamedOne_NVA.AutoSize = true;
            labelNamedOne_NVA.Location = new Point(15, 29);
            labelNamedOne_NVA.Name = "labelNamedOne_NVA";
            labelNamedOne_NVA.Size = new Size(72, 15);
            labelNamedOne_NVA.TabIndex = 0;
            labelNamedOne_NVA.Text = "Старт шага:";
            // 
            // groupBoxRes_NVA
            // 
            groupBoxRes_NVA.Controls.Add(dataGridViewFunction_NVA);
            groupBoxRes_NVA.Controls.Add(labelNamesThree_NVA);
            groupBoxRes_NVA.Location = new Point(433, 29);
            groupBoxRes_NVA.Name = "groupBoxRes_NVA";
            groupBoxRes_NVA.Size = new Size(248, 375);
            groupBoxRes_NVA.TabIndex = 4;
            groupBoxRes_NVA.TabStop = false;
            groupBoxRes_NVA.Text = "Вывод данных:";
            // 
            // dataGridViewFunction_NVA
            // 
            dataGridViewFunction_NVA.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewFunction_NVA.Columns.AddRange(new DataGridViewColumn[] { X, Column1 });
            dataGridViewFunction_NVA.Location = new Point(20, 72);
            dataGridViewFunction_NVA.Name = "dataGridViewFunction_NVA";
            dataGridViewFunction_NVA.RowHeadersVisible = false;
            dataGridViewFunction_NVA.Size = new Size(189, 288);
            dataGridViewFunction_NVA.TabIndex = 2;
            // 
            // X
            // 
            X.HeaderText = "X";
            X.Name = "X";
            X.Width = 50;
            // 
            // Column1
            // 
            Column1.HeaderText = "F(x)";
            Column1.Name = "Column1";
            Column1.Width = 50;
            // 
            // labelNamesThree_NVA
            // 
            labelNamesThree_NVA.AutoSize = true;
            labelNamesThree_NVA.Location = new Point(20, 28);
            labelNamesThree_NVA.Name = "labelNamesThree_NVA";
            labelNamesThree_NVA.Size = new Size(63, 15);
            labelNamesThree_NVA.TabIndex = 1;
            labelNamesThree_NVA.Text = "Результат:";
            // 
            // buttonHelp_NVA
            // 
            buttonHelp_NVA.BackColor = SystemColors.HotTrack;
            buttonHelp_NVA.Location = new Point(203, 368);
            buttonHelp_NVA.Name = "buttonHelp_NVA";
            buttonHelp_NVA.Size = new Size(84, 56);
            buttonHelp_NVA.TabIndex = 6;
            buttonHelp_NVA.Text = "Справка";
            buttonHelp_NVA.UseVisualStyleBackColor = false;
            buttonHelp_NVA.Click += buttonHelp_NVA_Click;
            // 
            // buttonDone_NVA
            // 
            buttonDone_NVA.BackColor = Color.Lime;
            buttonDone_NVA.Location = new Point(306, 366);
            buttonDone_NVA.Name = "buttonDone_NVA";
            buttonDone_NVA.Size = new Size(92, 58);
            buttonDone_NVA.TabIndex = 7;
            buttonDone_NVA.Text = "Выполнить";
            buttonDone_NVA.UseVisualStyleBackColor = false;
            buttonDone_NVA.Click += buttonDone_NVA_Click;
            // 
            // chartFunction
            // 
            chartArea1.Name = "ChartArea1";
            chartFunction.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chartFunction.Legends.Add(legend1);
            chartFunction.Location = new Point(737, 75);
            chartFunction.Name = "chartFunction";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartFunction.Series.Add(series1);
            chartFunction.Size = new Size(300, 300);
            chartFunction.TabIndex = 8;
            chartFunction.Text = "chart1";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1093, 458);
            Controls.Add(chartFunction);
            Controls.Add(buttonDone_NVA);
            Controls.Add(buttonHelp_NVA);
            Controls.Add(groupBoxRes_NVA);
            Controls.Add(groupBoxData_NVA);
            Controls.Add(groupBoxTask_NVA);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 2 | Вариант 10 | Новикова В. А.";
            groupBoxTask_NVA.ResumeLayout(false);
            groupBoxTask_NVA.PerformLayout();
            groupBoxData_NVA.ResumeLayout(false);
            groupBoxData_NVA.PerformLayout();
            groupBoxRes_NVA.ResumeLayout(false);
            groupBoxRes_NVA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewFunction_NVA).EndInit();
            ((System.ComponentModel.ISupportInitialize)chartFunction).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxTask_NVA;
        private TextBox textBoxUslovie_NVA;
        private GroupBox groupBoxData_NVA;
        private TextBox textBoxEnd_NVA;
        private Label labelNamedTwo_NVA;
        private TextBox textBoxStart_NVA;
        private Label labelNamedOne_NVA;
        private GroupBox groupBoxRes_NVA;
        private Label labelNamesThree_NVA;
        private Button buttonHelp_NVA;
        private Button buttonDone_NVA;
        private DataGridView dataGridViewFunction_NVA;
        private DataGridViewTextBoxColumn X;
        private DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction;
    }
}
