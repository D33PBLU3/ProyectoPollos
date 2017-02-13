using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pollos
{
    public partial class ProductosAdmin : Form
    {
        public ProductosAdmin()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Querys query = new Querys();
            int resultado = 0;
            string nombre = txtNombreProducto.Text;
            string tipo = txtTipoProducto.Text;
            Decimal precio = Convert.ToDecimal(txtPrecio.Text);
            if (nombre == "" || tipo == "")
            {
                MessageBox.Show("Ingresa todo los datos");
                return;
            }
            resultado = query.AgregarProducto(nombre, tipo, precio);
            if (resultado > 0)
            {
                Close();
                MessageBox.Show("Producto registrado");
            }
            else
            {
                MessageBox.Show("Error al registrar el producto");

            }
        }
    }
}
