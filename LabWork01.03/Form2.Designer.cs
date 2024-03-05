namespace LabWork01._03
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            button1 = new Button();
            label2 = new Label();
            button2 = new Button();
            label3 = new Label();
            button3 = new Button();
            label5 = new Label();
            textBox1 = new TextBox();
            label4 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.FlatStyle = FlatStyle.System;
            label1.Location = new Point(2, 51);
            label1.Name = "label1";
            label1.Size = new Size(99, 15);
            label1.TabIndex = 0;
            label1.Text = "Start notepad.exe";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.Control;
            button1.BackgroundImageLayout = ImageLayout.None;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Location = new Point(2, 68);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 1;
            button1.Text = "Start";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.FlatStyle = FlatStyle.System;
            label2.Location = new Point(2, 109);
            label2.Name = "label2";
            label2.Size = new Size(101, 15);
            label2.TabIndex = 2;
            label2.Text = "Start your process";
            // 
            // button2
            // 
            button2.BackColor = SystemColors.Control;
            button2.FlatStyle = FlatStyle.Popup;
            button2.Location = new Point(2, 127);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 3;
            button2.Text = "Start";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.FlatStyle = FlatStyle.System;
            label3.Location = new Point(142, 51);
            label3.Name = "label3";
            label3.Size = new Size(82, 15);
            label3.TabIndex = 4;
            label3.Text = "Start paint.exe";
            // 
            // button3
            // 
            button3.BackColor = SystemColors.Control;
            button3.FlatStyle = FlatStyle.Popup;
            button3.Location = new Point(142, 69);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 5;
            button3.Text = "Start";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(2, 9);
            label5.Name = "label5";
            label5.Size = new Size(160, 28);
            label5.TabIndex = 8;
            label5.Text = "Add new process";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(2, 155);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(222, 23);
            textBox1.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(143, 137);
            label4.Name = "label4";
            label4.Size = new Size(81, 15);
            label4.TabIndex = 10;
            label4.Text = "Local address:";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(230, 190);
            Controls.Add(label4);
            Controls.Add(textBox1);
            Controls.Add(label5);
            Controls.Add(button3);
            Controls.Add(label3);
            Controls.Add(button2);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Form2";
            FormClosing += Form2_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private Label label2;
        private Button button2;
        private Label label3;
        private Button button3;
        private Label label5;
        private TextBox textBox1;
        private Label label4;
    }
}