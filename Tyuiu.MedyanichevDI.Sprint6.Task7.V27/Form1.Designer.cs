namespace Tyuiu.MedyanichevDI.Sprint6.Task7.V27
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
            groupBox3 = new GroupBox();
            dataGridView2 = new DataGridView();
            textBox1 = new TextBox();
            groupBox1 = new GroupBox();
            dataGridView1 = new DataGridView();
            groupBox2 = new GroupBox();
            buttonOpen = new Button();
            buttonDone = new Button();
            buttonInfo = new Button();
            openFileDialogTask = new OpenFileDialog();
            toolTipbutton = new ToolTip(components);
            saveFileDialogMatrix = new SaveFileDialog();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(dataGridView2);
            groupBox3.Location = new Point(564, 181);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(550, 346);
            groupBox3.TabIndex = 29;
            groupBox3.TabStop = false;
            groupBox3.Text = "Вывод";
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(6, 26);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.Size = new Size(537, 318);
            dataGridView2.TabIndex = 0;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(6, 108);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(1107, 65);
            textBox1.TabIndex = 26;
            textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Location = new Point(6, 179);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(534, 346);
            groupBox1.TabIndex = 28;
            groupBox1.TabStop = false;
            groupBox1.Text = "Вывод";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(3, 22);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(525, 320);
            dataGridView1.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(buttonOpen);
            groupBox2.Controls.Add(buttonDone);
            groupBox2.Controls.Add(buttonInfo);
            groupBox2.Location = new Point(6, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1108, 90);
            groupBox2.TabIndex = 27;
            groupBox2.TabStop = false;
            // 
            // buttonOpen
            // 
            buttonOpen.FlatStyle = FlatStyle.Flat;
            buttonOpen.Image = (Image)resources.GetObject("buttonOpen.Image");
            buttonOpen.Location = new Point(21, 22);
            buttonOpen.Name = "buttonOpen";
            buttonOpen.Size = new Size(119, 48);
            buttonOpen.TabIndex = 20;
            buttonOpen.UseVisualStyleBackColor = true;
            // 
            // buttonDone
            // 
            buttonDone.FlatStyle = FlatStyle.Flat;
            buttonDone.Image = Properties.Resources.door_out;
            buttonDone.Location = new Point(173, 24);
            buttonDone.Name = "buttonDone";
            buttonDone.Size = new Size(139, 46);
            buttonDone.TabIndex = 18;
            buttonDone.UseVisualStyleBackColor = true;
            // 
            // buttonInfo
            // 
            buttonInfo.BackColor = SystemColors.MenuHighlight;
            buttonInfo.Location = new Point(973, 9);
            buttonInfo.Name = "buttonInfo";
            buttonInfo.Size = new Size(106, 71);
            buttonInfo.TabIndex = 19;
            buttonInfo.UseVisualStyleBackColor = false;
            // 
            // openFileDialogTask
            // 
            openFileDialogTask.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1126, 576);
            Controls.Add(groupBox3);
            Controls.Add(textBox1);
            Controls.Add(groupBox1);
            Controls.Add(groupBox2);
            Name = "Form1";
            Text = "Медяничев Денис|АСоИУБ 24-1";
            Load += Form1_Load;
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox3;
        private DataGridView dataGridView2;
        private TextBox textBox1;
        private GroupBox groupBox1;
        private DataGridView dataGridView1;
        private GroupBox groupBox2;
        private Button buttonOpen;
        private Button buttonDone;
        private Button buttonInfo;
        private OpenFileDialog openFileDialogTask;
        private ToolTip toolTipbutton;
        private SaveFileDialog saveFileDialogMatrix;
    }
}
