using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prog2
{
    public partial class Helad : Form
    {
        decimal[] precio = { 100m, 50m, 1000m };


        public Helad()
        {
            InitializeComponent();
            checkBox1.CheckedChanged += ActualizaTexto;
            checkBox2.CheckedChanged += ActualizaTexto;
            checkBox3.CheckedChanged += ActualizaTexto;
            radioButton1.CheckedChanged += ActualizaTexto;
            radioButton2.CheckedChanged += ActualizaTexto;
            radioButton3.CheckedChanged += ActualizaTexto;
        }

        private void ActualizaTexto(object sender, EventArgs e)
        {

            string s = "";
            int c = 0;

            if (checkBox1.Checked) { s += $"{checkBox1.Text} -  ";c++; }
            if (checkBox2.Checked) { s += $"{checkBox2.Text} -  "; c++; }
            if (checkBox3.Checked) { s += $"{checkBox3.Text} -  "; c++; }

            if (radioButton1.Checked) { s += $"A Pagar: $ {precio[0] * c}"; }
            if (radioButton2.Checked) { s += $"A Pagar: $ {precio[1] * c}"; }
            if (radioButton3.Checked) { s += $"A Pagar: $ {precio[2] * c}"; }

            textBox1.Text = s;
        }

    }
}
