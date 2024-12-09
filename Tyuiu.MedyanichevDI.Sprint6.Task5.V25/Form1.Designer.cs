namespace Tyuiu.MedyanichevDI.Sprint6.Task5.V25
{
    partial class Form1
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            groupBox2 = new GroupBox();
            textBox1 = new TextBox();
            buttonSave = new Button();
            buttonDone = new Button();
            buttonInfo = new Button();
            groupBox1 = new GroupBox();
            chartStolb = new System.Windows.Forms.DataVisualization.Charting.Chart();
            dataGridViewNum = new DataGridView();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartStolb).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewNum).BeginInit();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(textBox1);
            groupBox2.Controls.Add(buttonSave);
            groupBox2.Controls.Add(buttonDone);
            groupBox2.Controls.Add(buttonInfo);
            groupBox2.Location = new Point(12, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1108, 90);
            groupBox2.TabIndex = 21;
            groupBox2.TabStop = false;
            groupBox2.Text = "Ввод";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(3, 19);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(562, 65);
            textBox1.TabIndex = 21;
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(651, 22);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(119, 48);
            buttonSave.TabIndex = 20;
            buttonSave.Text = "Сохранить";
            buttonSave.UseVisualStyleBackColor = true;
            // 
            // buttonDone
            // 
            buttonDone.Location = new Point(789, 23);
            buttonDone.Name = "buttonDone";
            buttonDone.Size = new Size(150, 46);
            buttonDone.TabIndex = 18;
            buttonDone.Text = "Выполнть";
            buttonDone.UseVisualStyleBackColor = true;
            buttonDone.Click += buttonDone_Click;
            // 
            // buttonInfo
            // 
            buttonInfo.BackColor = SystemColors.MenuHighlight;
            buttonInfo.Location = new Point(973, 9);
            buttonInfo.Name = "buttonInfo";
            buttonInfo.Size = new Size(106, 71);
            buttonInfo.TabIndex = 19;
            buttonInfo.Text = "Info";
            buttonInfo.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(chartStolb);
            groupBox1.Controls.Add(dataGridViewNum);
            groupBox1.Location = new Point(12, 108);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1108, 417);
            groupBox1.TabIndex = 22;
            groupBox1.TabStop = false;
            groupBox1.Text = "Вывод";
            // 
            // chartStolb
            // 
            chartArea2.Name = "ChartArea1";
            chartStolb.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            chartStolb.Legends.Add(legend2);
            chartStolb.Location = new Point(319, 29);
            chartStolb.Name = "chartStolb";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            chartStolb.Series.Add(series2);
            chartStolb.Size = new Size(784, 382);
            chartStolb.TabIndex = 1;
            chartStolb.Text = "chart1";
            // 
            // dataGridViewNum
            // 
            dataGridViewNum.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewNum.Location = new Point(5, 21);
            dataGridViewNum.Name = "dataGridViewNum";
            dataGridViewNum.Size = new Size(282, 394);
            dataGridViewNum.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1208, 536);
            Controls.Add(groupBox1);
            Controls.Add(groupBox2);
            Name = "Form1";
            Text = "Form1";
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chartStolb).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewNum).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox2;
        private Button buttonSave;
        private Button buttonDone;
        private Button buttonInfo;
        private GroupBox groupBox1;
        private TextBox textBox1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartStolb;
        private DataGridView dataGridViewNum;
    }
}
