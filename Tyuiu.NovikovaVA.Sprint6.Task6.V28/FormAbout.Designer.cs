namespace Tyuiu.NovikovaVA.Sprint6.Task6.V28
{
    partial class FormAbout_NVA
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pictureBoxAva_NVA = new PictureBox();
            buttonOK_NVA = new Button();
            labelInfo_NVA = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBoxAva_NVA).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxAva_NVA
            // 
            pictureBoxAva_NVA.Image = Properties.Resources.IMG_0310;
            pictureBoxAva_NVA.InitialImage = Properties.Resources.IMG_0310;
            pictureBoxAva_NVA.Location = new Point(12, 29);
            pictureBoxAva_NVA.Name = "pictureBoxAva_NVA";
            pictureBoxAva_NVA.Size = new Size(175, 241);
            pictureBoxAva_NVA.TabIndex = 0;
            pictureBoxAva_NVA.TabStop = false;
            // 
            // buttonOK_NVA
            // 
            buttonOK_NVA.Location = new Point(461, 237);
            buttonOK_NVA.Name = "buttonOK_NVA";
            buttonOK_NVA.Size = new Size(75, 23);
            buttonOK_NVA.TabIndex = 1;
            buttonOK_NVA.Text = "Ok";
            buttonOK_NVA.UseVisualStyleBackColor = true;
            buttonOK_NVA.Click += buttonOk_NVA_Click;
            // 
            // labelInfo_NVA
            // 
            labelInfo_NVA.AutoSize = true;
            labelInfo_NVA.Location = new Point(279, 55);
            labelInfo_NVA.Name = "labelInfo_NVA";
            labelInfo_NVA.Size = new Size(113, 45);
            labelInfo_NVA.TabIndex = 2;
            labelInfo_NVA.Text = "Разработчик:\r\nНовикова Валерия \r\nИСТНб-24-1\r\n";
            // 
            // FormAbout_NVA
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(608, 282);
            Controls.Add(labelInfo_NVA);
            Controls.Add(buttonOK_NVA);
            Controls.Add(pictureBoxAva_NVA);
            Name = "FormAbout_NVA";
            Text = "О программе";
            ((System.ComponentModel.ISupportInitialize)pictureBoxAva_NVA).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBoxAva_NVA;
        private Button buttonOK_NVA;
        private Label labelInfo_NVA;
    }
}