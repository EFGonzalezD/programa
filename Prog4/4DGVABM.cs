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

namespace Prog4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {

                if (dataGridView1.Rows.Count == 0) throw new Exception("No hay elementos para modificar");

                var fila = dataGridView1.SelectedRows[0];
                fila.Cells[1].Value = Interaction.InputBox("Nombre:  ", "Ingresando Nombre", fila.Cells[1].Value.ToString());
                fila.Cells[2].Value = Interaction.InputBox("Apellido:  ", "Ingresando Apellido", fila.Cells[2].Value.ToString());

            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.MultiSelect = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {

                var legajo = Interaction.InputBox("Legajo:  ", "Ingresando legajo");
                if (!Information.IsNumeric(legajo)) { throw new Exception("Legajo debe ser numerico"); }
                if (Convert.ToInt16(legajo) < 1) { throw new Exception("Legajo debe ser mayor a cero"); }

                foreach (DataGridViewRow r in dataGridView1.Rows)
                {
                    if (r.Cells[0].Value.ToString() == legajo) { throw new Exception("No se pueden crear legajos iguales"); }
                }

                var nombre = Interaction.InputBox("Nombre:  ", "Ingresando Nombre");
                var apellido = Interaction.InputBox("Apellido: ", "Ingresando Apellido");
                var fecnac = dateTimePicker1.Value;
                var edad = (DateTime.Now - fecnac).Days / 365;

                dataGridView1.Rows.Add(new object[] { legajo, nombre, apellido, fecnac.ToShortDateString(), edad });



            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }



        }

        private void button2_Click(object sender, EventArgs e)
        {

            try
            {

                if (dataGridView1.Rows.Count == 0) throw new Exception("No hay elemento para borrar");

                DataGridViewRow dr = dataGridView1.SelectedRows[0];
                if (MessageBox.Show($"Esta seguro de borrar el elemento: {dr.Cells[0].Value} {dr.Cells[1].Value} {dr.Cells[2].Value}", "Borrando Elemento", MessageBoxButtons.YesNo) == DialogResult.Yes) ;
                { dataGridView1.Rows.Remove(dr); }


            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }           
        } 
    }
}
