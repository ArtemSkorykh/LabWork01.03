using Microsoft.VisualBasic;
using System.Diagnostics;
using System.Windows.Forms;

namespace LabWork01._03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }


        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDown1.Value > 0)
            {
                timer1.Interval = Convert.ToInt32(numericUpDown1.Value) * 1000;
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (numericUpDown1.Value > 0)
            {
                listBox1.Items.Clear();

                foreach (var process in Process.GetProcesses())
                {
                    listBox1.Items.Add(process.ProcessName);
                }
            }


        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                string selectedProcessName = listBox1.SelectedItem.ToString();
                Process[] processes = Process.GetProcessesByName(selectedProcessName);
                if (processes.Length > 0)
                {
                    Process selectedProcess = processes[0];
                    textBox1.Text = selectedProcess.Id.ToString();
                    textBox2.Text = selectedProcess.ProcessName;
                    textBox3.Text = selectedProcess.StartTime.ToString();
                    textBox4.Text = selectedProcess.TotalProcessorTime.ToString();
                    textBox5.Text = selectedProcess.Threads.Count.ToString();
                    textBox6.Text = processes.Length.ToString();
                }

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                string selectedProcessName = listBox1.SelectedItem.ToString();
                Process[] processes = Process.GetProcessesByName(selectedProcessName);
                if (processes.Length > 0)
                {
                    foreach(var pr in processes)
                    {
                        pr.Kill();
                    }
                }

                listBox1.Items.Clear();

                foreach (var process in Process.GetProcesses())
                {
                    listBox1.Items.Add(process.ProcessName);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            this.Hide();
            form2.Show();


        }
    }
}

