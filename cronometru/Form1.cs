using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace cronometru
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public DateTime startdatetime;
        public DateTime currentdatetime;

        private void button1_Click(object sender, EventArgs e)
        {
            startdatetime = new DateTime();
            startdatetime = DateTime.Now;
            textBox1.Text = startdatetime.ToShortTimeString();
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            currentdatetime = DateTime.Now;
            textBox2.Text = (currentdatetime - startdatetime).ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();

        }
    }
}
