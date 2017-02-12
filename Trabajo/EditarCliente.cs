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
    public partial class EditarCliente : Form
    {
        string id;

        public EditarCliente(string id, string nombre, string telefono, string direccion, string calle, string colonia)
        {
            InitializeComponent();

            this.id = id;

            txtNombreC.Text = nombre;
            txtTelC.Text = telefono;
            txtEntreC.Text = calle;
            txtColoniaC.Text = colonia;
            txtDirC.Text = direccion;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Querys query = new Querys();

            int respuesta = query.EditarCliente(id, txtNombreC.Text, txtTelC.Text, txtDirC.Text, txtEntreC.Text, txtColoniaC.Text);

            if(respuesta == 1)
            {

                this.Close();
                MessageBox.Show("Los datos se editaron correctamente");
            }else
            {
                MessageBox.Show("Ocurrio un error vuelva a intentarlo");
            }
            
        }
    }
}
