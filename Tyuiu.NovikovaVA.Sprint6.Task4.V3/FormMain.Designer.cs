namespace Tyuiu.NovikovaVA.Sprint6.Task4.V3
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
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            chartFunction_NVA = new System.Windows.Forms.DataVisualization.Charting.Chart();
            buttonDone_NVA = new Button();
            buttonHelp_NVA = new Button();
            groupBoxData_NVA = new GroupBox();
            textBoxEnd_NVA = new TextBox();
            labelNamedTwo_NVA = new Label();
            textBoxStart_NVA = new TextBox();
            labelNamedOne_NVA = new Label();
            groupBoxTask_NVA = new GroupBox();
            textBoxUslovie_NVA = new TextBox();
            buttonSave_NVA = new Button();
            groupBoxRes_NVA = new GroupBox();
            textBoxRes_NVA = new TextBox();
            ((System.ComponentModel.ISupportInitialize)chartFunction_NVA).BeginInit();
            groupBoxData_NVA.SuspendLayout();
            groupBoxTask_NVA.SuspendLayout();
            groupBoxRes_NVA.SuspendLayout();
            SuspendLayout();
            // 
            // chartFunction_NVA
            // 
            chartArea1.Name = "ChartArea1";
            chartFunction_NVA.ChartAreas.Add(chartArea1);
            legend1.Enabled = false;
            legend1.Name = "Legend1";
            chartFunction_NVA.Legends.Add(legend1);
            chartFunction_NVA.Location = new Point(324, 167);
            chartFunction_NVA.Name = "chartFunction_NVA";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartFunction_NVA.Series.Add(series1);
            chartFunction_NVA.Size = new Size(668, 415);
            chartFunction_NVA.TabIndex = 0;
            title1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            title1.ForeColor = Color.Blue;
            title1.Name = "Title1";
            title1.Text = "График функции sin(x)";
            chartFunction_NVA.Titles.Add(title1);
            // 
            // buttonDone_NVA
            // 
            buttonDone_NVA.BackColor = Color.Lime;
            buttonDone_NVA.Location = new Point(728, 43);
            buttonDone_NVA.Name = "buttonDone_NVA";
            buttonDone_NVA.Size = new Size(94, 54);
            buttonDone_NVA.TabIndex = 9;
            buttonDone_NVA.Text = "Выполнить";
            buttonDone_NVA.UseVisualStyleBackColor = false;
            buttonDone_NVA.Click += buttonDone_NVA_Click;
            // 
            // buttonHelp_NVA
            // 
            buttonHelp_NVA.BackColor = SystemColors.HotTrack;
            buttonHelp_NVA.Location = new Point(930, 42);
            buttonHelp_NVA.Name = "buttonHelp_NVA";
            buttonHelp_NVA.Size = new Size(84, 56);
            buttonHelp_NVA.TabIndex = 10;
            buttonHelp_NVA.Text = "Справка";
            buttonHelp_NVA.UseVisualStyleBackColor = false;
            buttonHelp_NVA.Click += buttonHelp_NVA_Click;
            // 
            // groupBoxData_NVA
            // 
            groupBoxData_NVA.Controls.Add(textBoxEnd_NVA);
            groupBoxData_NVA.Controls.Add(labelNamedTwo_NVA);
            groupBoxData_NVA.Controls.Add(textBoxStart_NVA);
            groupBoxData_NVA.Controls.Add(labelNamedOne_NVA);
            groupBoxData_NVA.Location = new Point(425, 21);
            groupBoxData_NVA.Name = "groupBoxData_NVA";
            groupBoxData_NVA.Size = new Size(297, 99);
            groupBoxData_NVA.TabIndex = 11;
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
            // groupBoxTask_NVA
            // 
            groupBoxTask_NVA.Controls.Add(textBoxUslovie_NVA);
            groupBoxTask_NVA.Location = new Point(17, 21);
            groupBoxTask_NVA.Name = "groupBoxTask_NVA";
            groupBoxTask_NVA.Size = new Size(390, 99);
            groupBoxTask_NVA.TabIndex = 12;
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
            textBoxUslovie_NVA.Size = new Size(369, 63);
            textBoxUslovie_NVA.TabIndex = 0;
            textBoxUslovie_NVA.Text = "Протабулировать функцию на заданном диапазоне.\r\nРезультат выести в textBox, построить график функции и сохранить в файл OutPutFileTask4V3.txt по нажатию кнопки.\r\n";
            // 
            // buttonSave_NVA
            // 
            buttonSave_NVA.BackColor = Color.FromArgb(255, 128, 0);
            buttonSave_NVA.Location = new Point(828, 43);
            buttonSave_NVA.Name = "buttonSave_NVA";
            buttonSave_NVA.Size = new Size(99, 54);
            buttonSave_NVA.TabIndex = 13;
            buttonSave_NVA.Text = "Сохранить";
            buttonSave_NVA.UseVisualStyleBackColor = false;
            buttonSave_NVA.Click += buttonSave_NVA_Click;
            // 
            // groupBoxRes_NVA
            // 
            groupBoxRes_NVA.Controls.Add(textBoxRes_NVA);
            groupBoxRes_NVA.Location = new Point(28, 146);
            groupBoxRes_NVA.Name = "groupBoxRes_NVA";
            groupBoxRes_NVA.Size = new Size(263, 442);
            groupBoxRes_NVA.TabIndex = 14;
            groupBoxRes_NVA.TabStop = false;
            groupBoxRes_NVA.Text = "Вывод данных:";
            // 
            // textBoxRes_NVA
            // 
            textBoxRes_NVA.BackColor = SystemColors.ButtonHighlight;
            textBoxRes_NVA.Font = new Font("Consolas", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxRes_NVA.Location = new Point(6, 22);
            textBoxRes_NVA.Multiline = true;
            textBoxRes_NVA.Name = "textBoxRes_NVA";
            textBoxRes_NVA.ReadOnly = true;
            textBoxRes_NVA.ScrollBars = ScrollBars.Vertical;
            textBoxRes_NVA.Size = new Size(251, 414);
            textBoxRes_NVA.TabIndex = 0;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1026, 600);
            Controls.Add(groupBoxRes_NVA);
            Controls.Add(buttonSave_NVA);
            Controls.Add(groupBoxTask_NVA);
            Controls.Add(groupBoxData_NVA);
            Controls.Add(buttonHelp_NVA);
            Controls.Add(buttonDone_NVA);
            Controls.Add(chartFunction_NVA);
            Name = "FormMain";
            Text = "Спринт 6 | Таск 4 | Вариант 3 | Новикова В. А.";
            ((System.ComponentModel.ISupportInitialize)chartFunction_NVA).EndInit();
            groupBoxData_NVA.ResumeLayout(false);
            groupBoxData_NVA.PerformLayout();
            groupBoxTask_NVA.ResumeLayout(false);
            groupBoxTask_NVA.PerformLayout();
            groupBoxRes_NVA.ResumeLayout(false);
            groupBoxRes_NVA.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction_NVA;
        private Button buttonDone_NVA;
        private Button buttonHelp_NVA;
        private GroupBox groupBoxData_NVA;
        private TextBox textBoxEnd_NVA;
        private Label labelNamedTwo_NVA;
        private TextBox textBoxStart_NVA;
        private Label labelNamedOne_NVA;
        private GroupBox groupBoxTask_NVA;
        private TextBox textBoxUslovie_NVA;
        private Button buttonSave_NVA;
        private GroupBox groupBoxRes_NVA;
        private TextBox textBoxRes_NVA;
    }
}
