namespace Tyuiu.MedyanichevDI.Sprint6.Task3.V2
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            buttonInfo = new Button();
            buttonDone = new Button();
            groupBoxUs = new GroupBox();
            textBox1 = new TextBox();
            dataGridView1 = new DataGridView();
            groupBoxRez = new GroupBox();
            label1 = new Label();
            textBoxRez = new TextBox();
            groupBoxUs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBoxRez.SuspendLayout();
            SuspendLayout();
            // 
            // buttonInfo
            // 
            buttonInfo.BackColor = SystemColors.MenuHighlight;
            buttonInfo.Location = new Point(508, 388);
            buttonInfo.Name = "buttonInfo";
            buttonInfo.Size = new Size(68, 58);
            buttonInfo.TabIndex = 16;
            buttonInfo.Text = "Info";
            buttonInfo.UseVisualStyleBackColor = false;
            // 
            // buttonDone
            // 
            buttonDone.Location = new Point(638, 406);
            buttonDone.Name = "buttonDone";
            buttonDone.Size = new Size(112, 22);
            buttonDone.TabIndex = 15;
            buttonDone.Text = "Выполнть";
            buttonDone.UseVisualStyleBackColor = true;
            buttonDone.Click += buttonDone_Click;
            // 
            // groupBoxUs
            // 
            groupBoxUs.Controls.Add(textBox1);
            groupBoxUs.Location = new Point(12, 12);
            groupBoxUs.Name = "groupBoxUs";
            groupBoxUs.Size = new Size(238, 334);
            groupBoxUs.TabIndex = 17;
            groupBoxUs.TabStop = false;
            groupBoxUs.Text = "Условие";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(6, 27);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(222, 292);
            textBox1.TabIndex = 0;
            textBox1.Text = "Дан массив 5 на 5 элементов. Заменить четные значения в первой строке на 0.\r\n\r\n-12  -4 -20   5  -5\r\n\r\n   2  15   1 -20   7\r\n\r\n  15 -15   2  11   5\r\n\r\n -19  -9  16   0   1\r\n\r\n  17  16   5  12  -8";
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(294, 68);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(184, 278);
            dataGridView1.TabIndex = 18;
            // 
            // groupBoxRez
            // 
            groupBoxRez.Controls.Add(label1);
            groupBoxRez.Controls.Add(textBoxRez);
            groupBoxRez.Location = new Point(569, 68);
            groupBoxRez.Name = "groupBoxRez";
            groupBoxRez.Size = new Size(181, 176);
            groupBoxRez.TabIndex = 19;
            groupBoxRez.TabStop = false;
            groupBoxRez.Text = "Вывод данных";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 48);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 4;
            label1.Text = "Результат";
            // 
            // textBoxRez
            // 
            textBoxRez.Location = new Point(15, 78);
            textBoxRez.Name = "textBoxRez";
            textBoxRez.Size = new Size(100, 23);
            textBoxRez.TabIndex = 2;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBoxRez);
            Controls.Add(dataGridView1);
            Controls.Add(groupBoxUs);
            Controls.Add(buttonInfo);
            Controls.Add(buttonDone);
            Name = "FormMain";
            Text = "Form1";
            Load += FormMain_Load;
            groupBoxUs.ResumeLayout(false);
            groupBoxUs.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBoxRez.ResumeLayout(false);
            groupBoxRez.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button buttonInfo;
        private Button buttonDone;
        private GroupBox groupBoxUs;
        private DataGridView dataGridView1;
        private GroupBox groupBoxRez;
        private Label label1;
        private TextBox textBoxRez;
        private TextBox textBox1;
    }
}
