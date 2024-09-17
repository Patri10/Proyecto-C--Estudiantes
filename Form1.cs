using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_estudiantes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        ArrayList lista_alumnos = new ArrayList();

        private void boton_agregar_Click(object sender, EventArgs e)
        {


            if (lista_alumnos.Count == 20)
            {
                MessageBox.Show("No se pueden agregar mas alumnos");
                return;
            }

            Estudiantes alumnos = new Estudiantes();

            alumnos.Nombre = text_nombre.Text;

            if (alumnos.Nombre.Trim().Length == 0)
            {
                MessageBox.Show("Falta el nombre");
                return;

            }

            int legajo = 0;

            if (!int.TryParse(text_legajo_agregar.Text, out legajo))
            {
                MessageBox.Show("Falta el legajo");
                return;
            }

            alumnos.Legajo = legajo;


            lista_alumnos.Add(alumnos);



            text_nombre.Text = "";
            text_legajo_agregar.Text = "";
            MessageBox.Show("Alumno agregado");

            Mostrar(text_nombre, label_estudiantes, label_legajo);

            //label_legajo.Text += "\n" +  ($"{legajo} ");

            //label_estudiantes.Text += "\n" +  ($"{alumnos.Nombre}");

        }

        private void boton_eliminar_Click(object sender, EventArgs e)
        {
            if (int.TryParse(text_legajo_bor.Text, out int legajo))
            {
                Estudiantes alumnoAEliminar = null;

                
                foreach (Estudiantes al in lista_alumnos)
                {
                    if (al.Legajo == legajo)
                    {
                        alumnoAEliminar = al;
                        break;
                    }
                }

                if (alumnoAEliminar != null)
                {
                    lista_alumnos.Remove(alumnoAEliminar);
                    Mostrar(text_legajo_bor, label_estudiantes, label_legajo); 
                }
                else
                {
                   
                    MessageBox.Show("No se encontró el alumno con ese legajo.");
                }
            }

           

        }

        void Mostrar(TextBox caja, Label label_1, Label label_2)
        {
            label_estudiantes.Text = "";
            label_legajo.Text = "";

            caja.Focus();
            for (int i = 0; i < lista_alumnos.Count; i++)
            {
                if (lista_alumnos[i] is Estudiantes est)
                {
                    label_estudiantes.Text += ($"{est.Nombre} \n");
                    label_legajo.Text += ($"{est.Legajo} \n");
                }

            }

        }

        private void boton_buscar_Click(object sender, EventArgs e)
        {
            if (int.TryParse(text_legajo_bor.Text, out int legajo_buscado))
            {
                for (int i = 0; i < lista_alumnos.Count; i++)
                {
                    if (lista_alumnos[i] is Estudiantes est)
                    {
                        if (est.Legajo == legajo_buscado)
                        {
                            MessageBox.Show($"{est.Legajo} {est.Nombre}");
                            return;
                        }
                    }

                }


                MessageBox.Show("No se encontro el estudiante");
            }

         

            

        }

       
    }


    class Estudiantes
    {
        public string Nombre;
        public int Legajo;

    }
}
