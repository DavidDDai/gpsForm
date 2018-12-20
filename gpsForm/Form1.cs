using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gpsForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string com_port = textBox1.Text;
            string baud_str = textBox2.Text;
            if (textBox1.Text == null || textBox1.Text.Trim() == "") return;
            if (textBox2.Text == null || textBox2.Text.Trim() == "") return;
            serialPort1.PortName = com_port;
            serialPort1.BaudRate = int.Parse(baud_str);
            serialPort1.Open();
            
            
        }
    }
}
