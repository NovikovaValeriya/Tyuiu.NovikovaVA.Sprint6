 using Tyuiu.NovikovaVA.Sprint6.Task1.V15.Lib;
namespace Tyuiu.NovikovaVA.Sprint6.Task1.V15
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        private void buttonDone_NVA_Click(object sender, EventArgs e)
        {
            try
            {
                int startStep = Convert.ToInt32(textBoxStart_NVA.Text);
                int stopStep = Convert.ToInt32(textBoxEnd_NVA.Text);

                string strLine;

                int len = ds.GetMassFunction(startStep, stopStep).Length;

                double[] valueArray = new double[len];

                valueArray = ds.GetMassFunction(startStep, stopStep);
                textBoxResult_NVA.Text = "";
                textBoxResult_NVA.AppendText("+----------+------------+" + Environment.NewLine);
                textBoxResult_NVA.AppendText("|    X     |     f(x)   |" + Environment.NewLine);
                textBoxResult_NVA.AppendText("+----------+------------+" + Environment.NewLine);

                for (int i = 0; i <= len - 1; i++)
                {
                    strLine = String.Format("|{0,5:d}     | {1,7:f2}    |", startStep, valueArray[i]);
                    textBoxResult_NVA.AppendText(strLine + Environment.NewLine);
                    startStep++;
                }
                textBoxResult_NVA.AppendText("+----------+------------+" + Environment.NewLine);
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void buttonHelp_NVA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 1 выполнил студент группы ИСТНб-24-1 Новикова Валерия Александровна", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

    }
}
