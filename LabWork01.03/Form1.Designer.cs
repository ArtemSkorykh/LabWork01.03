namespace LabWork01._03
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
            listBox1 = new ListBox();
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            StartTime = new Label();
            label4 = new Label();
            label5 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label6 = new Label();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            button2 = new Button();
            numericUpDown1 = new NumericUpDown();
            label8 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(12, 12);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(224, 424);
            listBox1.TabIndex = 0;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.Location = new Point(285, 413);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 1;
            button1.Text = "Remove";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(285, 14);
            label1.Name = "label1";
            label1.Size = new Size(17, 15);
            label1.TabIndex = 2;
            label1.Text = "Id";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(285, 58);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 3;
            label2.Text = "Name";
            // 
            // StartTime
            // 
            StartTime.AutoSize = true;
            StartTime.Location = new Point(285, 102);
            StartTime.Name = "StartTime";
            StartTime.Size = new Size(57, 15);
            StartTime.TabIndex = 4;
            StartTime.Text = "StartTime";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(285, 146);
            label4.Name = "label4";
            label4.Size = new Size(73, 15);
            label4.TabIndex = 5;
            label4.Text = "ProcessTime";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(285, 190);
            label5.Name = "label5";
            label5.Size = new Size(105, 15);
            label5.TabIndex = 6;
            label5.Text = "NumberOfThreads";
            // 
            // textBox1
            // 
            textBox1.Enabled = false;
            textBox1.Location = new Point(285, 32);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(170, 23);
            textBox1.TabIndex = 7;
            // 
            // textBox2
            // 
            textBox2.Enabled = false;
            textBox2.Location = new Point(285, 76);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(170, 23);
            textBox2.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(285, 234);
            label6.Name = "label6";
            label6.Size = new Size(92, 15);
            label6.TabIndex = 9;
            label6.Text = "NumberOfCopy";
            // 
            // textBox3
            // 
            textBox3.Enabled = false;
            textBox3.Location = new Point(285, 120);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(170, 23);
            textBox3.TabIndex = 11;
            // 
            // textBox4
            // 
            textBox4.Enabled = false;
            textBox4.Location = new Point(285, 164);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(170, 23);
            textBox4.TabIndex = 12;
            // 
            // textBox5
            // 
            textBox5.Enabled = false;
            textBox5.Location = new Point(285, 208);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(170, 23);
            textBox5.TabIndex = 13;
            // 
            // textBox6
            // 
            textBox6.Enabled = false;
            textBox6.Location = new Point(285, 252);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(170, 23);
            textBox6.TabIndex = 14;
            // 
            // button2
            // 
            button2.Location = new Point(380, 413);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 16;
            button2.Text = "Add";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(489, 32);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(54, 23);
            numericUpDown1.TabIndex = 17;
            numericUpDown1.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(474, 14);
            label8.Name = "label8";
            label8.Size = new Size(84, 15);
            label8.TabIndex = 18;
            label8.Text = "UpdateInterval";
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(575, 450);
            Controls.Add(label8);
            Controls.Add(numericUpDown1);
            Controls.Add(button2);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(label6);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(StartTime);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(listBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox1;
        private Button button1;
        private Label label1;
        private Label label2;
        private Label StartTime;
        private Label label4;
        private Label label5;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label6;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private Button button2;
        private NumericUpDown numericUpDown1;
        private Label label8;
        private System.Windows.Forms.Timer timer1;
    }
}
