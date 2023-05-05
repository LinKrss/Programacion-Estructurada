using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ARCHIVOSM
{
    public partial class MIUAI : Form
    {
        private List<Currso> Cursos = new List<Currso>();

        private int indice = -1; //Para indicar que esta fuera de la Lista
        public MIUAI()
        {
            InitializeComponent();
        }

        private void btnALTA_Click(object sender, EventArgs e)
        {
            Currso persona = new Currso();

            persona.Materia = textBox1.Text;
            persona.Alumno = comboBox2.Text;
            persona.Profesor = comboBox3.Text;
            Cursos.Add(persona);
            Actualizar();
            limpiarCampos();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Currso persona = new Currso();

            persona.Materia = textBox1.Text;
            persona.Alumno = comboBox2.Text;
            persona.Profesor = comboBox3.Text;
            if (indice > -1)
            {
                Cursos[indice] = persona;
                indice = -1;
            }

            else
            {
                Cursos.Add(persona);
            }

            Actualizar();
            limpiarCampos();
        }

        private void Actualizar()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = Cursos;
            dataGridView1.ClearSelection();

        }
        //Linkeo de forms
        private void button1_Click(object sender, EventArgs e)
        {
            MATERIAS ventana = new MATERIAS();
            ventana.Visible = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ALUMNO ventana = new ALUMNO();
            ventana.Visible = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            PROFESOR ventana = new PROFESOR();
            ventana.Visible = true;
        }

       
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if(indice > -1)
            {
                Cursos.RemoveAt(indice);
                Actualizar();
                limpiarCampos();
                indice = -1;
            }
            else
            {
                MessageBox.Show("Selecciones el registro a borrar");
            }
        }

        //Mostrar los datos en los boxs
        private void dataGridView1_DoubleClick(object sender, EventArgs e) 
        {
            DataGridViewRow reglon = dataGridView1.SelectedRows[0];
            indice = dataGridView1.Rows.IndexOf(reglon);
            Currso persona = Cursos[indice];
            textBox1.Text = persona.Materia;
            comboBox2.Text = persona.Alumno;
            comboBox3.Text = persona.Profesor;
        }

        private void limpiarCampos()
        {
            textBox1.Text = null;
            comboBox2.Text = null;
            comboBox3.Text = null;
        }
    }   
}
