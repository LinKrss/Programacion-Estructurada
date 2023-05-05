using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ARCHIVOSM
{
    public partial class PROFESOR : Form
    {
        public Label Label1 { get; }

        public PROFESOR(Label Label1 = null)
        {
           InitializeComponent();
            this.Label1 = Label1;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.Rows.Add(textBox1.Text, textBox2.Text, textBox3.Text);
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }
    }
     
}
 
