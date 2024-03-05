using System.Diagnostics;

namespace LabWork01._03
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Process.Start("notepad.exe");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Process.Start("mspaint.exe");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(textBox1.Text != "")
            {
                Process.Start(textBox1.Text);
                textBox1.Text = "";
            }
        }
    }
}
