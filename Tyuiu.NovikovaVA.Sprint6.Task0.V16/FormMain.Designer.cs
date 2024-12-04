
namespace Tyuiu.NovikovaVA.Sprint6.Task0.V16
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            pictureBoxFormula_NVA = new PictureBox();
            buttonDone_NVA = new Button();
            groupBoxData_NVA = new GroupBox();
            labelNamedOne_NVA = new Label();
            textBoxNamedTwo_NVA = new TextBox();
            groupBoxConclusion_NVA = new GroupBox();
            labelNamedTwo_NVA = new Label();
            textBoxResult_NVA = new TextBox();
            textBoxNamedOne_NVA = new TextBox();
            labelNamedThree_NVA = new Label();
            buttonHelp_NVA = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFormula_NVA).BeginInit();
            groupBoxData_NVA.SuspendLayout();
            groupBoxConclusion_NVA.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBoxFormula_NVA
            // 
            pictureBoxFormula_NVA.ErrorImage = null;
            pictureBoxFormula_NVA.Image = (Image)resources.GetObject("pictureBoxFormula_NVA.Image");
            pictureBoxFormula_NVA.InitialImage = null;
            pictureBoxFormula_NVA.Location = new Point(573, 61);
            pictureBoxFormula_NVA.Name = "pictureBoxFormula_NVA";
            pictureBoxFormula_NVA.Size = new Size(119, 74);
            pictureBoxFormula_NVA.TabIndex = 1;
            pictureBoxFormula_NVA.TabStop = false;
            // 
            // buttonDone_NVA
            // 
            buttonDone_NVA.Location = new Point(617, 390);
            buttonDone_NVA.Name = "buttonDone_NVA";
            buttonDone_NVA.Size = new Size(109, 37);
            buttonDone_NVA.TabIndex = 4;
            buttonDone_NVA.Text = "Выполнить";
            buttonDone_NVA.UseVisualStyleBackColor = true;
            buttonDone_NVA.Click += buttonDone_NVA_Click;
            buttonDone_NVA.KeyPress += textBoxNamedTwo_NVA_KeyPress;
            // 
            // groupBoxData_NVA
            // 
            groupBoxData_NVA.Controls.Add(labelNamedOne_NVA);
            groupBoxData_NVA.Controls.Add(textBoxNamedTwo_NVA);
            groupBoxData_NVA.Location = new Point(57, 258);
            groupBoxData_NVA.Name = "groupBoxData_NVA";
            groupBoxData_NVA.Size = new Size(267, 124);
            groupBoxData_NVA.TabIndex = 6;
            groupBoxData_NVA.TabStop = false;
            groupBoxData_NVA.Text = "Ввод данных";
            // 
            // labelNamedOne_NVA
            // 
            labelNamedOne_NVA.AutoSize = true;
            labelNamedOne_NVA.Location = new Point(55, 29);
            labelNamedOne_NVA.Name = "labelNamedOne_NVA";
            labelNamedOne_NVA.Size = new Size(89, 15);
            labelNamedOne_NVA.TabIndex = 3;
            labelNamedOne_NVA.Text = "Переменная X:";
            // 
            // textBoxNamedTwo_NVA
            // 
            textBoxNamedTwo_NVA.Location = new Point(55, 56);
            textBoxNamedTwo_NVA.Name = "textBoxNamedTwo_NVA";
            textBoxNamedTwo_NVA.Size = new Size(100, 23);
            textBoxNamedTwo_NVA.TabIndex = 2;
            // 
            // groupBoxConclusion_NVA
            // 
            groupBoxConclusion_NVA.Controls.Add(labelNamedTwo_NVA);
            groupBoxConclusion_NVA.Controls.Add(textBoxResult_NVA);
            groupBoxConclusion_NVA.Location = new Point(500, 267);
            groupBoxConclusion_NVA.Name = "groupBoxConclusion_NVA";
            groupBoxConclusion_NVA.Size = new Size(209, 115);
            groupBoxConclusion_NVA.TabIndex = 7;
            groupBoxConclusion_NVA.TabStop = false;
            groupBoxConclusion_NVA.Text = "Вывод данных";
            // 
            // labelNamedTwo_NVA
            // 
            labelNamedTwo_NVA.Location = new Point(32, 20);
            labelNamedTwo_NVA.Name = "labelNamedTwo_NVA";
            labelNamedTwo_NVA.Size = new Size(97, 16);
            labelNamedTwo_NVA.TabIndex = 0;
            labelNamedTwo_NVA.Text = "Результат";
            // 
            // textBoxResult_NVA
            // 
            textBoxResult_NVA.Location = new Point(32, 47);
            textBoxResult_NVA.Name = "textBoxResult_NVA";
            textBoxResult_NVA.ReadOnly = true;
            textBoxResult_NVA.Size = new Size(100, 23);
            textBoxResult_NVA.TabIndex = 0;
            textBoxResult_NVA.TextChanged += buttonDone_NVA_Click;
            // 
            // textBoxNamedOne_NVA
            // 
            textBoxNamedOne_NVA.BackColor = SystemColors.Menu;
            textBoxNamedOne_NVA.Location = new Point(57, 47);
            textBoxNamedOne_NVA.Multiline = true;
            textBoxNamedOne_NVA.Name = "textBoxNamedOne_NVA";
            textBoxNamedOne_NVA.Size = new Size(390, 186);
            textBoxNamedOne_NVA.TabIndex = 0;
            textBoxNamedOne_NVA.Text = "Вычислить выражение по формуле";
            // 
            // labelNamedThree_NVA
            // 
            labelNamedThree_NVA.AutoSize = true;
            labelNamedThree_NVA.Location = new Point(57, 29);
            labelNamedThree_NVA.Name = "labelNamedThree_NVA";
            labelNamedThree_NVA.Size = new Size(53, 15);
            labelNamedThree_NVA.TabIndex = 8;
            labelNamedThree_NVA.Text = "Условие";
            // 
            // buttonHelp_NVA
            // 
            buttonHelp_NVA.FlatStyle = FlatStyle.Flat;
            buttonHelp_NVA.Location = new Point(573, 390);
            buttonHelp_NVA.Name = "buttonHelp_NVA";
            buttonHelp_NVA.Size = new Size(35, 37);
            buttonHelp_NVA.TabIndex = 9;
            buttonHelp_NVA.Text = "?";
            buttonHelp_NVA.UseVisualStyleBackColor = true;
            buttonHelp_NVA.Click += buttonHelp_NVA_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonHelp_NVA);
            Controls.Add(labelNamedThree_NVA);
            Controls.Add(textBoxNamedOne_NVA);
            Controls.Add(groupBoxConclusion_NVA);
            Controls.Add(pictureBoxFormula_NVA);
            Controls.Add(groupBoxData_NVA);
            Controls.Add(buttonDone_NVA);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 0 | Вариант 16 | Новикова В. А.";
            ((System.ComponentModel.ISupportInitialize)pictureBoxFormula_NVA).EndInit();
            groupBoxData_NVA.ResumeLayout(false);
            groupBoxData_NVA.PerformLayout();
            groupBoxConclusion_NVA.ResumeLayout(false);
            groupBoxConclusion_NVA.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBoxFormula_NVA;
        private Button buttonDone_NVA;
        private GroupBox groupBoxData_NVA;
        private GroupBox groupBoxConclusion_NVA;
        private TextBox textBoxResult_NVA;
        private TextBox textBoxNamedTwo_NVA;
        private Label labelNamedOne_NVA;
        private Label labelNamedTwo_NVA;
        private TextBox textBoxNamedOne_NVA;
        private Label labelNamedThree_NVA;
        private Button buttonHelp_NVA;
    }
}
