using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;
using System.Windows.Forms;

namespace Prog6
{
    public partial class Form1 : Form
    {
        Pila po, pa;
        public Form1()
        {
            InitializeComponent();
            po = new Pila();
            pa = new Pila();
        }

        private void Mostrar()
        {
            listBox1.Items.Clear();
            if (po.Ver()!=null )
            {
                MostrarRecursiva(po.Desapilar());
                RestaurarRecursiva(pa.Desapilar());
            }
        }

        private void MostrarRecursiva(Nodo pNodo)
        {
            listBox1.Items.Add(pNodo.Id);
            pa.Apilar(pNodo.Id);
            if (po.Ver() != null) MostrarRecursiva(po.Desapilar());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            po.Apilar(Interaction.InputBox("ID: "));
            Mostrar();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            po.Desapilar();
            Mostrar();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Nodo aux = po.Ver();
            var msg = "No hay nada para ver";
            if (aux!= null) msg = $"Esta para ser desapilado el nodo: {aux.Id}";
            MessageBox.Show(msg);
        }

        private void RestaurarRecursiva(Nodo pNodo)
        {
            po.Apilar(pNodo.Id);
            if (pa.Ver() != null) RestaurarRecursiva(pa.Desapilar());
        }
    }
}
