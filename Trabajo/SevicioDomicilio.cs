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
    public partial class SevicioDomicilio : Form
    {
        public SevicioDomicilio()
        {
            InitializeComponent();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            clienteAdmin admin = new clienteAdmin();
            admin.Show();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            listClientes.Items.Clear();

            List<Clientes> lista = new List<Clientes>();

            Querys query = new Querys();

            string buscar = txtBuscar.Text;

            lista = query.BuscarCliente(buscar);

            int cont = 0;
            

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
}
