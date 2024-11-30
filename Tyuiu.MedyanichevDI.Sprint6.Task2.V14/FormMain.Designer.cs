namespace Tyuiu.MedyanichevDI.Sprint6.Task2.V14
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            buttonInfo = new Button();
            buttonDone = new Button();
            groupBox1 = new GroupBox();
            dataGridViewFunc = new DataGridView();
            X = new DataGridViewTextBoxColumn();
            Fx = new DataGridViewTextBoxColumn();
            chartFunc = new System.Windows.Forms.DataVisualization.Charting.Chart();
            groupBoxZn = new GroupBox();
            label4 = new Label();
            textBoxStop = new TextBox();
            label1 = new Label();
            textBoxStart = new TextBox();
            groupBoxUs = new GroupBox();
            pictureBox1 = new PictureBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewFunc).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chartFunc).BeginInit();
            groupBoxZn.SuspendLayout();
            groupBoxUs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // buttonInfo
            // 
            buttonInfo.BackColor = SystemColors.MenuHighlight;
            buttonInfo.Location = new Point(337, 323);
            buttonInfo.Name = "buttonInfo";
            buttonInfo.Size = new Size(106, 82);
            buttonInfo.TabIndex = 14;
            buttonInfo.Text = "Info";
            buttonInfo.UseVisualStyleBackColor = false;
            buttonInfo.Click += buttonInfo_Click;
            // 
            // buttonDone
            // 
            buttonDone.Location = new Point(467, 341);
            buttonDone.Name = "buttonDone";
            buttonDone.Size = new Size(150, 46);
            buttonDone.TabIndex = 13;
            buttonDone.Text = "Выполнть";
            buttonDone.UseVisualStyleBackColor = true;
            buttonDone.Click += buttonDone_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dataGridViewFunc);
            groupBox1.Controls.Add(chartFunc);
            groupBox1.Location = new Point(656, 29);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(476, 393);
            groupBox1.TabIndex = 12;
            groupBox1.TabStop = false;
            groupBox1.Text = "Вывод";
            // 
            // dataGridViewFunc
            // 
            dataGridViewFunc.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewFunc.Columns.AddRange(new DataGridViewColumn[] { X, Fx });
            dataGridViewFunc.Location = new Point(17, 48);
            dataGridViewFunc.Name = "dataGridViewFunc";
            dataGridViewFunc.RowHeadersVisible = false;
            dataGridViewFunc.Size = new Size(109, 312);
            dataGridViewFunc.TabIndex = 1;
            dataGridViewFunc.CellContentClick += dataGridViewFunc_CellContentClick;
            // 
            // X
            // 
            X.HeaderText = "X";
            X.Name = "X";
            X.Width = 50;
            // 
            // Fx
            // 
            Fx.HeaderText = "Fx";
            Fx.Name = "Fx";
            Fx.Width = 50;
            // 
            // chartFunc
            // 
            chartArea1.Name = "ChartArea1";
            chartFunc.ChartAreas.Add(chartArea1);
            legend1.Enabled = false;
            legend1.Name = "Legend1";
            chartFunc.Legends.Add(legend1);
            chartFunc.Location = new Point(132, 60);
            chartFunc.Name = "chartFunc";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartFunc.Series.Add(series1);
            chartFunc.Size = new Size(336, 300);
            chartFunc.TabIndex = 0;
            chartFunc.Text = "chart1";
            // 
            // groupBoxZn
            // 
            groupBoxZn.Controls.Add(label4);
            groupBoxZn.Controls.Add(textBoxStop);
            groupBoxZn.Controls.Add(label1);
            groupBoxZn.Controls.Add(textBoxStart);
            groupBoxZn.Location = new Point(12, 257);
            groupBoxZn.Name = "groupBoxZn";
            groupBoxZn.Size = new Size(298, 148);
            groupBoxZn.TabIndex = 11;
            groupBoxZn.TabStop = false;
            groupBoxZn.Text = "Значение";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(175, 48);
            label4.Name = "label4";
            label4.Size = new Size(72, 15);
            label4.TabIndex = 6;
            label4.Text = "Конец шага";
            // 
            // textBoxStop
            // 
            textBoxStop.Location = new Point(155, 78);
            textBoxStop.Name = "textBoxStop";
            textBoxStop.Size = new Size(100, 23);
            textBoxStop.TabIndex = 5;
            textBoxStop.KeyPress += textBoxStart_KeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 48);
            label1.Name = "label1";
            label1.Size = new Size(69, 15);
            label1.TabIndex = 4;
            label1.Text = "Старт шага";
            // 
            // textBoxStart
            // 
            textBoxStart.Location = new Point(15, 78);
            textBoxStart.Name = "textBoxStart";
            textBoxStart.Size = new Size(100, 23);
            textBoxStart.TabIndex = 2;
            textBoxStart.KeyPress += textBoxStart_KeyPress;
            // 
            // groupBoxUs
            // 
            groupBoxUs.Controls.Add(pictureBox1);
            groupBoxUs.Location = new Point(12, 12);
            groupBoxUs.Name = "groupBoxUs";
            groupBoxUs.Size = new Size(638, 208);
            groupBoxUs.TabIndex = 10;
            groupBoxUs.TabStop = false;
            groupBoxUs.Text = "Условие";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Задание;
            pictureBox1.Location = new Point(6, 22);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(639, 180);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1144, 450);
            Controls.Add(buttonInfo);
            Controls.Add(buttonDone);
            Controls.Add(groupBox1);
            Controls.Add(groupBoxZn);
            Controls.Add(groupBoxUs);
            Name = "FormMain";
            Text = "Медяничев Д.И.|АСОиУБ 24-1";
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewFunc).EndInit();
            ((System.ComponentModel.ISupportInitialize)chartFunc).EndInit();
            groupBoxZn.ResumeLayout(false);
            groupBoxZn.PerformLayout();
            groupBoxUs.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button buttonInfo;
        private Button buttonDone;
        private GroupBox groupBox1;
        private GroupBox groupBoxZn;
        private Label label4;
        private TextBox textBoxStop;
        private Label label1;
        private TextBox textBoxStart;
        private GroupBox groupBoxUs;
        private PictureBox pictureBox1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunc;
        private DataGridView dataGridViewFunc;
        private DataGridViewTextBoxColumn X;
        private DataGridViewTextBoxColumn Fx;
    }
}
