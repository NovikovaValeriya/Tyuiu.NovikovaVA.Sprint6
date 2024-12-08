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
            groupBoxRes_NVA = new GroupBox();
            textBoxRes_NVA = new TextBox();
            groupBoxOutPut_NVA = new GroupBox();
            textBoxOutPut_NVA = new TextBox();
            groupBoxTask_NVA = new GroupBox();
            textBoxUslovie_NVA = new TextBox();
            buttonOpenFile_NVA = new Button();
            buttonDone_NVA = new Button();
            openFileDialog_NVA = new OpenFileDialog();
            toolTipOne_NVA = new ToolTip(components);
            buttonHelp_NVA = new Button();
            groupBoxRes_NVA.SuspendLayout();
            groupBoxOutPut_NVA.SuspendLayout();
            groupBoxTask_NVA.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxRes_NVA
            // 
            groupBoxRes_NVA.Controls.Add(textBoxRes_NVA);
            groupBoxRes_NVA.Location = new Point(23, 240);
            groupBoxRes_NVA.Name = "groupBoxRes_NVA";
            groupBoxRes_NVA.Size = new Size(491, 362);
            groupBoxRes_NVA.TabIndex = 15;
            groupBoxRes_NVA.TabStop = false;
            groupBoxRes_NVA.Text = "Ввод :";
            // 
            // textBoxRes_NVA
            // 
            textBoxRes_NVA.BackColor = SystemColors.ButtonHighlight;
            textBoxRes_NVA.Font = new Font("Consolas", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxRes_NVA.Location = new Point(6, 35);
            textBoxRes_NVA.Multiline = true;
            textBoxRes_NVA.Name = "textBoxRes_NVA";
            textBoxRes_NVA.ReadOnly = true;
            textBoxRes_NVA.ScrollBars = ScrollBars.Vertical;
            textBoxRes_NVA.Size = new Size(479, 327);
            textBoxRes_NVA.TabIndex = 0;
            // 
            // groupBoxOutPut_NVA
            // 
            groupBoxOutPut_NVA.Controls.Add(textBoxOutPut_NVA);
            groupBoxOutPut_NVA.Location = new Point(533, 240);
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
            textBoxOutPut_NVA.Location = new Point(6, 35);
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
            groupBoxTask_NVA.Location = new Point(12, 149);
            groupBoxTask_NVA.Name = "groupBoxTask_NVA";
            groupBoxTask_NVA.Size = new Size(1033, 72);
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
            textBoxUslovie_NVA.Size = new Size(972, 63);
            textBoxUslovie_NVA.TabIndex = 0;
            textBoxUslovie_NVA.Text = resources.GetString("textBoxUslovie_NVA.Text");
            // 
            // buttonOpenFile_NVA
            // 
            buttonOpenFile_NVA.Image = Properties.Resources.seo_social_web_network_internet_25_icon_icons_com_61513;
            buttonOpenFile_NVA.Location = new Point(23, 32);
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
            buttonDone_NVA.ImageAlign = ContentAlignment.BottomLeft;
            buttonDone_NVA.Location = new Point(139, 12);
            buttonDone_NVA.Name = "buttonDone_NVA";
            buttonDone_NVA.Size = new Size(188, 107);
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
            buttonHelp_NVA.Location = new Point(874, 44);
            buttonHelp_NVA.Name = "buttonHelp_NVA";
            buttonHelp_NVA.Size = new Size(95, 83);
            buttonHelp_NVA.TabIndex = 20;
            buttonHelp_NVA.TextAlign = ContentAlignment.MiddleRight;
            toolTipOne_NVA.SetToolTip(buttonHelp_NVA, "Сведения о программе");
            buttonHelp_NVA.UseVisualStyleBackColor = false;
            buttonHelp_NVA.Click += buttonHelp_NVA_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1063, 608);
            Controls.Add(buttonHelp_NVA);
            Controls.Add(groupBoxOutPut_NVA);
            Controls.Add(buttonDone_NVA);
            Controls.Add(buttonOpenFile_NVA);
            Controls.Add(groupBoxTask_NVA);
            Controls.Add(groupBoxRes_NVA);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 6 | Вариант 28 | Новикова В. А.";
            groupBoxRes_NVA.ResumeLayout(false);
            groupBoxRes_NVA.PerformLayout();
            groupBoxOutPut_NVA.ResumeLayout(false);
            groupBoxOutPut_NVA.PerformLayout();
            groupBoxTask_NVA.ResumeLayout(false);
            groupBoxTask_NVA.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxRes_NVA;
        private TextBox textBoxRes_NVA;
        private GroupBox groupBoxOutPut_NVA;
        private TextBox textBoxOutPut_NVA;
        private GroupBox groupBoxTask_NVA;
        private TextBox textBoxUslovie_NVA;
        private Button buttonOpenFile_NVA;
        private Button buttonDone_NVA;
        private OpenFileDialog openFileDialog_NVA;
        private ToolTip toolTipOne_NVA;
        private Button buttonHelp_NVA;
    }
}
