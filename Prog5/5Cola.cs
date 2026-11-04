using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;
using System.Windows.Forms;

namespace Prog5
{
    public partial class Form1 : Form
    {
        Cola co, ca;
        public Form1()
        {
            InitializeComponent();
            co=new Cola();
            ca=new Cola ();
        }

        private void Mostrar()
        {
            listBox1.Items.Clear();
            if (co.Ver()!=null )
            {
                MostrarRecursiva(co.Desencolar());
                RestaurarRecursiva(ca.Desencolar());
            }
        }

        private void MostrarRecursiva(Nodo pNodo)
        {
            listBox1.Items.Add(pNodo.Id);
            ca.Encolar(pNodo.Id);
            if (co.Ver() != null) MostrarRecursiva(co.Desencolar());


        }

        private void RestaurarRecursiva(Nodo pNodo)
        {
            co.Encolar(pNodo.Id);
            if (ca.Ver()!=null ) RestaurarRecursiva(ca.Desencolar()); 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            co.Desencolar();
            Mostrar();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Nodo aux = co.Ver();
            var msg = "No hay para ver";
            if (aux!=null) msg =$"Está para ser desencolado en nodo: {aux.Id}";
            MessageBox.Show(msg);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            co.Encolar(Interaction.InputBox("Id: "));
            Mostrar();
        }






    }
}
