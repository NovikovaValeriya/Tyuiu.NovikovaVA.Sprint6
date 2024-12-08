namespace Tyuiu.NovikovaVA.Sprint6.Task6.V28
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            groupBoxIn_NVA = new GroupBox();
            textBoxIn_NVA = new TextBox();
            groupBoxOutPut_NVA = new GroupBox();
            textBoxOutPut_NVA = new TextBox();
            groupBoxTask_NVA = new GroupBox();
            textBoxUslovie_NVA = new TextBox();
            buttonOpenFile_NVA = new Button();
            buttonDone_NVA = new Button();
            openFileDialog_NVA = new OpenFileDialog();
            toolTipOne_NVA = new ToolTip(components);
            buttonHelp_NVA = new Button();
            panelKnopki_NVA = new Panel();
            panelTask_NVA = new Panel();
            panelOut_NVA = new Panel();
            splitter1_NVA = new Splitter();
            panelIn_NVA = new Panel();
            groupBoxIn_NVA.SuspendLayout();
            groupBoxOutPut_NVA.SuspendLayout();
            groupBoxTask_NVA.SuspendLayout();
            panelKnopki_NVA.SuspendLayout();
            panelTask_NVA.SuspendLayout();
            panelOut_NVA.SuspendLayout();
            panelIn_NVA.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxIn_NVA
            // 
            groupBoxIn_NVA.Controls.Add(textBoxIn_NVA);
            groupBoxIn_NVA.Location = new Point(10, 13);
            groupBoxIn_NVA.Name = "groupBoxIn_NVA";
            groupBoxIn_NVA.Size = new Size(491, 362);
            groupBoxIn_NVA.TabIndex = 15;
            groupBoxIn_NVA.TabStop = false;
            groupBoxIn_NVA.Text = "Ввод :";
            // 
            // textBoxIn_NVA
            // 
            textBoxIn_NVA.BackColor = SystemColors.ButtonHighlight;
            textBoxIn_NVA.Font = new Font("Consolas", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxIn_NVA.Location = new Point(6, 35);
            textBoxIn_NVA.Multiline = true;
            textBoxIn_NVA.Name = "textBoxIn_NVA";
            textBoxIn_NVA.ReadOnly = true;
            textBoxIn_NVA.ScrollBars = ScrollBars.Vertical;
            textBoxIn_NVA.Size = new Size(479, 327);
            textBoxIn_NVA.TabIndex = 0;
            // 
            // groupBoxOutPut_NVA
            // 
            groupBoxOutPut_NVA.Controls.Add(textBoxOutPut_NVA);
            groupBoxOutPut_NVA.Location = new Point(3, 11);
            groupBoxOutPut_NVA.Name = "groupBoxOutPut_NVA";
            groupBoxOutPut_NVA.Size = new Size(519, 362);
            groupBoxOutPut_NVA.TabIndex = 16;
            groupBoxOutPut_NVA.TabStop = false;
            groupBoxOutPut_NVA.Text = "Вывод :";
            // 
            // textBoxOutPut_NVA
            // 
            textBoxOutPut_NVA.BackColor = SystemColors.ButtonHighlight;
            textBoxOutPut_NVA.Font = new Font("Consolas", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxOutPut_NVA.Location = new Point(21, 29);
            textBoxOutPut_NVA.Multiline = true;
            textBoxOutPut_NVA.Name = "textBoxOutPut_NVA";
            textBoxOutPut_NVA.ReadOnly = true;
            textBoxOutPut_NVA.ScrollBars = ScrollBars.Vertical;
            textBoxOutPut_NVA.Size = new Size(507, 327);
            textBoxOutPut_NVA.TabIndex = 0;
            // 
            // groupBoxTask_NVA
            // 
            groupBoxTask_NVA.Controls.Add(textBoxUslovie_NVA);
            groupBoxTask_NVA.Location = new Point(10, 7);
            groupBoxTask_NVA.Name = "groupBoxTask_NVA";
            groupBoxTask_NVA.Size = new Size(1037, 84);
            groupBoxTask_NVA.TabIndex = 17;
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
            textBoxUslovie_NVA.Size = new Size(967, 44);
            textBoxUslovie_NVA.TabIndex = 0;
            textBoxUslovie_NVA.Text = resources.GetString("textBoxUslovie_NVA.Text");
            // 
            // buttonOpenFile_NVA
            // 
            buttonOpenFile_NVA.Image = Properties.Resources.seo_social_web_network_internet_25_icon_icons_com_61513;
            buttonOpenFile_NVA.Location = new Point(6, 23);
            buttonOpenFile_NVA.Name = "buttonOpenFile_NVA";
            buttonOpenFile_NVA.Size = new Size(94, 87);
            buttonOpenFile_NVA.TabIndex = 18;
            toolTipOne_NVA.SetToolTip(buttonOpenFile_NVA, "\r\nоткрыть файл\r\nвыберите нужный файл для обработки");
            buttonOpenFile_NVA.UseVisualStyleBackColor = true;
            buttonOpenFile_NVA.Click += buttonOpenFile_NVA_Click;
            // 
            // buttonDone_NVA
            // 
            buttonDone_NVA.Image = (Image)resources.GetObject("buttonDone_NVA.Image");
            buttonDone_NVA.Location = new Point(122, 13);
            buttonDone_NVA.Name = "buttonDone_NVA";
            buttonDone_NVA.Size = new Size(192, 97);
            buttonDone_NVA.TabIndex = 19;
            toolTipOne_NVA.SetToolTip(buttonDone_NVA, "\r\nВывести предпоследнее слово каждой строки в результирующею строку и вывести ее в textBoxOut.\r\n");
            buttonDone_NVA.UseVisualStyleBackColor = true;
            buttonDone_NVA.Click += buttonDone_NVA_Click;
            // 
            // openFileDialog_NVA
            // 
            openFileDialog_NVA.FileName = "openFileDialog_NVA";
            // 
            // toolTipOne_NVA
            // 
            toolTipOne_NVA.ToolTipIcon = ToolTipIcon.Info;
            toolTipOne_NVA.ToolTipTitle = "Подсказка";
            // 
            // buttonHelp_NVA
            // 
            buttonHelp_NVA.BackColor = SystemColors.ControlLight;
            buttonHelp_NVA.Image = Properties.Resources.a09224106d6369ee30bdd8a93ac78a18f1611c9d_medium;
            buttonHelp_NVA.Location = new Point(857, 35);
            buttonHelp_NVA.Name = "buttonHelp_NVA";
            buttonHelp_NVA.Size = new Size(95, 83);
            buttonHelp_NVA.TabIndex = 20;
            buttonHelp_NVA.TextAlign = ContentAlignment.MiddleRight;
            toolTipOne_NVA.SetToolTip(buttonHelp_NVA, "Сведения о программе");
            buttonHelp_NVA.UseVisualStyleBackColor = false;
            buttonHelp_NVA.Click += buttonHelp_NVA_Click;
            // 
            // panelKnopki_NVA
            // 
            panelKnopki_NVA.Controls.Add(buttonHelp_NVA);
            panelKnopki_NVA.Controls.Add(buttonDone_NVA);
            panelKnopki_NVA.Controls.Add(buttonOpenFile_NVA);
            panelKnopki_NVA.Location = new Point(17, 9);
            panelKnopki_NVA.Name = "panelKnopki_NVA";
            panelKnopki_NVA.Size = new Size(1020, 127);
            panelKnopki_NVA.TabIndex = 21;
            // 
            // panelTask_NVA
            // 
            panelTask_NVA.Controls.Add(groupBoxTask_NVA);
            panelTask_NVA.Location = new Point(2, 142);
            panelTask_NVA.Name = "panelTask_NVA";
            panelTask_NVA.Size = new Size(1056, 94);
            panelTask_NVA.TabIndex = 22;
            // 
            // panelOut_NVA
            // 
            panelOut_NVA.Controls.Add(splitter1_NVA);
            panelOut_NVA.Controls.Add(groupBoxIn_NVA);
            panelOut_NVA.Location = new Point(2, 240);
            panelOut_NVA.Name = "panelOut_NVA";
            panelOut_NVA.Size = new Size(519, 353);
            panelOut_NVA.TabIndex = 23;
            // 
            // splitter1_NVA
            // 
            splitter1_NVA.Location = new Point(0, 0);
            splitter1_NVA.Name = "splitter1_NVA";
            splitter1_NVA.Size = new Size(3, 353);
            splitter1_NVA.TabIndex = 16;
            splitter1_NVA.TabStop = false;
            // 
            // panelIn_NVA
            // 
            panelIn_NVA.Controls.Add(groupBoxOutPut_NVA);
            panelIn_NVA.Location = new Point(527, 242);
            panelIn_NVA.Name = "panelIn_NVA";
            panelIn_NVA.Size = new Size(531, 351);
            panelIn_NVA.TabIndex = 24;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1063, 608);
            Controls.Add(panelIn_NVA);
            Controls.Add(panelOut_NVA);
            Controls.Add(panelTask_NVA);
            Controls.Add(panelKnopki_NVA);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 6 | Вариант 28 | Новикова В. А.";
            groupBoxIn_NVA.ResumeLayout(false);
            groupBoxIn_NVA.PerformLayout();
            groupBoxOutPut_NVA.ResumeLayout(false);
            groupBoxOutPut_NVA.PerformLayout();
            groupBoxTask_NVA.ResumeLayout(false);
            groupBoxTask_NVA.PerformLayout();
            panelKnopki_NVA.ResumeLayout(false);
            panelTask_NVA.ResumeLayout(false);
            panelOut_NVA.ResumeLayout(false);
            panelIn_NVA.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxIn_NVA;
        private TextBox textBoxIn_NVA;
        private GroupBox groupBoxOutPut_NVA;
        private TextBox textBoxOutPut_NVA;
        private GroupBox groupBoxTask_NVA;
        private TextBox textBoxUslovie_NVA;
        private Button buttonOpenFile_NVA;
        private Button buttonDone_NVA;
        private OpenFileDialog openFileDialog_NVA;
        private ToolTip toolTipOne_NVA;
        private Button buttonHelp_NVA;
        private Panel panelKnopki_NVA;
        private Panel panelTask_NVA;
        private Panel panelOut_NVA;
        private Panel panelIn_NVA;
        private Splitter splitter1_NVA;
    }
}
