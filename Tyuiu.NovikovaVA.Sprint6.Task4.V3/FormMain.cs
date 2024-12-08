using Tyuiu.NovikovaVA.Sprint6.Task4.V3.Lib;
namespace Tyuiu.NovikovaVA.Sprint6.Task4.V3
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
                int startstep = Convert.ToInt32(textBoxStart_NVA.Text);
                int stopstep = Convert.ToInt32(textBoxEnd_NVA.Text);

                string strline;

                int len = ds.GetMassFunction(startstep, stopstep).Length;

                double[] valueArray;
                valueArray = new double[len];

                valueArray = ds.GetMassFunction(startstep, stopstep);
                this.chartFunction_NVA.ChartAreas[0].AxisX.Title = "Ось Х";
                this.chartFunction_NVA.ChartAreas[0].AxisY.Title = "Ось Y";

                textBoxRes_NVA.Text = "";
                chartFunction_NVA.Series[0].Points.Clear();

                for (int i = 0; i < len - 1; i++)
                {
                    this.chartFunction_NVA.Series[0].Points.AddXY(startstep, valueArray[i]);
                    textBoxRes_NVA.AppendText(valueArray[i] + Environment.NewLine);
                    startstep++;
                }

            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }
        private void buttonHelp_NVA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 4 выполнила студент группы ИСТНб-24-1 Новикова В. А.", "Справка", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void buttonSave_NVA_Click(object sender, EventArgs e)
        {
            try
            {
                string path = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask4V3.txt";
                File.WriteAllText(path, textBoxRes_NVA.Text);

                DialogResult dialogres = MessageBox.Show("Файл " + path + " сохранен успешно!\n Открыть его в блокноте?", "Сообщение", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (dialogres == DialogResult.Yes)
                {
                    System.Diagnostics.Process txt = new System.Diagnostics.Process();
                    txt.StartInfo.FileName = "notepad.exe";
                    txt.StartInfo.Arguments = path;
                    txt.Start();
                }
            }
            catch
            {
                MessageBox.Show("Сбой при сохранении файла", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
