using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Pollos
{
    public partial class clienteAdmin : Form
    {
        public clienteAdmin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int resultado = 0;

            Querys query = new Querys();
            string nombre = txtNombreC.Text;
            string direccion = txtDirC.Text;
            string tel = txtTelC.Text;
            string colonia = txtColoniaC.Text;
            string entre = txtEntreC.Text;

            resultado = query.AgregarCliente(nombre, tel, direccion, colonia, entre);

            if(resultado > 0)
            {
                txtNombreC.Text = "";
                txtDirC.Text = "";
                txtTelC.Text = "";
                txtColoniaC.Text = "";
                txtEntreC.Text = "";

                this.Close();
                MessageBox.Show("EL cliente se a registrado");
            }
            else
            {
                MessageBox.Show("Error al registrar el cliente");
            }

        }
    }
}
