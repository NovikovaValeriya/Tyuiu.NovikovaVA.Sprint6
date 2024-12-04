using Tyuiu.NovikovaVA.Sprint6.Task0.V16.Lib;
namespace Tyuiu.NovikovaVA.Sprint6.Task0.V16
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        private void buttonDone_NVA_Click(object sender, EventArgs e)
        {
            DataService ds = new DataService();
            try
            {
                textBoxResult_NVA.Text = Convert.ToString(ds.Calculate(Convert.ToInt32(textBoxNamedTwo_NVA.Text)));
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void textBoxNamedTwo_NVA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && (e.KeyChar != ',') && (e.KeyChar != 8))
            {
                e.Handled = true;
            }
        }
        private void buttonHelp_NVA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 0 выполнил студент группы ИСТНб-24-1 Новикова Валерия Александровна", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


    }
}
