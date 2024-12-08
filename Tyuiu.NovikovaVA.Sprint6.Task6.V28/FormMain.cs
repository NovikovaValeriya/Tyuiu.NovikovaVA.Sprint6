using Tyuiu.NovikovaVA.Sprint6.Task6.V28.Lib;
namespace Tyuiu.NovikovaVA.Sprint6.Task6.V28
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        string openFilePath;
        DataService ds = new DataService();

        private void buttonOpenFile_NVA_Click(object sender, EventArgs e)
        {
            openFileDialog_NVA.ShowDialog();
            openFilePath = openFileDialog_NVA.FileName;
            textBoxRes_NVA.Text = File.ReadAllText(openFilePath);
            groupBoxRes_NVA.Text = groupBoxRes_NVA.Text + " " + openFileDialog_NVA.FileName;
            buttonDone_NVA.Enabled = true;
        }
        private void buttonDone_NVA_Click(object sender, EventArgs e)
        {
            string str = "";
            textBoxOutPut_NVA.Text = ds.CollectTextFromFile(str, openFilePath);
        }
        private void buttonHelp_NVA_Click(object sender, EventArgs e)
        {
            FormAbout_NVA formAbout = new FormAbout_NVA();
            formAbout.ShowDialog();
        }


    }
}
