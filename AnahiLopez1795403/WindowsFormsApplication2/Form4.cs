using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form4 : Form
    {
        public EnlaceDB conexion;

        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var id = Int32.Parse(textBox1.Text);
            var nombre = textBox2.Text;
            var precio = Int32.Parse(textBox3.Text);
            var stock = Int32.Parse(textBox4.Text);
            var sucursal = textBox5.Text;
            
          
            var conn = new EnlaceCassandra();
            conn.InsertaDatos(id,nombre,precio,stock,sucursal);


            MessageBox.Show("Registro Agregado","Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
        }

        private void btnGetAll_Click(object sender, EventArgs e)
        {
            var conn = new EnlaceCassandra();
            List<Producto> lst1 = new List<Producto>();
            lst1 = conn.Get_All();
   
        }

        private void btnID_Click(object sender, EventArgs e)
        {
            //int id = (int)cboEjemplo.SelectedValue;
            /*
            var id = cboEjemplo.SelectedValue;
            label1.Text = id.ToString();
            */

            var x = new EnlaceCassandra();
           // x.GetOne();

        }

        private void lblTexto_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var x = new EnlaceCassandra();
            List<Producto> lst1 = new List<Producto>();
            lst1 = x.Get_All();

            dataGridView1.DataSource = lst1;
            conexion = null;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
           

            Form1 form = new Form1();

            form.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.Show();
        }
    }
}
