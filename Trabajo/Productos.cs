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
    public partial class Productos : Form
    {
        public Productos()
        {
            InitializeComponent();
            listProductos.FullRowSelect = true;
        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            ProductosAdmin pAdmin = new ProductosAdmin();
            pAdmin.Show();
        }
    }
}
