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
            if(listBox1.SelectedIndex != -1)
            {
                Process [] processesByName = Process.GetProcessesByName(listBox1.Items[listBox1.SelectedIndex].ToString());
                if(processesByName.Length > 0)
                {
                  labelid.Text =  processesByName[0].Id.ToString();
                  label_st.Text = processesByName[0].StartTime.ToString(" H:m:s:ff");
                }
            }
        }
    }
}
