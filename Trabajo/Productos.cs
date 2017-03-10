using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
//using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pollos
{
    public partial class Productos : Form
    {
        public Productos()
        {
            InitializeComponent();
            listProductos.FullRowSelect = true;
        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            /*ProductosAdmin pAdmin = new ProductosAdmin();
            pAdmin.operacion = 1; 
            pAdmin.ShowDialog();
            actualizar();*/
        }

        private void btnEditarProducto_Click(object sender, EventArgs e)
        {
            Producto prod=new Producto();
            try
            {
                prod.id = Convert.ToInt32(listProductos.SelectedItems[0].SubItems[0].Text);
                prod.nombre = listProductos.SelectedItems[0].SubItems[1].Text;
                prod.tipo = listProductos.SelectedItems[0].SubItems[2].Text;
                prod.precio = Convert.ToDecimal(listProductos.SelectedItems[0].SubItems[3].Text);

                ProductosAdmin productosAd = new ProductosAdmin();
                productosAd.setProducto(prod);
                productosAd.operacion = 2;
                productosAd.ShowDialog();
                actualizar();
            }
           catch
           {
                MessageBox.Show("No se ha seleccionado algun producto");
           }
        }
        private void btnEliminarProducto_Click(object sender, EventArgs e)
        {
            Producto prod = new Producto();
            Querys query = new Querys();
            int resultado;
            try
            {
                prod.id = Convert.ToInt32(listProductos.SelectedItems[0].SubItems[0].Text);
                prod.nombre = listProductos.SelectedItems[0].SubItems[1].Text;
                prod.tipo = listProductos.SelectedItems[0].SubItems[2].Text;
                prod.precio = Convert.ToDecimal(listProductos.SelectedItems[0].SubItems[3].Text);
                resultado=query.EliminarProducto(Convert.ToString(prod.id));
 
                actualizar();
            }
            catch
            {
                MessageBox.Show("No se ha seleccionado algun producto");
            }
        }

        public void actualizar()
        {
            listProductos.Items.Clear();
            Querys query=new Querys();
            List<Producto> lista;
            lista = query.getProductos();
            int cont = 0;
            if (lista.Count == 0)
            {
            }
            else
            {
                foreach (Producto p in lista)
                {
                    listProductos.Items.Add(Convert.ToString(p.id), 0);
                    listProductos.Items[cont].SubItems.Add(p.nombre);
                    listProductos.Items[cont].SubItems.Add(p.tipo);
                    listProductos.Items[cont].SubItems.Add(Convert.ToString(p.precio));
                    

                    cont++;
                }
            }
        }

        private void Productos_Load(object sender, EventArgs e)
        {
            actualizar();
        }

       
    }
}
