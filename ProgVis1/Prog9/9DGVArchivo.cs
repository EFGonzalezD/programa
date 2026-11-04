using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;
using System.IO;
using System.Windows.Forms;

namespace Prog9
{
    public partial class Form1 : Form
    {
        List<Alumno> l;
        public Form1()
        {
            InitializeComponent();
            l = new List<Alumno> ();
        }

        private void Mostrar()
        {
            try
            {
                if (!File.Exists("Datos.txt")) throw new Exception("Archivo denominado Datos no existe, se creará archivo nuevo");
            
                using (var sr = new StreamReader("Datos.txt"))
                {

                    string registro = "";
                    l.Clear ();
                    while((registro = sr.ReadLine()) != null)
                    {
                        var vector = registro.Split(',');
                        l.Add(new Alumno(vector[0], vector[1], vector[2]));                        
                    }
                    dataGridView1.DataSource = null; dataGridView1.DataSource = l;
                }
            }catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        public class Alumno
        {
            public Alumno(string pLegajo, string pNombre, string pApellido)
            {
                Legajo = pLegajo;
                Nombre = pNombre;   
                Apellido = pApellido;
            }

            public string Legajo { get; set; }
         
            public string Nombre { get; set; }

            public string Apellido { get; set; }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var legajo = Interaction.InputBox("Legajo:  ");
                if (!Information.IsNumeric(legajo)) { throw new Exception("Los legajos deben ser en formato númerico"); }
                if (Convert.ToInt16(legajo) < 1) { throw new Exception("Los legajos no pueden ser menores a 0(CERO)"); }

                foreach (DataGridViewRow r in dataGridView1.Rows)
                {
                    if (r.Cells[0].Value.ToString() == legajo) { throw new Exception("No se pueden cargar Legajos iguales"); }
                }

                var nombre = Interaction.InputBox("Nombre: ");
                var apellido = Interaction.InputBox("Apellido: ");
                using (var sw = new StreamWriter("Datos.txt", true)) 
                {
                    sw.WriteLine($"{legajo}, {nombre}, {apellido} ");
                }
                Mostrar();
            }catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.Rows.Count == 0) throw new Exception("No hay elementos para borrar");
                l.Remove(dataGridView1.SelectedRows[0].DataBoundItem as Alumno);

                using (var sw = new StreamWriter("Datos.txt"))
                {
                    l.ForEach(x  => sw.WriteLine($"{x.Legajo},{x.Nombre},{x.Apellido}"));
                }
                Mostrar();


            }catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if(dataGridView1.Rows.Count == 0) throw new Exception("No hay registros para modificar");
                var legajo = (dataGridView1.SelectedRows[0].DataBoundItem as Alumno).Legajo;

                var alumno = l.Find(x => x.Legajo == legajo);                

                alumno.Nombre = Interaction.InputBox("Nombre:  ", "Modificando nombre...", alumno.Nombre);

                alumno.Apellido = Interaction.InputBox("Apellido:  ", "Modificando apellido...", alumno.Apellido);


                using (var sw = new StreamWriter("Datos.txt"))
                {
                    l.ForEach (x => sw.WriteLine($"{x.Legajo},{x.Nombre},{x.Apellido}"));
                }
                Mostrar();

            }catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.MultiSelect = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            Mostrar();
        }
    }
}
