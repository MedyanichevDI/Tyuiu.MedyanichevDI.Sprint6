namespace Tyuiu.MedyanichevDI.Sprint6.Task1.V4
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
            buttonDone = new Button();
            groupBox1 = new GroupBox();
            label2 = new Label();
            textBoxRes = new TextBox();
            groupBoxZn = new GroupBox();
            label4 = new Label();
            label3 = new Label();
            textBoxStop = new TextBox();
            label1 = new Label();
            textBoxStart = new TextBox();
            groupBoxUs = new GroupBox();
            pictureBox1 = new PictureBox();
            buttonInfo = new Button();
            groupBox1.SuspendLayout();
            groupBoxZn.SuspendLayout();
            groupBoxUs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // buttonDone
            // 
            buttonDone.Location = new Point(487, 294);
            buttonDone.Name = "buttonDone";
            buttonDone.Size = new Size(150, 46);
            buttonDone.TabIndex = 8;
            buttonDone.Text = "Выполнть";
            buttonDone.UseVisualStyleBackColor = true;
            buttonDone.Click += buttonDone_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(textBoxRes);
            groupBox1.Location = new Point(656, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(304, 393);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "Вывод";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(118, 44);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 5;
            label2.Text = "Result";
            // 
            // textBoxRes
            // 
            textBoxRes.Location = new Point(6, 94);
            textBoxRes.Multiline = true;
            textBoxRes.Name = "textBoxRes";
            textBoxRes.ReadOnly = true;
            textBoxRes.Size = new Size(292, 282);
            textBoxRes.TabIndex = 3;
            // 
            // groupBoxZn
            // 
            groupBoxZn.Controls.Add(label4);
            groupBoxZn.Controls.Add(label3);
            groupBoxZn.Controls.Add(textBoxStop);
            groupBoxZn.Controls.Add(label1);
            groupBoxZn.Controls.Add(textBoxStart);
            groupBoxZn.Location = new Point(24, 229);
            groupBoxZn.Name = "groupBoxZn";
            groupBoxZn.Size = new Size(298, 148);
            groupBoxZn.TabIndex = 6;
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
            // label3
            // 
            label3.Location = new Point(0, 0);
            label3.Name = "label3";
            label3.Size = new Size(100, 23);
            label3.TabIndex = 0;
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
            textBoxStart.TextChanged += FormMain_Load;
            textBoxStart.KeyPress += textBoxStart_KeyPress;
            // 
            // groupBoxUs
            // 
            groupBoxUs.Controls.Add(pictureBox1);
            groupBoxUs.Location = new Point(1, 15);
            groupBoxUs.Name = "groupBoxUs";
            groupBoxUs.Size = new Size(648, 208);
            groupBoxUs.TabIndex = 5;
            groupBoxUs.TabStop = false;
            groupBoxUs.Text = "Условие";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Task;
            pictureBox1.Location = new Point(6, 22);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(639, 180);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // buttonInfo
            // 
            buttonInfo.BackColor = SystemColors.MenuHighlight;
            buttonInfo.Location = new Point(359, 277);
            buttonInfo.Name = "buttonInfo";
            buttonInfo.Size = new Size(106, 128);
            buttonInfo.TabIndex = 9;
            buttonInfo.Text = "Info";
            buttonInfo.UseVisualStyleBackColor = false;
            buttonInfo.Click += buttonInfo_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(972, 450);
            Controls.Add(buttonInfo);
            Controls.Add(buttonDone);
            Controls.Add(groupBox1);
            Controls.Add(groupBoxZn);
            Controls.Add(groupBoxUs);
            Name = "FormMain";
            Text = "Медяничев Денис|АСоИУБ 24-1";
            Load += FormMain_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBoxZn.ResumeLayout(false);
            groupBoxZn.PerformLayout();
            groupBoxUs.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button buttonDone;
        private GroupBox groupBox1;
        private Label label2;
        private TextBox textBoxRes;
        private GroupBox groupBoxZn;
        private Label label1;
        private TextBox textBoxStart;
        private GroupBox groupBoxUs;
        private PictureBox pictureBox1;
        private Label label3;
        private TextBox textBoxStop;
        private Label label4;
        private Button buttonInfo;
    }
}
