using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using Microsoft.VisualBasic;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prog7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Lista lista;

        private void Form1_Load(object sender, EventArgs e)
        {
            lista = new Lista();
        }

        private void Mostrar()
        {
            Auto aux = lista.PrimerAuto();
            listBox1.Items.Clear();
            if (aux != null) 
            {
                do
                {
                    listBox1.Items.Add(aux.ToString());
                    if (aux.Siguiente == null) break;

                    else aux = aux.Siguiente;


                } while (true);
            }

            textBox1.Text = lista.Cantidad().ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var patente = Interaction.InputBox("Patente:  ");
            var marca = Interaction.InputBox("Marca:  ");
            var modelo = Interaction.InputBox("Modelo:  ");

            lista.InsertarPrincipío(patente, marca, modelo);
            Mostrar();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var patente = Interaction.InputBox("Patente:  ");
            var marca = Interaction.InputBox("Marca:  ");
            var modelo = Interaction.InputBox("Modelo:  ");

            lista.InsertarFinal(patente, marca, modelo);
            Mostrar();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int pos = int.Parse(Interaction.InputBox("Posicion a ingresar:  "));
            var patente = Interaction.InputBox("Patente:  ");
            var marca = Interaction.InputBox("Marca:  ");
            var modelo = Interaction.InputBox("Modelo: ");

            lista.InsertarEnPosicionN(pos, patente, marca, modelo);
            Mostrar();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                var n = Interaction.InputBox("¿Que posición borrar?   ");
                if (!Information.IsNumeric(n)) throw new Exception("La posición debe ser númerica");
                lista.BorrarAutoPosN(Convert.ToInt32(n));
                Mostrar();

            } catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int pos1 = int.Parse(Interaction.InputBox("Posición 1 :  "));
            int pos2 = int.Parse(Interaction.InputBox("Posición 2 :  "));
            lista.Swap(pos1, pos2);
            Mostrar();
        }
    }
}
