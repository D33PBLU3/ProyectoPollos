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
    public partial class adminClientes : Form
    {
        public adminClientes()
        {
            InitializeComponent();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            clienteAdmin admin = new clienteAdmin();
            admin.ShowDialog();
            Actualizar();
        }
        private void Actualizar()
        {
            listClientes.Items.Clear();

            List<Clientes> lista = new List<Clientes>();

            Querys query = new Querys();

            string buscar = "";

            lista = query.BuscarCliente(buscar);

            int cont = 0;

            if (lista.Count == 0)
            {
            }
            else
            {
                foreach (Clientes cliente in lista)
                {
                    listClientes.Items.Add(cliente.id, 0);
                    listClientes.Items[cont].SubItems.Add(cliente.nombre);
                    listClientes.Items[cont].SubItems.Add(cliente.tel);
                    listClientes.Items[cont].SubItems.Add(cliente.direccion);
                    listClientes.Items[cont].SubItems.Add(cliente.calles);
                    listClientes.Items[cont].SubItems.Add(cliente.colonia);

                    cont++;
                }
            }
        }

        private void adminClientes_Load(object sender, EventArgs e)
        {
            Actualizar();
            listClientes.FullRowSelect = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string id = listClientes.SelectedItems[0].SubItems[0].Text;
                string nombre = listClientes.SelectedItems[0].SubItems[1].Text;
                string tel = listClientes.SelectedItems[0].SubItems[2].Text;
                string dir = listClientes.SelectedItems[0].SubItems[3].Text;
                string calles = listClientes.SelectedItems[0].SubItems[4].Text;
                string colonia = listClientes.SelectedItems[0].SubItems[5].Text;




                if (id == "")
                {
                    MessageBox.Show("No se ha seleccionado algun cliente");
                }
                else
                {

                    EditarCliente editaCliente = new EditarCliente(id, nombre, tel, dir, calles, colonia);
                    editaCliente.ShowDialog();
                    Actualizar();
                }

            }
            catch
            {
                MessageBox.Show("No se ha seleccionado algun cliente");
            }
        }
    }
}
