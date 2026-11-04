using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prog1
{
    public partial class AcColor : Form
    {
        public AcColor()
        {
            InitializeComponent();
            foreach (Control c in this.Controls) //Para toda la colección de controles "C" dentro del formulario
            {

                if (c is GroupBox) //Si "C" es un GroupBox
                {
                    foreach (Control cg in (c as GroupBox).Controls) // Y para cada colección de controles "CG" en cada "C"="GroupBox"
                    {
                        if (cg is RadioButton) (cg as RadioButton).CheckedChanged += ActualizaColor; //si "CG" es RadioButton y "CG" cambia su chequeo                                                                                                  //llamar a ActualizarColor
                    }                                                                                //llamar a ActualizaColor
                }

                if (c is NumericUpDown) (c as NumericUpDown).ValueChanged += ActualizaColor;//si "C" es NumericUpDown y "C" como NumericUpDown esta chequeado
                                                                                            //llamar a ActualizaColor
            }
        }


        private void ActualizaColor(object sender, EventArgs e) //Función que no retorna valor
        {

            int rojo = 0, verde = 0, azul = 0; //Declaración de variables en el ámbito de la función
            
            if (radioButton1.Checked) rojo= Convert.ToInt16(numericUpDown1.Value);//Si RadioButton1 está chequeado, la variable Rojo tomará valor del NumericUpDown1 convertido a entero
            if (radioButton2.Checked) verde= Convert.ToInt16(numericUpDown2.Value);//Si RadioButton2 está chequeado, la variable Verde tomará valor del NumericUpDown2 convertido a entero
            if (radioButton3.Checked) azul= Convert.ToInt16(numericUpDown3.Value);//Si RadioButton3 está chequeado, la variable Azul tomará valor del NumericUpDown3 convertido a entero

            pictureBox1.BackColor=Color.FromArgb(rojo,verde,azul); //En la propíedad backcolor del control picturebox asigno color por el metodo FromArgb definido por el valor combinado de cada variable 


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //foreach (Control c in this.Controls) //Para toda la colección de controles "C" dentro del formulario
            //{

            //    if (c is GroupBox) //Si "C" es un GroupBox
            //    {
            //        foreach(Control cg in (c as GroupBox).Controls) // Y para cada colección de controles "CG" en cada "C"="GroupBox"
            //        {
            //            if (cg is RadioButton) (cg as RadioButton).CheckedChanged += ActualizaColor; //si "CG" es RadioButton y "CG" cambia su chequeo                                                                                                  //llamar a ActualizarColor
            //        }                                                                                //llamar a ActualizaColor
            //    }

            //    if (c is NumericUpDown) (c as NumericUpDown).ValueChanged += ActualizaColor;//si "C" es NumericUpDown y "C" como NumericUpDown esta chequeado
            //                                                                                //llamar a ActualizaColor
            //}
        }



    }
}
