namespace Tyuiu.MedyanichevDI.Sprint6.Task4.V1
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
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            buttonInfo = new Button();
            buttonDone = new Button();
            groupBox1 = new GroupBox();
            textBoxRes = new TextBox();
            chartFunc = new System.Windows.Forms.DataVisualization.Charting.Chart();
            groupBoxZn = new GroupBox();
            label4 = new Label();
            textBoxStop = new TextBox();
            label1 = new Label();
            textBoxStart = new TextBox();
            groupBoxUs = new GroupBox();
            groupBox2 = new GroupBox();
            buttonSave = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartFunc).BeginInit();
            groupBoxZn.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
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
            // groupBox1
            // 
            groupBox1.Controls.Add(textBoxRes);
            groupBox1.Controls.Add(chartFunc);
            groupBox1.Location = new Point(6, 99);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1108, 417);
            groupBox1.TabIndex = 17;
            groupBox1.TabStop = false;
            groupBox1.Text = "Вывод";
            // 
            // textBoxRes
            // 
            textBoxRes.Location = new Point(8, 25);
            textBoxRes.Multiline = true;
            textBoxRes.Name = "textBoxRes";
            textBoxRes.Size = new Size(268, 386);
            textBoxRes.TabIndex = 3;
            // 
            // chartFunc
            // 
            chartArea2.Name = "ChartArea1";
            chartFunc.ChartAreas.Add(chartArea2);
            legend2.Enabled = false;
            legend2.Name = "Legend1";
            chartFunc.Legends.Add(legend2);
            chartFunc.Location = new Point(293, 22);
            chartFunc.Name = "chartFunc";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            chartFunc.Series.Add(series2);
            chartFunc.Size = new Size(797, 389);
            chartFunc.TabIndex = 2;
            chartFunc.Text = "chart1";
            title2.Font = new Font("Microsoft Sans Serif", 12F);
            title2.ForeColor = Color.LightSeaGreen;
            title2.Name = "Title1";
            title2.Text = "График функции Sin(x)";
            chartFunc.Titles.Add(title2);
            // 
            // groupBoxZn
            // 
            groupBoxZn.Controls.Add(label4);
            groupBoxZn.Controls.Add(textBoxStop);
            groupBoxZn.Controls.Add(label1);
            groupBoxZn.Controls.Add(textBoxStart);
            groupBoxZn.Location = new Point(320, 12);
            groupBoxZn.Name = "groupBoxZn";
            groupBoxZn.Size = new Size(298, 71);
            groupBoxZn.TabIndex = 16;
            groupBoxZn.TabStop = false;
            groupBoxZn.Text = "Значение";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(171, 19);
            label4.Name = "label4";
            label4.Size = new Size(72, 15);
            label4.TabIndex = 6;
            label4.Text = "Конец шага";
            // 
            // textBoxStop
            // 
            textBoxStop.Location = new Point(155, 37);
            textBoxStop.Name = "textBoxStop";
            textBoxStop.Size = new Size(100, 23);
            textBoxStop.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 19);
            label1.Name = "label1";
            label1.Size = new Size(69, 15);
            label1.TabIndex = 4;
            label1.Text = "Старт шага";
            // 
            // textBoxStart
            // 
            textBoxStart.Location = new Point(15, 37);
            textBoxStart.Name = "textBoxStart";
            textBoxStart.Size = new Size(100, 23);
            textBoxStart.TabIndex = 2;
            // 
            // groupBoxUs
            // 
            groupBoxUs.Location = new Point(6, 25);
            groupBoxUs.Name = "groupBoxUs";
            groupBoxUs.Size = new Size(308, 58);
            groupBoxUs.TabIndex = 15;
            groupBoxUs.TabStop = false;
            groupBoxUs.Text = "Условие";
            groupBoxUs.Enter += groupBoxUs_Enter;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(buttonSave);
            groupBox2.Controls.Add(buttonDone);
            groupBox2.Controls.Add(buttonInfo);
            groupBox2.Location = new Point(6, 3);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1108, 90);
            groupBox2.TabIndex = 20;
            groupBox2.TabStop = false;
            groupBox2.Text = "groupBox2";
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(651, 22);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(119, 48);
            buttonSave.TabIndex = 20;
            buttonSave.Text = "Сохранить";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1120, 528);
            Controls.Add(groupBox1);
            Controls.Add(groupBoxZn);
            Controls.Add(groupBoxUs);
            Controls.Add(groupBox2);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)chartFunc).EndInit();
            groupBoxZn.ResumeLayout(false);
            groupBoxZn.PerformLayout();
            groupBox2.ResumeLayout(false);
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
        private GroupBox groupBox2;
        private Button buttonSave;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunc;
        private TextBox textBoxRes;
    }
}
