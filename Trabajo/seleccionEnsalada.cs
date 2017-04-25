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
        int totalEns;
        public seleccionEnsalada()
        {
            InitializeComponent();
        }
        
        private void seleccionEnsalada_Load(object sender, EventArgs e)
        {
            SubProducto sp = new SubProducto();
            txtCod.Text = "0";
            txtPur.Text = "0";
            txtVer.Text = "0";
            txtCol.Text = "0";
            totalEns = 0;
            ensaladas = new List<SubProducto>();
            sp.nombre = "paq_pure";
            sp.idProductos = 26;
            sp.cantidad = 0;
            ensaladas.Add(sp);
            sp = new SubProducto();
            sp.nombre = "paq_verduras";
            sp.idProductos = 27;
            sp.cantidad = 0;
            ensaladas.Add(sp);
            sp = new SubProducto();
            sp.nombre = "paq_Codito";
            sp.idProductos = 28;
            sp.cantidad = 0;
            ensaladas.Add(sp);
            sp = new SubProducto();
            sp.nombre = "paq_Col";
            sp.idProductos = 29;
            sp.cantidad = 0;
            ensaladas.Add(sp);

        }

        private void btnVerMen_Click(object sender, EventArgs e)
        {
          
             ensaladas.ElementAt(1).cantidad--;
             txtVer.Text = Convert.ToString(ensaladas.ElementAt(1).cantidad);
            totalEns--;
        }

        private void btnVerMas_Click(object sender, EventArgs e)
        {
            ensaladas.ElementAt(1).cantidad++;
            txtVer.Text = Convert.ToString(ensaladas.ElementAt(1).cantidad);
            totalEns++;
        }

        private void btnColMen_Click(object sender, EventArgs e)
        {
            ensaladas.ElementAt(3).cantidad--;
            txtCol.Text = Convert.ToString(ensaladas.ElementAt(3).cantidad);
            totalEns--;
        }

        private void btnColMas_Click(object sender, EventArgs e)
        {
            ensaladas.ElementAt(3).cantidad++;
            txtCol.Text = Convert.ToString(ensaladas.ElementAt(3).cantidad);
            totalEns++;
        }

        private void btnCodMen_Click(object sender, EventArgs e)
        {
            ensaladas.ElementAt(2).cantidad--;
            txtCod.Text = Convert.ToString(ensaladas.ElementAt(2).cantidad);
            totalEns--;
        }

        private void btnCodMas_Click(object sender, EventArgs e)
        {
            ensaladas.ElementAt(2).cantidad++;
            txtCod.Text = Convert.ToString(ensaladas.ElementAt(2).cantidad);
            totalEns++;
        }

        private void btnPurMen_Click(object sender, EventArgs e)
        {
            ensaladas.ElementAt(0).cantidad--;
            txtPur.Text = Convert.ToString(ensaladas.ElementAt(0).cantidad);
            totalEns--;
        }

        private void btnPurMas_Click(object sender, EventArgs e)
        {
            ensaladas.ElementAt(0).cantidad++;
            txtPur.Text = Convert.ToString(ensaladas.ElementAt(0).cantidad);
            totalEns++;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (totalEns != 4)
            {
                MessageBox.Show("Tienen que ser 4 ensaladas");
                return;
            }
            else
                Close();
        }
    }
}
