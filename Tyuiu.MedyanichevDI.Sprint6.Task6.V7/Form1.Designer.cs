namespace Tyuiu.MedyanichevDI.Sprint6.Task6.V7
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            groupBox1 = new GroupBox();
            textBoxload = new TextBox();
            groupBox2 = new GroupBox();
            buttonOpen = new Button();
            buttonDone = new Button();
            buttonInfo = new Button();
            textBox1 = new TextBox();
            openFileDialogTask = new OpenFileDialog();
            toolTip1 = new ToolTip(components);
            groupBox3 = new GroupBox();
            textBox3 = new TextBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBoxload);
            groupBox1.Location = new Point(11, 182);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(534, 346);
            groupBox1.TabIndex = 24;
            groupBox1.TabStop = false;
            groupBox1.Text = "Вывод";
            // 
            // textBoxload
            // 
            textBoxload.Location = new Point(6, 22);
            textBoxload.Multiline = true;
            textBoxload.Name = "textBoxload";
            textBoxload.Size = new Size(508, 318);
            textBoxload.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(buttonOpen);
            groupBox2.Controls.Add(buttonDone);
            groupBox2.Controls.Add(buttonInfo);
            groupBox2.Location = new Point(11, 15);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1108, 90);
            groupBox2.TabIndex = 23;
            groupBox2.TabStop = false;
            // 
            // buttonOpen
            // 
            buttonOpen.Image = (Image)resources.GetObject("buttonOpen.Image");
            buttonOpen.Location = new Point(21, 22);
            buttonOpen.Name = "buttonOpen";
            buttonOpen.Size = new Size(119, 48);
            buttonOpen.TabIndex = 20;
            buttonOpen.UseVisualStyleBackColor = true;
            // 
            // buttonDone
            // 
            buttonDone.Image = Properties.Resources.door_out;
            buttonDone.Location = new Point(173, 24);
            buttonDone.Name = "buttonDone";
            buttonDone.Size = new Size(150, 46);
            buttonDone.TabIndex = 18;
            buttonDone.UseVisualStyleBackColor = true;
            buttonDone.Click += buttonOpen_Click;
            // 
            // buttonInfo
            // 
            buttonInfo.BackColor = SystemColors.MenuHighlight;
            buttonInfo.Image = Properties.Resources.book;
            buttonInfo.Location = new Point(973, 9);
            buttonInfo.Name = "buttonInfo";
            buttonInfo.Size = new Size(106, 71);
            buttonInfo.TabIndex = 19;
            buttonInfo.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(11, 111);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(1107, 65);
            textBox1.TabIndex = 21;
            textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // openFileDialogTask
            // 
            openFileDialogTask.FileName = "openFileDialogTask";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(textBox3);
            groupBox3.Location = new Point(569, 184);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(550, 346);
            groupBox3.TabIndex = 25;
            groupBox3.TabStop = false;
            groupBox3.Text = "Вывод";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(6, 26);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(538, 312);
            textBox3.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1130, 542);
            Controls.Add(groupBox3);
            Controls.Add(textBox1);
            Controls.Add(groupBox1);
            Controls.Add(groupBox2);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button buttonOpen;
        private Button buttonDone;
        private Button buttonInfo;
        private TextBox textBox1;
        private OpenFileDialog openFileDialogTask;
        private ToolTip toolTip1;
        private TextBox textBoxload;
        private GroupBox groupBox3;
        private TextBox textBox3;
    }
}
