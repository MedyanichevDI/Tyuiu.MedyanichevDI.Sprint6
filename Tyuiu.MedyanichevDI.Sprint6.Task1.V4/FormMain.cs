using Tyuiu.MedyanichevDI.Sprint6.Task1.V4.Lib;

namespace Tyuiu.MedyanichevDI.Sprint6.Task1.V4
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();

        private void FormMain_Load(object sender, EventArgs e)
        {

        }


        private void textBoxStart_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 59) && (e.KeyChar != ',') && (e.KeyChar != 8)&&(e.KeyChar==95))
            {
                e.Handled = true;
            }
        }

        private void buttonDone_Click(object sender, EventArgs e)
        {
            try
            {
                int BoxStart = Convert.ToInt32(textBoxStart.Text);
                int BoxEnd = Convert.ToInt32(textBoxStop.Text);
                string line;
                int len = ds.GetMassFunction(BoxStart, BoxEnd).Length;
                double[] arr = new double[len];
                double[] valarr = ds.GetMassFunction(BoxStart, BoxEnd);
                textBoxRes.Text = "";
                textBoxRes.AppendText("+------+------+" + Environment.NewLine);
                textBoxRes.AppendText("|   X   | F(x) |" + Environment.NewLine);
                textBoxRes.AppendText("+------+------+" + Environment.NewLine);
                for (int i = 0; i < len ; i++)
                {
                    line = String.Format("|{0,5:d}    |{1, 5:f2}  |", BoxStart, valarr[i]);
                    textBoxRes.AppendText(line + Environment.NewLine);
                    BoxStart ++;
                    
                }
                textBoxRes.AppendText("+------+------+" + Environment.NewLine);
            }
            catch
            {
                MessageBox.Show("Fail");
            }
        }

        private void buttonInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Выполнил студент группы АСОиУБ 24-1 Медянничев Д.И.");
        }
    }
}
