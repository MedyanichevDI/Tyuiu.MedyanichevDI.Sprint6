namespace Tyuiu.MedyanichevDI.Sprint6.Task6.V7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonOpen_Click(object sender, EventArgs e)
        {
            openFileDialogTask.ShowDialog();
            openFilePath = openFileDialogTask.FileName;
            textBoxload.Text = File.ReadAllText(openFilePath);

        }
    }
}
