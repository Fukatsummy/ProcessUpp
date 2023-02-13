using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace ProcessUpp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Process killProcess = new Process();

        private void Form1_Load(object sender, EventArgs e)
        {
            UpdateProcessList();
        }
        public void UpdateProcessList()
        {
            Process[] processes = Process.GetProcesses();
            listBox1.Items.Clear();
            foreach (Process process in processes)//отображает список процессов
            {
                listBox1.Items.Add(process.ProcessName);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            UpdateProcessList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Interval = Int32.Parse(textBox1.Text) * 1000;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                int orderNumber = 0;
                int counter = 0;
                foreach (object obj in listBox1.Items)
                {

                    if ((string)obj == listBox1.Items[listBox1.SelectedIndex].ToString())
                    {
                        if (counter == listBox1.SelectedIndex)
                        {
                            break;
                        }
                        orderNumber++;
                    }
                    counter++;
                }
                Process[] processesByName = Process.GetProcessesByName(listBox1.Items[listBox1.SelectedIndex].ToString());
                if (processesByName.Length > 0)
                {
                    killProcess = processesByName[orderNumber];
                    labelid.Text = processesByName[orderNumber].Id.ToString();
                    label_time.Text = processesByName[orderNumber].StartTime.ToString(" H:m:s:ff");
                    label_ptime.Text = processesByName[orderNumber].TotalProcessorTime.ToString();
                    label_count.Text = processesByName[orderNumber].Threads.Count.ToString();
                    label_copy.Text = processesByName.Count().ToString();
                }
                foreach (Process process in processesByName)
                {
                    MessageBox.Show(process.GetHashCode().ToString());
                }
            }
        }
        private void btn_close_Click(object sender, EventArgs e)
        {
            killProcess.Kill();
        }

        private void tb_np_TextChanged(object sender, EventArgs e)
        {
            if(tb_np.Text.Length > 0)
            {
                btn_np.Enabled = true;
            }
            else
            {
                btn_np.Enabled = false;
            }
        }
        private void btn_np_Click(object sender, EventArgs e)
        {
            Process process = new Process();
            process.StartInfo = new ProcessStartInfo(tb_np.Text);
            process.Start();
        }
    }
}
