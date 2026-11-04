using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgA2
{
    public partial class A2AACC : Form
    {
        GestorAlumnos gestorAlumnos;
        GestorNota gestorNotas;


        public A2AACC()
        {
            InitializeComponent();
            gestorAlumnos = new GestorAlumnos();
            gestorNotas = new GestorNota();
            MostrarAlumnos();
            MostrarNotas();
        }

        void MostrarAlumnos()
        {
            this.grillaAlumnos.DataSource = null;
            this.grillaAlumnos.DataSource = gestorAlumnos.LeerAlumnos();

        }

        void MostrarNotas()
        {
            this.grillaNotas.DataSource = null;
            this.grillaNotas.DataSource = gestorNotas.LeerNotas();
        }

        private void btnGuardarAlumno_Click(object sender, EventArgs e)
        {
            Alumno unAlumno = new Alumno((int) this.numLegajo.Value, this.txtApellido.Text);
            gestorAlumnos.GuardarAlumno(unAlumno);
            MostrarAlumnos();
        }

        private void btnGuardarNota_Click(object sender, EventArgs e)
        {
            Nota unaNota = new Nota((int)numLegajo2.Value, (int)numNota.Value);
            gestorNotas.GuardarNota(unaNota);
            MostrarNotas();
        }

        private void btnPromedios_Click(object sender, EventArgs e)
        {
            Alumno[] alumnos = gestorAlumnos.Ordenar();
            Nota[] notas = gestorNotas.Ordenar();

            List<Promedio> promedios = new List<Promedio>();


            for (int i = 0; i < alumnos.Length; i++)
            {
                Promedio p = new Promedio();
                p.Apellido = alumnos[i].Apellido;
                p.Legajo = alumnos[i].Legajo;

                int contador = 0;
                int acumulador = 0;
                
                for (int x = 0; x < notas.Length; x++)
                {
                    if (notas[x].Legajo == alumnos[i].Legajo)
                    {
                        contador ++;
                        acumulador += notas[x].ValorNota;
                    }
                }

                p.ValorPromedio = contador == 0 ? 0 : acumulador / contador;
                promedios.Add(p);
            }

            grillaPromedios.DataSource = null;
            grillaPromedios.DataSource = promedios;
        }
    }
}
