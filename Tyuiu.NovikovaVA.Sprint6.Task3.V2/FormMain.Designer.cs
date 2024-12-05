namespace Tyuiu.NovikovaVA.Sprint6.Task3.V2
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
            groupBoxTask_NVA = new GroupBox();
            textBoxUslovie_NVA = new TextBox();
            groupBoxRes_NVA = new GroupBox();
            dataGridViewResult_NVA = new DataGridView();
            labelNamesThree_NVA = new Label();
            buttonDone_NVA = new Button();
            buttonHelp_NVA = new Button();
            groupBoxData_NVA = new GroupBox();
            dataGridViewNamedOne_NVA = new DataGridView();
            groupBoxTask_NVA.SuspendLayout();
            groupBoxRes_NVA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewResult_NVA).BeginInit();
            groupBoxData_NVA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewNamedOne_NVA).BeginInit();
            SuspendLayout();
            // 
            // groupBoxTask_NVA
            // 
            groupBoxTask_NVA.Controls.Add(textBoxUslovie_NVA);
            groupBoxTask_NVA.Location = new Point(12, 12);
            groupBoxTask_NVA.Name = "groupBoxTask_NVA";
            groupBoxTask_NVA.Size = new Size(339, 162);
            groupBoxTask_NVA.TabIndex = 3;
            groupBoxTask_NVA.TabStop = false;
            groupBoxTask_NVA.Text = "Условие";
            // 
            // textBoxUslovie_NVA
            // 
            textBoxUslovie_NVA.BackColor = SystemColors.Menu;
            textBoxUslovie_NVA.Location = new Point(8, 20);
            textBoxUslovie_NVA.Multiline = true;
            textBoxUslovie_NVA.Name = "textBoxUslovie_NVA";
            textBoxUslovie_NVA.ReadOnly = true;
            textBoxUslovie_NVA.Size = new Size(331, 136);
            textBoxUslovie_NVA.TabIndex = 0;
            textBoxUslovie_NVA.Text = "Дан массив 5 на 5 элементов. Заменить четные значения в первой строке на 0.\r\n\r\n-12  -4 -20   5  -5\r\n   2  15   1 -20   7\r\n  15 -15   2  11   5\r\n -19  -9  16   0   1\r\n  17  16   5  12  -8";
            // 
            // groupBoxRes_NVA
            // 
            groupBoxRes_NVA.Controls.Add(dataGridViewResult_NVA);
            groupBoxRes_NVA.Controls.Add(labelNamesThree_NVA);
            groupBoxRes_NVA.Location = new Point(487, 23);
            groupBoxRes_NVA.Name = "groupBoxRes_NVA";
            groupBoxRes_NVA.Size = new Size(225, 295);
            groupBoxRes_NVA.TabIndex = 5;
            groupBoxRes_NVA.TabStop = false;
            groupBoxRes_NVA.Text = "Вывод данных:";
            // 
            // dataGridViewResult_NVA
            // 
            dataGridViewResult_NVA.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewResult_NVA.Location = new Point(20, 46);
            dataGridViewResult_NVA.Name = "dataGridViewResult_NVA";
            dataGridViewResult_NVA.ReadOnly = true;
            dataGridViewResult_NVA.RowHeadersVisible = false;
            dataGridViewResult_NVA.Size = new Size(180, 199);
            dataGridViewResult_NVA.TabIndex = 2;
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
            // buttonDone_NVA
            // 
            buttonDone_NVA.BackColor = Color.Lime;
            buttonDone_NVA.Location = new Point(542, 369);
            buttonDone_NVA.Name = "buttonDone_NVA";
            buttonDone_NVA.Size = new Size(90, 46);
            buttonDone_NVA.TabIndex = 8;
            buttonDone_NVA.Text = "Выполнить";
            buttonDone_NVA.UseVisualStyleBackColor = false;
            buttonDone_NVA.Click += buttonDone_Click;
            // 
            // buttonHelp_NVA
            // 
            buttonHelp_NVA.BackColor = Color.FromArgb(255, 224, 192);
            buttonHelp_NVA.Location = new Point(437, 371);
            buttonHelp_NVA.Name = "buttonHelp_NVA";
            buttonHelp_NVA.Size = new Size(84, 44);
            buttonHelp_NVA.TabIndex = 9;
            buttonHelp_NVA.Text = "Справка";
            buttonHelp_NVA.UseVisualStyleBackColor = false;
            buttonHelp_NVA.Click += buttonHelp_NVA_Click;
            // 
            // groupBoxData_NVA
            // 
            groupBoxData_NVA.Controls.Add(dataGridViewNamedOne_NVA);
            groupBoxData_NVA.Location = new Point(45, 199);
            groupBoxData_NVA.Name = "groupBoxData_NVA";
            groupBoxData_NVA.Size = new Size(252, 239);
            groupBoxData_NVA.TabIndex = 10;
            groupBoxData_NVA.TabStop = false;
            groupBoxData_NVA.Text = "Ввод данных";
            // 
            // dataGridViewNamedOne_NVA
            // 
            dataGridViewNamedOne_NVA.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewNamedOne_NVA.Location = new Point(28, 34);
            dataGridViewNamedOne_NVA.Name = "dataGridViewNamedOne_NVA";
            dataGridViewNamedOne_NVA.ReadOnly = true;
            dataGridViewNamedOne_NVA.RowHeadersVisible = false;
            dataGridViewNamedOne_NVA.Size = new Size(180, 199);
            dataGridViewNamedOne_NVA.TabIndex = 3;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(764, 450);
            Controls.Add(groupBoxData_NVA);
            Controls.Add(buttonHelp_NVA);
            Controls.Add(buttonDone_NVA);
            Controls.Add(groupBoxRes_NVA);
            Controls.Add(groupBoxTask_NVA);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 3 | Вариант 2 | Новикова В. А.";
            Load += FormMain_Load;
            groupBoxTask_NVA.ResumeLayout(false);
            groupBoxTask_NVA.PerformLayout();
            groupBoxRes_NVA.ResumeLayout(false);
            groupBoxRes_NVA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewResult_NVA).EndInit();
            groupBoxData_NVA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewNamedOne_NVA).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxTask_NVA;
        private TextBox textBoxUslovie_NVA;
        private GroupBox groupBoxRes_NVA;
        private DataGridView dataGridViewResult_NVA;
        private Label labelNamesThree_NVA;
        private Button buttonDone_NVA;
        private Button buttonHelp_NVA;
        private GroupBox groupBoxData_NVA;
        private DataGridView dataGridViewNamedOne_NVA;
    }
}
