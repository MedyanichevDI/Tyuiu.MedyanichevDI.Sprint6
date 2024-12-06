using Tyuiu.MedyanichevDI.Sprint6.Task2.V14.Lib;

namespace Tyuiu.MedyanichevDI.Sprint6.Task2.V14
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        private void textBoxStart_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 59) && (e.KeyChar != ',') && (e.KeyChar != 8) && (e.KeyChar == 95))
            {
                e.Handled = true;
            }
        }
        private void buttonInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Выполнил студент группы АСОиУБ 24-1 Медянничев Д.И.");
        }
        DataService ds = new DataService();
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
                this.chartFunc.Titles.Add("sin(x)");
                this.chartFunc.ChartAreas[0].AxisX.Title = "ось Х";
                this.chartFunc.ChartAreas[0].AxisY.Title = "ось Y";

                for (int i = 0; i < len; i++)
                {
                    this.dataGridViewFunc.Rows.Add(Convert.ToString(BoxStart), Convert.ToString(valarr[i]));
                    this.chartFunc.Series[0].Points.AddXY(BoxStart, valarr[i]);
                    BoxStart++;
                }

            }
            catch
            {
                MessageBox.Show("Fail");
            }
        }

        private void dataGridViewFunc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void groupBoxUs_Enter(object sender, EventArgs e)
        {

        }
    }
}
