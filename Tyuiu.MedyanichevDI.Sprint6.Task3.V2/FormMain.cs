using System.Drawing.Drawing2D;
using Tyuiu.MedyanichevDI.Sprint6.Task3.V2.Lib;

namespace Tyuiu.MedyanichevDI.Sprint6.Task3.V2
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        int[,] mtrx = new int[5, 5] {{12,  -4, -20,   5,  -5 },

                                      { 2,  15,   1, -20,   7 },

                                      { 15, -15,   2,  11,   5 },

                                     { -19,  -9,  16,   0,   1 },

                                      { 17,  16,   5,  12,  -8 }};
        private void FormMain_Load(object sender, EventArgs e)
        {
            int row = mtrx.GetUpperBound(0) + 1;
            int colm = mtrx.Length / row;
            dataGridView1.ColumnCount = colm;
            dataGridView1.RowCount = row;
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < colm; j++)
                {
                    dataGridView1.Rows[i].Cells[j].Value = Convert.ToString(mtrx[i, j]);
                }
            }
        }
        private void buttonDone_Click(object sender, EventArgs e)
        {
            textBoxRez.Text = Convert.ToString(ds.Calculate(mtrx));
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
