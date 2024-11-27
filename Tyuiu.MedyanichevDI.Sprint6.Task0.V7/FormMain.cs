using Tyuiu.MedyanichevDI.Sprint6.Task0.V7.Lib;

namespace Tyuiu.MedyanichevDI.Sprint6.Task0.V7
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void buttonDone_Click(object sender, EventArgs e)
        {
            DataService ds = new DataService();
            try
            {
                textBoxRes.Text = Convert.ToString(ds.Calculate(Convert.ToInt32(textBoxVarX.Text)));
            }
            catch
            {
                MessageBox.Show("Ошибка");
            }
        }

        private void textBoxVarX_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && (e.KeyChar != ',') && (e.KeyChar != 8))
            {
                e.Handled = true;
            }
        }

        private void groupBoxUs_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
