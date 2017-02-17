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
        Producto prod;
        public int operacion;
        public ProductosAdmin()
        {
            InitializeComponent();
            operacion = 0;
            prod = new Producto();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            
                Querys query = new Querys();
                int resultado = 0;
                prod.nombre = txtNombreProducto.Text;
                prod.tipo = txtTipoProducto.Text;
                prod.precio = Convert.ToDecimal(txtPrecio.Text);
                if (prod.nombre == "" || prod.tipo == "")
                {
                    MessageBox.Show("Ingresa todo los datos");
                    return;
                }
            if (operacion == 1)
                resultado = query.AgregarProducto(prod.nombre, prod.tipo, prod.precio);
            else
                resultado = query.EditarProducto(prod.id,prod.nombre, prod.tipo, prod.precio);
            if (resultado > 0)
                {
                    Close();
                    MessageBox.Show("Producto Actualizado");
                }
                else
                {
                    MessageBox.Show("Error al actualizar el producto");

                }
           
        }
        public void setProducto(Producto p)
        {
            prod = p;
        }

        private void ProductosAdmin_Load(object sender, EventArgs e)
        {
            if (operacion == 2)
            {
                txtNombreProducto.Text = prod.nombre;
                txtPrecio.Text = Convert.ToString(prod.precio);
                txtTipoProducto.Text = prod.tipo;
            }
        }
    }
}
