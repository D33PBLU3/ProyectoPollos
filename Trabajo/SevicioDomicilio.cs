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
        Clientes c;
        public SevicioDomicilio()
        {
            InitializeComponent();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            clienteAdmin admin = new clienteAdmin();
            admin.ShowDialog();
            Actualizar();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

        }

        private void Actualizar()
        {
            listClientes.Items.Clear();

            List<Clientes> lista = new List<Clientes>();

            Querys query = new Querys();

            string buscar = txtBuscar.Text;

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

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            Actualizar();
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

                EditarCliente editaCliente = new EditarCliente(id, nombre, tel, dir, calles, colonia);
                editaCliente.ShowDialog();
                Actualizar();

            }
            catch
            {
                MessageBox.Show("No se ha seleccionado algun cliente");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Querys query = new Querys();

            try
            {

                string id = listClientes.SelectedItems[0].SubItems[0].Text;

                int respuesta = query.EliminarCliente(id);

                if (respuesta == 1)
                {
                    listClientes.Items.Remove(listClientes.SelectedItems[0]);
                    MessageBox.Show("El cliente se ha eliminado");
                }
                else
                {
                    MessageBox.Show("Ocurrio un error vuelva a intentarlo");
                }
            }
            catch
            {
                MessageBox.Show("No se ha seleccionado algun cliente");
            }
        }

        private void listClientes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void gridProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            double auxTotal = 0;
            double total = 0;

            for(int i = 0; i < gridProductos.RowCount - 1; i++)
            {
                auxTotal = Convert.ToDouble(gridProductos.Rows[i].Cells[3].Value) * Convert.ToDouble(gridProductos.Rows[i].Cells[4].Value);

                total = total + auxTotal;
                
                labelTotal.Text = Convert.ToString(total);
            }
        }

        private void SevicioDomicilio_Load(object sender, EventArgs e)
        {
            listClientes.FullRowSelect = true;
            Actualizar();
            DateTime Hoy = DateTime.Today;
            string fecha_actual = Hoy.ToString("dd-MM-yyyy");
            lbFecha.Text = fecha_actual;
        }

        private void gridProductos_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void gridProductos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
            buscarProductos bp = new buscarProductos();
            bp.ShowDialog();
            if (bp.encontrado)
            {
                DataGridViewRow row = (DataGridViewRow)gridProductos.Rows[0].Clone();
                row.Cells[0].Value = Convert.ToString(bp.p.id);
                row.Cells[1].Value = bp.p.nombre;
                row.Cells[2].Value = bp.p.tipo;
                row.Cells[3].Value = Convert.ToString(bp.p.precio);
                row.Cells[4].Value = "1";
                
                gridProductos.Rows.Add(row);
            }
        }

        private void btnAceptarPedido_Click(object sender, EventArgs e)
        {
            Querys query = new Querys();
            if (c.id == "")
            {
                return;
            }
            else
            {
                long idped = query.AgregarPedido(Convert.ToInt32(c.id), txtComen.Text, Convert.ToDecimal(labelTotal.Text));

                for (int i = 0; i < gridProductos.RowCount - 1; i++)
                {
                    Decimal cant = Convert.ToDecimal(gridProductos.Rows[i].Cells[4].Value);
                    Decimal pre = Convert.ToDecimal(gridProductos.Rows[i].Cells[4].Value);
                    
                    int idpro = Convert.ToInt32(gridProductos.Rows[i].Cells[0].Value);
                    query.AgregarDetallePedido(cant, pre, Convert.ToInt32(idped), idpro);
                }

                MessageBox.Show("Pedido creado exitosamente");
                Close();
            }
           /* for (int i = 0; i < listClientes.Items.Count; i++)
            {
                if (listClientes.Items[i].Checked)
                {
                    c.id = listClientes.Items[i].Text;
                    c.nombre = listClientes.Items[i].SubItems[1].Text;
                    c.tel = listClientes.Items[i].SubItems[2].Text;


                }

            }*/
        }

        private void listClientes_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            /*  bool check;
              check = e.Item.Checked;
              for (int i = 0; i < listClientes.Items.Count; i++)
              {
                  listClientes.Items[i].Checked = false;

              }
              e.Item.Checked = check;
          }*/
        }

        private void listClientes_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            c = new Clientes();
            if (e.NewValue == CheckState.Checked)
            {
                c.id = listClientes.Items[e.Index].Text;
                c.nombre = listClientes.Items[e.Index].SubItems[1].Text;
                c.tel= listClientes.Items[e.Index].SubItems[2].Text;
                c.direccion= listClientes.Items[e.Index].SubItems[3].Text;
                c.calles=listClientes.Items[e.Index].SubItems[4].Text;
                c.colonia= listClientes.Items[e.Index].SubItems[5].Text;
                lbNomCliente.Text = c.nombre;
                for (int ix = 0; ix < listClientes.Items.Count; ++ix)
                    if (e.Index != ix) listClientes.Items[ix].Checked = false;

            }
        }
    }
    }
