using System.IO;
using Tyuiu.NovikovaVA.Sprint6.Task5.V15.Lib;
namespace Tyuiu.NovikovaVA.Sprint6.Task5.V15
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();

        string path = @"C:\Users\User\source\repos\Tyuiu.NovikovaVA.Sprint6\DataSprint6\InPutDataFileTask5V15.txt";
        private void buttonHelp_NVA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 5 выполнила студент группы ИСТНб-24-1 Новикова В. А.", "Справка", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void buttonOpenFile_NVA_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process txt = new System.Diagnostics.Process();
            txt.StartInfo.FileName = "notepad.exe";
            txt.StartInfo.Arguments = path;
            txt.Start();
        }
        private void buttonDone_NVA_Click(object sender, EventArgs e)
        {
            dataGridViewResult_NVA.ColumnCount = 2;
            dataGridViewResult_NVA.Columns[0].Width = 20;
            dataGridViewResult_NVA.Columns[1].Width = 50;

            this.chartRes_NVA.ChartAreas[0].AxisX.Title = "Ось X";
            this.chartRes_NVA.ChartAreas[0].AxisY.Title = "Ось Y";

            chartRes_NVA.Series[0].Points.Clear();

            double[] numsMass = new double[ds.len];
            numsMass = ds.LoadFromDataFile(path);

            for (int i = 0; i < numsMass.Length; i++)
            {
                dataGridViewResult_NVA.Rows.Add(Convert.ToString(i), Convert.ToString(numsMass[i]));
                chartRes_NVA.Series[0].Points.AddXY(i, numsMass[i]);
            }
        }

    }
    
}
