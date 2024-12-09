using Tyuiu.MedyanichevDI.Sprint6.Task4.V1.Lib;

namespace Tyuiu.MedyanichevDI.Sprint6.Task4.V1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void buttonDone_Click(object sender, EventArgs e)
        {
            try
            {
                int BoxStart = Convert.ToInt32(textBoxStart.Text);
                int BoxEnd = Convert.ToInt32(textBoxStop.Text);
                int len = ds.GetMassFunction(BoxStart, BoxEnd).Length;
                double[] arr = new double[len];
                double[] valarr = ds.GetMassFunction(BoxStart, BoxEnd);

                this.chartFunc.ChartAreas[0].AxisX.Title = "ось Х";
                this.chartFunc.ChartAreas[0].AxisY.Title = "ось Y";
                textBoxRes.Text = "";
                chartFunc.Series[0].Points.AddXY(BoxStart, valarr);
                for (int i = 0; i < len; i++)
                {
                    this.chartFunc.Series[0].Points.AddXY(BoxStart, valarr);
                    textBoxRes.AppendText(valarr[i] + Environment.NewLine);
                    BoxStart++;
                }
            }
            catch
            {
                MessageBox.Show("Fail");
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                string path = $@"{Directory.GetCurrentDirectory()}\OutputFileTask4.txt";
                File.WriteAllText(path, textBoxRes.Text);
                DialogResult dialogResult = MessageBox.Show("Файл" + path + "Сохранение успешно\n открыть его в блокноте?", "Сообщение", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                dialogResult = DialogResult.Yes;
                System.Diagnostics.Process txt = new System.Diagnostics.Process();
                txt.StartInfo.FileName = "notepad.exe";
                txt.StartInfo.Arguments = path;
            }
            catch
            {
                MessageBox.Show("Fail");
            }
        }

        private void groupBoxUs_Enter(object sender, EventArgs e)
        {

        }
    }
}
