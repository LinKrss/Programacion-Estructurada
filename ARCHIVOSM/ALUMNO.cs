using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ARCHIVOSM
{
    public partial class ALUMNO : Form
    {
 
        private ALUMNO alumnoss;

        public string Nombre { get; internal set; }
        public string Horas { get; internal set; }
    
        public object DNI { get; internal set; }

        public ALUMNO()
        {
            InitializeComponent();
        }
        public ALUMNO(string text)
        {
            Text = text;
        }

        public ALUMNO(ALUMNO alumnoss)
        {
            this.alumnoss = alumnoss;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.Rows.Add(textBox1.Text, textBox2.Text, textBox3.Text);
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }

        private void btnALTA_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add(textBox1.Text, textBox2.Text, textBox3.Text);
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
        }

        internal static void Baja(DataGridViewTextBoxColumn dNI)
        {
            throw new NotImplementedException();
        }

        internal static void Baja(object dns)
        {
            throw new NotImplementedException();
        }
    }
}
