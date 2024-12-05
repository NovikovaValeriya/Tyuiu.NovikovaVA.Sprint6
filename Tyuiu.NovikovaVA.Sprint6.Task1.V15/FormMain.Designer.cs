namespace Tyuiu.NovikovaVA.Sprint6.Task1.V15
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
            textBoxUslovie_NVA = new TextBox();
            groupBoxTask_NVA = new GroupBox();
            groupBoxData_NVA = new GroupBox();
            textBoxEnd_NVA = new TextBox();
            labelNamedTwo_NVA = new Label();
            textBoxStart_NVA = new TextBox();
            labelNamedOne_NVA = new Label();
            groupBoxRes_NVA = new GroupBox();
            labelNamesThree_NVA = new Label();
            textBoxResult_NVA = new TextBox();
            buttonDone_NVA = new Button();
            buttonHelp_NVA = new Button();
            groupBoxTask_NVA.SuspendLayout();
            groupBoxData_NVA.SuspendLayout();
            groupBoxRes_NVA.SuspendLayout();
            SuspendLayout();
            // 
            // textBoxUslovie_NVA
            // 
            textBoxUslovie_NVA.BackColor = SystemColors.Menu;
            textBoxUslovie_NVA.Location = new Point(11, 25);
            textBoxUslovie_NVA.Multiline = true;
            textBoxUslovie_NVA.Name = "textBoxUslovie_NVA";
            textBoxUslovie_NVA.ReadOnly = true;
            textBoxUslovie_NVA.Size = new Size(386, 224);
            textBoxUslovie_NVA.TabIndex = 0;
            textBoxUslovie_NVA.Text = "Протабулировать функцию на заданном диапазоне.\r\nРезультат выести в виде таблицы.";
            // 
            // groupBoxTask_NVA
            // 
            groupBoxTask_NVA.Controls.Add(textBoxUslovie_NVA);
            groupBoxTask_NVA.Location = new Point(49, 24);
            groupBoxTask_NVA.Name = "groupBoxTask_NVA";
            groupBoxTask_NVA.Size = new Size(439, 266);
            groupBoxTask_NVA.TabIndex = 1;
            groupBoxTask_NVA.TabStop = false;
            groupBoxTask_NVA.Text = "Условие";
            // 
            // groupBoxData_NVA
            // 
            groupBoxData_NVA.Controls.Add(textBoxEnd_NVA);
            groupBoxData_NVA.Controls.Add(labelNamedTwo_NVA);
            groupBoxData_NVA.Controls.Add(textBoxStart_NVA);
            groupBoxData_NVA.Controls.Add(labelNamedOne_NVA);
            groupBoxData_NVA.Location = new Point(49, 309);
            groupBoxData_NVA.Name = "groupBoxData_NVA";
            groupBoxData_NVA.Size = new Size(307, 99);
            groupBoxData_NVA.TabIndex = 2;
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
            groupBoxRes_NVA.Controls.Add(labelNamesThree_NVA);
            groupBoxRes_NVA.Controls.Add(textBoxResult_NVA);
            groupBoxRes_NVA.Location = new Point(540, 24);
            groupBoxRes_NVA.Name = "groupBoxRes_NVA";
            groupBoxRes_NVA.Size = new Size(248, 414);
            groupBoxRes_NVA.TabIndex = 3;
            groupBoxRes_NVA.TabStop = false;
            groupBoxRes_NVA.Text = "Вывод данных:";
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
            // textBoxResult_NVA
            // 
            textBoxResult_NVA.BackColor = SystemColors.Menu;
            textBoxResult_NVA.Font = new Font("Consolas", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxResult_NVA.Location = new Point(6, 46);
            textBoxResult_NVA.Multiline = true;
            textBoxResult_NVA.Name = "textBoxResult_NVA";
            textBoxResult_NVA.ReadOnly = true;
            textBoxResult_NVA.ScrollBars = ScrollBars.Vertical;
            textBoxResult_NVA.Size = new Size(236, 357);
            textBoxResult_NVA.TabIndex = 0;
            // 
            // buttonDone_NVA
            // 
            buttonDone_NVA.BackColor = Color.Lime;
            buttonDone_NVA.Location = new Point(442, 350);
            buttonDone_NVA.Name = "buttonDone_NVA";
            buttonDone_NVA.Size = new Size(92, 58);
            buttonDone_NVA.TabIndex = 4;
            buttonDone_NVA.Text = "Выполнить";
            buttonDone_NVA.UseVisualStyleBackColor = false;
            buttonDone_NVA.Click += buttonDone_NVA_Click;
            // 
            // buttonHelp_NVA
            // 
            buttonHelp_NVA.BackColor = SystemColors.HotTrack;
            buttonHelp_NVA.Location = new Point(362, 352);
            buttonHelp_NVA.Name = "buttonHelp_NVA";
            buttonHelp_NVA.Size = new Size(84, 56);
            buttonHelp_NVA.TabIndex = 5;
            buttonHelp_NVA.Text = "Справка";
            buttonHelp_NVA.UseVisualStyleBackColor = false;
            buttonHelp_NVA.Click += buttonHelp_NVA_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonHelp_NVA);
            Controls.Add(buttonDone_NVA);
            Controls.Add(groupBoxRes_NVA);
            Controls.Add(groupBoxData_NVA);
            Controls.Add(groupBoxTask_NVA);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 1 | Вариант 15 | Новикова В. А.";
            groupBoxTask_NVA.ResumeLayout(false);
            groupBoxTask_NVA.PerformLayout();
            groupBoxData_NVA.ResumeLayout(false);
            groupBoxData_NVA.PerformLayout();
            groupBoxRes_NVA.ResumeLayout(false);
            groupBoxRes_NVA.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox textBoxUslovie_NVA;
        private GroupBox groupBoxTask_NVA;
        private GroupBox groupBoxData_NVA;
        private Label labelNamedOne_NVA;
        private TextBox textBoxEnd_NVA;
        private Label labelNamedTwo_NVA;
        private TextBox textBoxStart_NVA;
        private GroupBox groupBoxRes_NVA;
        private Label labelNamesThree_NVA;
        private TextBox textBoxResult_NVA;
        private Button buttonDone_NVA;
        private Button buttonHelp_NVA;
    }
}
