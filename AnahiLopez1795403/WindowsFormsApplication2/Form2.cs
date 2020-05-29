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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var id = Int32.Parse(textBox1.Text);
            var nombre = textBox2.Text;
            var conn = new EnlaceCassandra();
            conn.EditarNombre(id,nombre);

            MessageBox.Show("Se modifico el nombre con exito", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var id = Int32.Parse(textBox1.Text);
            var precio = Int32.Parse(textBox3.Text);
            var conn = new EnlaceCassandra();
            conn.EditarPrecio(id,precio);

            MessageBox.Show("Se modifico el precio con exito", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            textBox1.Text = "";
            textBox3.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var id = Int32.Parse(textBox1.Text);
            var stock = Int32.Parse(textBox4.Text);
            var conn = new EnlaceCassandra();
            conn.EditarStock(id,stock);

            MessageBox.Show("Se modifico el stock con exito", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            textBox1.Text = "";
            textBox4.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var id = Int32.Parse(textBox1.Text);
            var sucursal = textBox5.Text;
            var conn = new EnlaceCassandra();
            conn.EditarSucursal(id, sucursal);

            MessageBox.Show("Se modifico la sucursal con exito", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            textBox1.Text = "";
            textBox5.Text = "";
        }
    }
}
