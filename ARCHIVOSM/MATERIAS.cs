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
    public partial class MATERIAS : Form
    {
        public MATERIAS()
        {
            InitializeComponent();
        }
         
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.Rows.Add(textBox1.Text, comboBox3.Text, comboBox2.Text);
            textBox1.Text = "";
            comboBox2.Text = "";
            comboBox3.Text = "";
        }
        private void btnALTA_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add(textBox1.Text, comboBox3.Text, comboBox2.Text);
            textBox1.Text = "";
            comboBox2.Text = "";
            comboBox3.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            comboBox2.Items.Clear();
            comboBox3.Items.Clear();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
        }
    }
    }
