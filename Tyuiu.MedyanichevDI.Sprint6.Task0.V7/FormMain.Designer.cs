namespace Tyuiu.MedyanichevDI.Sprint6.Task0.V7
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            groupBoxUs = new GroupBox();
            label5 = new Label();
            groupBoxZn = new GroupBox();
            label1 = new Label();
            textBoxVarX = new TextBox();
            textBoxRes = new TextBox();
            label2 = new Label();
            groupBox1 = new GroupBox();
            buttonDone = new Button();
            pictureBox1 = new PictureBox();
            pictureBoxFormul = new PictureBox();
            groupBoxUs.SuspendLayout();
            groupBoxZn.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFormul).BeginInit();
            SuspendLayout();
            // 
            // groupBoxUs
            // 
            groupBoxUs.Controls.Add(pictureBox1);
            groupBoxUs.Controls.Add(label5);
            groupBoxUs.Location = new Point(28, 23);
            groupBoxUs.Name = "groupBoxUs";
            groupBoxUs.Size = new Size(494, 208);
            groupBoxUs.TabIndex = 0;
            groupBoxUs.TabStop = false;
            groupBoxUs.Text = "Условие";
            groupBoxUs.Enter += groupBoxUs_Enter;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(21, 30);
            label5.Name = "label5";
            label5.Size = new Size(205, 15);
            label5.TabIndex = 0;
            label5.Text = "Вычислить выражение по формуле";
            // 
            // groupBoxZn
            // 
            groupBoxZn.Controls.Add(label1);
            groupBoxZn.Controls.Add(textBoxVarX);
            groupBoxZn.Location = new Point(15, 237);
            groupBoxZn.Name = "groupBoxZn";
            groupBoxZn.Size = new Size(424, 148);
            groupBoxZn.TabIndex = 1;
            groupBoxZn.TabStop = false;
            groupBoxZn.Text = "Значение";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(113, 54);
            label1.Name = "label1";
            label1.Size = new Size(14, 15);
            label1.TabIndex = 4;
            label1.Text = "X";
            // 
            // textBoxVarX
            // 
            textBoxVarX.Location = new Point(81, 84);
            textBoxVarX.Name = "textBoxVarX";
            textBoxVarX.Size = new Size(100, 23);
            textBoxVarX.TabIndex = 2;
            textBoxVarX.KeyPress += textBoxVarX_KeyPress;
            // 
            // textBoxRes
            // 
            textBoxRes.Location = new Point(64, 84);
            textBoxRes.Name = "textBoxRes";
            textBoxRes.ReadOnly = true;
            textBoxRes.Size = new Size(152, 23);
            textBoxRes.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(118, 44);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 5;
            label2.Text = "Result";
            label2.Click += label2_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(textBoxRes);
            groupBox1.Location = new Point(464, 237);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(304, 150);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Вывод";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // buttonDone
            // 
            buttonDone.Location = new Point(603, 397);
            buttonDone.Name = "buttonDone";
            buttonDone.Size = new Size(150, 46);
            buttonDone.TabIndex = 3;
            buttonDone.Text = "Выполнть";
            buttonDone.UseVisualStyleBackColor = true;
            buttonDone.Click += buttonDone_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(733, 110);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 50);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // pictureBoxFormul
            // 
            pictureBoxFormul.Image = (Image)resources.GetObject("pictureBoxFormul.Image");
            pictureBoxFormul.Location = new Point(627, 79);
            pictureBoxFormul.Name = "pictureBoxFormul";
            pictureBoxFormul.Size = new Size(128, 68);
            pictureBoxFormul.TabIndex = 4;
            pictureBoxFormul.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBoxFormul);
            Controls.Add(buttonDone);
            Controls.Add(groupBox1);
            Controls.Add(groupBoxZn);
            Controls.Add(groupBoxUs);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBoxUs.ResumeLayout(false);
            groupBoxUs.PerformLayout();
            groupBoxZn.ResumeLayout(false);
            groupBoxZn.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFormul).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxUs;
        private GroupBox groupBoxZn;
        private Label label2;
        private Label label1;
        private TextBox textBoxRes;
        private TextBox textBoxVarX;
        private Label label5;
        private GroupBox groupBox1;
        private Button buttonDone;
        private PictureBox pictureBox1;
        private PictureBox pictureBoxFormul;
    }
}
