using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prog3
{
    public partial class Timer : Form
    {
        public Timer()
        {
            InitializeComponent();
        }

        int s = 0, m = 0, h = 0;

        private void hScrollBar1_ValueChanged(object sender, EventArgs e)
        {
            timer1.Interval = hScrollBar1.Value;
            Text = $"Milisegundos --> {hScrollBar1.Value}";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            hScrollBar1_ValueChanged(null, null);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            s++;
            if (s == 60) 
            {
                s= 0;
                m++;
                if(m == 60)
                {
                    m = 0;
                    h++;
                    if(h == 24) { h = 0; }
                }
            }

            textBox1.Text = h.ToString();
            textBox2.Text = m.ToString();
            textBox3.Text = s.ToString();

        }
    }
}
