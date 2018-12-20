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
            textBox3.MaxLength = 5000;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //good
            if (button1.Text == "连接") { 

                string com_port = textBox1.Text;
                string baud_str = textBox2.Text;
                if (textBox1.Text == null || textBox1.Text.Trim() == "") return;
                if (textBox2.Text == null || textBox2.Text.Trim() == "") return;
                timer1.Interval = 200;
                serialPort1.PortName = com_port;
                serialPort1.BaudRate = int.Parse(baud_str);
                try { 
                    serialPort1.Open();
                    timer1.Start();
                }
                catch {
                    textBox3.Text = "打开串口出错！";
                    return;
                }

                button1.Text = "停止";


            }
            else
            {
                timer1.Stop();
                try
                {
                    serialPort1.Close();
                }
                catch {
                    textBox3.Text = "关闭串口出错！";
                    return;
                }
                button1.Text = "连接";

            }



        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string receive = serialPort1.ReadExisting();
            textBox3.AppendText(receive);
        }
    }
}
