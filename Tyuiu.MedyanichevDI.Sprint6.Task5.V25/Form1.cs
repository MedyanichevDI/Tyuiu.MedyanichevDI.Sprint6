using Tyuiu.MedyanichevDI.Sprint6.Task5.V25.Lib;

namespace Tyuiu.MedyanichevDI.Sprint6.Task5.V25
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DataSertvice ds = new DataSertvice();
        string path = @"C:";
        private void buttonDone_Click(object sender, EventArgs e)
        {
            dataGridViewNum.ColumnCount = 2;
            dataGridViewNum.Columns[0].Width = 20;
            dataGridViewNum.Columns[1].Width = 50;
            this.chartStolb.ChartAreas[0].AxisX.Title = "Îñü Õ";
            this.chartStolb.ChartAreas[0].AxisY.Title = "Îñü Ó";
            chartStolb.Series[0].Points.Clear();
            double[] mass = new double[ds.LoadFromDataFile(path).Length];
            mass = ds.LoadFromDataFile(path);
            for (int i=0; i < mass.Length; i++)
            {
                dataGridViewNum.Rows.Add(Convert.ToString(i), Convert.ToString(mass[i]));
                chartStolb.Series[0].Points.AddXY(i, mass[i]);
            }
        }
    }
}
