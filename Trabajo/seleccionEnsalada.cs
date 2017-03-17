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
    public partial class seleccionEnsalada : Form
    {
        public List<SubProducto> ensaladas;
        public seleccionEnsalada()
        {
            InitializeComponent();
        }

        private void seleccionEnsalada_Load(object sender, EventArgs e)
        {
            SubProducto sp = new SubProducto();
            txtCod.Text = "1";
            txtPur.Text = "1";
            txtVer.Text = "1";
            txtCol.Text = "1";
            ensaladas = new List<SubProducto>();
            sp.nombre = "paq_pure";
            sp.idProductos = 26;
            sp.cantidad = 1;
            ensaladas.Add(sp);
            sp = new SubProducto();
            sp.nombre = "paq_verduras";
            sp.idProductos = 27;
            sp.cantidad = 1;
            ensaladas.Add(sp);
            sp = new SubProducto();
            sp.nombre = "paq_Codito";
            sp.idProductos = 28;
            sp.cantidad = 1;
            ensaladas.Add(sp);
            sp = new SubProducto();
            sp.nombre = "paq_Col";
            sp.idProductos = 29;
            sp.cantidad = 1;
            ensaladas.Add(sp);

        }

        private void btnVerMen_Click(object sender, EventArgs e)
        {
          
             ensaladas.ElementAt(1).cantidad--;
             txtVer.Text = Convert.ToString(ensaladas.ElementAt(1).cantidad);
        }

        private void btnVerMas_Click(object sender, EventArgs e)
        {
            ensaladas.ElementAt(1).cantidad++;
            txtVer.Text = Convert.ToString(ensaladas.ElementAt(1).cantidad);
        }

        private void btnColMen_Click(object sender, EventArgs e)
        {
            ensaladas.ElementAt(3).cantidad--;
            txtCol.Text = Convert.ToString(ensaladas.ElementAt(3).cantidad);
        }

        private void btnColMas_Click(object sender, EventArgs e)
        {
            ensaladas.ElementAt(3).cantidad++;
            txtCol.Text = Convert.ToString(ensaladas.ElementAt(3).cantidad);
        }

        private void btnCodMen_Click(object sender, EventArgs e)
        {
            ensaladas.ElementAt(2).cantidad--;
            txtCod.Text = Convert.ToString(ensaladas.ElementAt(2).cantidad);
        }

        private void btnCodMas_Click(object sender, EventArgs e)
        {
            ensaladas.ElementAt(2).cantidad++;
            txtCod.Text = Convert.ToString(ensaladas.ElementAt(2).cantidad);
        }

        private void btnPurMen_Click(object sender, EventArgs e)
        {
            ensaladas.ElementAt(0).cantidad--;
            txtPur.Text = Convert.ToString(ensaladas.ElementAt(0).cantidad);
        }

        private void btnPurMas_Click(object sender, EventArgs e)
        {
            ensaladas.ElementAt(0).cantidad++;
            txtPur.Text = Convert.ToString(ensaladas.ElementAt(0).cantidad);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
