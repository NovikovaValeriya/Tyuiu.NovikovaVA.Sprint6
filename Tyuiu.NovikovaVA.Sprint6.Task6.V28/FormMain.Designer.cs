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
            groupBoxOut_NVA = new GroupBox();
            textBoxOut_NVA = new TextBox();
            groupBoxTask_NVA = new GroupBox();
            textBoxUslovie_NVA = new TextBox();
            buttonOpenFile_NVA = new Button();
            buttonGet_NVA = new Button();
            openFileDialog = new OpenFileDialog();
            toolTip_NVA = new ToolTip(components);
            buttonHelp_NVA = new Button();
            panelKnopki_NVA = new Panel();
            panelTask_NVA = new Panel();
            panelOut_NVA = new Panel();
            splitter1_NVA = new Splitter();
            panelIn_NVA = new Panel();
            groupBoxIn_NVA.SuspendLayout();
            groupBoxOut_NVA.SuspendLayout();
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
            groupBoxIn_NVA.Dock = DockStyle.Fill;
            groupBoxIn_NVA.Location = new Point(0, 0);
            groupBoxIn_NVA.Name = "groupBoxIn_NVA";
            groupBoxIn_NVA.Size = new Size(490, 398);
            groupBoxIn_NVA.TabIndex = 15;
            groupBoxIn_NVA.TabStop = false;
            groupBoxIn_NVA.Text = "Ввод :";
            // 
            // textBoxIn_NVA
            // 
            textBoxIn_NVA.BackColor = SystemColors.ButtonHighlight;
            textBoxIn_NVA.Dock = DockStyle.Fill;
            textBoxIn_NVA.Font = new Font("Consolas", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxIn_NVA.Location = new Point(3, 19);
            textBoxIn_NVA.Multiline = true;
            textBoxIn_NVA.Name = "textBoxIn_NVA";
            textBoxIn_NVA.ReadOnly = true;
            textBoxIn_NVA.ScrollBars = ScrollBars.Vertical;
            textBoxIn_NVA.Size = new Size(484, 376);
            textBoxIn_NVA.TabIndex = 0;
            // 
            // groupBoxOut_NVA
            // 
            groupBoxOut_NVA.Controls.Add(textBoxOut_NVA);
            groupBoxOut_NVA.Dock = DockStyle.Fill;
            groupBoxOut_NVA.Location = new Point(0, 0);
            groupBoxOut_NVA.Name = "groupBoxOut_NVA";
            groupBoxOut_NVA.Size = new Size(641, 395);
            groupBoxOut_NVA.TabIndex = 16;
            groupBoxOut_NVA.TabStop = false;
            groupBoxOut_NVA.Text = "Вывод :";
            // 
            // textBoxOut_NVA
            // 
            textBoxOut_NVA.BackColor = SystemColors.ButtonHighlight;
            textBoxOut_NVA.Dock = DockStyle.Fill;
            textBoxOut_NVA.Font = new Font("Consolas", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxOut_NVA.Location = new Point(3, 19);
            textBoxOut_NVA.Multiline = true;
            textBoxOut_NVA.Name = "textBoxOut_NVA";
            textBoxOut_NVA.ReadOnly = true;
            textBoxOut_NVA.ScrollBars = ScrollBars.Vertical;
            textBoxOut_NVA.Size = new Size(635, 373);
            textBoxOut_NVA.TabIndex = 0;
            // 
            // groupBoxTask_NVA
            // 
            groupBoxTask_NVA.Controls.Add(textBoxUslovie_NVA);
            groupBoxTask_NVA.Dock = DockStyle.Fill;
            groupBoxTask_NVA.Location = new Point(0, 0);
            groupBoxTask_NVA.Name = "groupBoxTask_NVA";
            groupBoxTask_NVA.Size = new Size(1113, 151);
            groupBoxTask_NVA.TabIndex = 17;
            groupBoxTask_NVA.TabStop = false;
            groupBoxTask_NVA.Text = "Условие";
            // 
            // textBoxUslovie_NVA
            // 
            textBoxUslovie_NVA.BackColor = SystemColors.Menu;
            textBoxUslovie_NVA.Dock = DockStyle.Fill;
            textBoxUslovie_NVA.Location = new Point(3, 19);
            textBoxUslovie_NVA.Multiline = true;
            textBoxUslovie_NVA.Name = "textBoxUslovie_NVA";
            textBoxUslovie_NVA.ReadOnly = true;
            textBoxUslovie_NVA.Size = new Size(1107, 129);
            textBoxUslovie_NVA.TabIndex = 0;
            textBoxUslovie_NVA.Text = resources.GetString("textBoxUslovie_NVA.Text");
            // 
            // buttonOpenFile_NVA
            // 
            buttonOpenFile_NVA.Image = Properties.Resources.seo_social_web_network_internet_25_icon_icons_com_61513;
            buttonOpenFile_NVA.Location = new Point(12, 25);
            buttonOpenFile_NVA.Name = "buttonOpenFile_NVA";
            buttonOpenFile_NVA.Size = new Size(94, 87);
            buttonOpenFile_NVA.TabIndex = 18;
            toolTip_NVA.SetToolTip(buttonOpenFile_NVA, "\r\nоткрыть файл\r\nвыберите нужный файл для обработки");
            buttonOpenFile_NVA.UseVisualStyleBackColor = true;
            buttonOpenFile_NVA.Click += buttonOpenFile_NVA_Click;
            // 
            // buttonGet_NVA
            // 
            buttonGet_NVA.Image = (Image)resources.GetObject("buttonGet_NVA.Image");
            buttonGet_NVA.Location = new Point(122, 12);
            buttonGet_NVA.Name = "buttonGet_NVA";
            buttonGet_NVA.Size = new Size(142, 98);
            buttonGet_NVA.TabIndex = 19;
            toolTip_NVA.SetToolTip(buttonGet_NVA, "\r\nВывести предпоследнее слово каждой строки в результирующею строку и вывести ее в textBoxOut.\r\n");
            buttonGet_NVA.UseVisualStyleBackColor = true;
            buttonGet_NVA.Click += buttonDone_NVA_Click;
            // 
            // openFileDialog
            // 
            openFileDialog.FileName = "openFileDialog_NVA";
            // 
            // toolTip_NVA
            // 
            toolTip_NVA.ToolTipIcon = ToolTipIcon.Info;
            toolTip_NVA.ToolTipTitle = "Подсказка";
            // 
            // buttonHelp_NVA
            // 
            buttonHelp_NVA.BackColor = SystemColors.ControlLight;
            buttonHelp_NVA.Image = Properties.Resources.a09224106d6369ee30bdd8a93ac78a18f1611c9d_medium;
            buttonHelp_NVA.Location = new Point(974, 20);
            buttonHelp_NVA.Name = "buttonHelp_NVA";
            buttonHelp_NVA.Size = new Size(95, 83);
            buttonHelp_NVA.TabIndex = 20;
            buttonHelp_NVA.TextAlign = ContentAlignment.MiddleRight;
            toolTip_NVA.SetToolTip(buttonHelp_NVA, "Сведения о программе");
            buttonHelp_NVA.UseVisualStyleBackColor = false;
            buttonHelp_NVA.Click += buttonHelp_NVA_Click;
            // 
            // panelKnopki_NVA
            // 
            panelKnopki_NVA.Controls.Add(buttonHelp_NVA);
            panelKnopki_NVA.Controls.Add(buttonGet_NVA);
            panelKnopki_NVA.Controls.Add(buttonOpenFile_NVA);
            panelKnopki_NVA.Dock = DockStyle.Top;
            panelKnopki_NVA.Location = new Point(0, 0);
            panelKnopki_NVA.Name = "panelKnopki_NVA";
            panelKnopki_NVA.Size = new Size(1220, 127);
            panelKnopki_NVA.TabIndex = 21;
            // 
            // panelTask_NVA
            // 
            panelTask_NVA.Controls.Add(groupBoxTask_NVA);
            panelTask_NVA.Location = new Point(12, 133);
            panelTask_NVA.Name = "panelTask_NVA";
            panelTask_NVA.Size = new Size(1113, 151);
            panelTask_NVA.TabIndex = 22;
            // 
            // panelOut_NVA
            // 
            panelOut_NVA.Controls.Add(splitter1_NVA);
            panelOut_NVA.Controls.Add(groupBoxIn_NVA);
            panelOut_NVA.Location = new Point(0, 287);
            panelOut_NVA.Name = "panelOut_NVA";
            panelOut_NVA.Size = new Size(490, 398);
            panelOut_NVA.TabIndex = 23;
            // 
            // splitter1_NVA
            // 
            splitter1_NVA.Location = new Point(0, 0);
            splitter1_NVA.Name = "splitter1_NVA";
            splitter1_NVA.Size = new Size(3, 398);
            splitter1_NVA.TabIndex = 16;
            splitter1_NVA.TabStop = false;
            // 
            // panelIn_NVA
            // 
            panelIn_NVA.Controls.Add(groupBoxOut_NVA);
            panelIn_NVA.Location = new Point(579, 290);
            panelIn_NVA.Name = "panelIn_NVA";
            panelIn_NVA.Size = new Size(641, 395);
            panelIn_NVA.TabIndex = 24;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1220, 645);
            Controls.Add(panelIn_NVA);
            Controls.Add(panelTask_NVA);
            Controls.Add(panelOut_NVA);
            Controls.Add(panelKnopki_NVA);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 6 | Вариант 28 | Новикова В. А.";
            groupBoxIn_NVA.ResumeLayout(false);
            groupBoxIn_NVA.PerformLayout();
            groupBoxOut_NVA.ResumeLayout(false);
            groupBoxOut_NVA.PerformLayout();
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
        private GroupBox groupBoxOut_NVA;
        private TextBox textBoxOut_NVA;
        private GroupBox groupBoxTask_NVA;
        private TextBox textBoxUslovie_NVA;
        private Button buttonOpenFile_NVA;
        private Button buttonGet_NVA;
        private OpenFileDialog openFileDialog;
        private ToolTip toolTip_NVA;
        private Button buttonHelp_NVA;
        private Panel panelKnopki_NVA;
        private Panel panelTask_NVA;
        private Panel panelOut_NVA;
        private Panel panelIn_NVA;
        private Splitter splitter1_NVA;
    }
}
