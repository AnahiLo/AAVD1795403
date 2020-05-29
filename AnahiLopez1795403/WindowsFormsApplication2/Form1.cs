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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
          var id = Int32.Parse(textBox1.Text);
          var conn = new EnlaceCassandra();
          conn.EliminarDato(id);

          MessageBox.Show("Registro Eliminado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            textBox1.Text = "";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

       

        private void button3_Click(object sender, EventArgs e)
        {
            var id = Int32.Parse(textBox2.Text);
            var conn = new EnlaceCassandra();
            conn.EliminarNombre(id);

            MessageBox.Show("Nombre Eliminado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            textBox2.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var id = Int32.Parse(textBox2.Text);
            var conn = new EnlaceCassandra();
            conn.EliminarPrecio(id);

            MessageBox.Show("Precio Eliminado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            textBox2.Text = "";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var id = Int32.Parse(textBox2.Text);
            var conn = new EnlaceCassandra();
            conn.EliminarStock(id);

            MessageBox.Show("Stock Eliminado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            textBox2.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var id = Int32.Parse(textBox2.Text);
            var conn = new EnlaceCassandra();
            conn.EliminarSucursal(id);

            MessageBox.Show("Sucursal Eliminado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            textBox2.Text = "";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            var conn = new EnlaceCassandra();
            conn.EliminarTodo();

            MessageBox.Show("Todos los datos de la tabla se eliminaron", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
    }
}
