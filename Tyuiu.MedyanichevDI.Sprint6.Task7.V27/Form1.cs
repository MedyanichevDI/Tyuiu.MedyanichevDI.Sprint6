using Tyuiu.MedyanichevDI.Sprint6.Task7.V27.Lib;

namespace Tyuiu.MedyanichevDI.Sprint6.Task7.V27
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            openFileDialogTask.Filter = "�������� ���������� ��������(*.scv)|*.csv|��� �����(*.*)|(*.*)";
            saveFileDialogMatrix.Filter = "�������� ���������� ��������(*.scv)|*.csv|��� �����(*.*)|(*.*)";
        }
        static int row;
        static int colm;
        static string openFilePath;
        DataService ds = new DataService();


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonOpen_Click(object sender, EventArgs e)
        {
            openFileDialogTask.ShowDialog();
            openFilePath = openFileDialogTask.FileName;
            int[,] arrval = new int[row, colm];
        }
    }
}
