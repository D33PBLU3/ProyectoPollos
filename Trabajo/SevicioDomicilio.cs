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
    public partial class SevicioDomicilio : Form
    {
        List<Producto> lista;
        Decimal [] preciosProd;
        Clientes c;
        Decimal TotalPedido;
        Pedido pedido;
        List<Producto> listaProductos;
        public SevicioDomicilio()
        {
            InitializeComponent();
            TodosProductos();
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

        public void TodosProductos()
        {
            Querys query = new Querys();
            
            int cont = 0;
            lista = query.getProductos();
            if (lista.Count == 0)
            {
            }
            else
            {
                button3.Text = lista[0].nombre;
                button4.Text = lista[1].nombre;
                button5.Text = lista[2].nombre;
                button6.Text = lista[3].nombre;
                button7.Text = lista[4].nombre;
                button8.Text = lista[5].nombre;
                button9.Text = lista[6].nombre;
                button10.Text = lista[7].nombre;
                button11.Text = lista[8].nombre;
                button12.Text = lista[9].nombre;
                button13.Text = lista[10].nombre;
                button14.Text = lista[11].nombre;
                button15.Text = lista[12].nombre;
                button16.Text = lista[13].nombre;
                button17.Text = lista[14].nombre;
                button18.Text = lista[15].nombre;
                button19.Text = lista[16].nombre;
                button20.Text = lista[17].nombre;
                button21.Text = lista[18].nombre;
                button22.Text = lista[19].nombre;
                button23.Text = lista[20].nombre;

                preciosProd = new Decimal[22];

                foreach (Producto p in lista)
                {
                    preciosProd[cont] = p.precio;
                    
                    cont++;
                }
            }
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
            //Actualizar();
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
           /* double auxTotal = 0;
            double total = 0;

            for(int i = 0; i < gridProductos.RowCount - 1; i++)
            {
                auxTotal = Convert.ToDouble(gridProductos.Rows[i].Cells[3].Value) * Convert.ToDouble(gridProductos.Rows[i].Cells[4].Value);

                total = total + auxTotal;
                
                labelTotal.Text = Convert.ToString(total);
            }*/
        }

        private void SevicioDomicilio_Load(object sender, EventArgs e)
        {
            listClientes.FullRowSelect = true;
            Actualizar();
            listaProductos = new List<Producto>();
            pedido = new Pedido();
            DateTime Hoy = DateTime.Today;
            string fecha_actual = Hoy.ToString("dd-MM-yyyy");
            lbFecha.Text = fecha_actual;
            c = new Clientes();
        }

        private void gridProductos_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void gridProductos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
            /*buscarProductos bp = new buscarProductos();
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
                actualizarTotal();
            }
            */
        }

        private void btnAceptarPedido_Click(object sender, EventArgs e)
        {
            Querys query = new Querys();
            Producto p;
            if (c.id == "")
            {
                return;
            }
            else
            {
                actualizarTotal();
                pedido.idPedidos = Convert.ToInt32(query.AgregarPedido(Convert.ToInt32(c.id), txtComen.Text, Convert.ToDecimal(labelTotal.Text)));

                for (int i = 0; i < gridProductos.RowCount - 1; i++)
                {
                    p = new Producto();
                    p.id = Convert.ToInt32(gridProductos.Rows[i].Cells[0].Value);
                    p.nombre = Convert.ToString(gridProductos.Rows[i].Cells[1].Value);
                   p.precio= Convert.ToDecimal(gridProductos.Rows[i].Cells[2].Value);
                    p.cantidad = Convert.ToDecimal(gridProductos.Rows[i].Cells[3].Value);
                    
                    int idpro = Convert.ToInt32(gridProductos.Rows[i].Cells[0].Value);
                    query.AgregarDetallePedido(p.cantidad, p.precio, Convert.ToInt32(pedido.idPedidos), p.id);
                    listaProductos.Add(p);
                }
                Impresion im = new Impresion();
                im.imprimirPedido(c,pedido,listaProductos);
                MessageBox.Show("Pedido creado exitosamente");
                Close();
            //}
           /* for (int i = 0; i < listClientes.Items.Count; i++)
            {
                if (listClientes.Items[i].Checked)
                {
                    c.id = listClientes.Items[i].Text;
                    c.nombre = listClientes.Items[i].SubItems[1].Text;
                    c.tel = listClientes.Items[i].SubItems[2].Text;


                }
                */
            }
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

        private void gridProductos_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            actualizarTotal();
        }
        private void actualizarTotal()
        {
            Decimal auxTotal = 0;
           Decimal total = 0;

            for (int i = 0; i < gridProductos.RowCount - 1; i++)
            {
                auxTotal = Convert.ToDecimal(gridProductos.Rows[i].Cells[2].Value) * Convert.ToDecimal(gridProductos.Rows[i].Cells[3].Value);

                total = total + auxTotal;
                pedido.totalPedido=total;
                labelTotal.Text = Convert.ToString(pedido.totalPedido);
            }
        }

        private void gridProductos_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            actualizarTotal();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            agregarProducto(0);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            agregarProducto(1);
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            agregarProducto(2);
          
        }

        private void button6_Click(object sender, EventArgs e)
        {
            agregarProducto(3);
     
        }

        private void button7_Click(object sender, EventArgs e)
        {
            agregarProducto(4);
           
        }

        private void button8_Click(object sender, EventArgs e)
        {
            agregarProducto(5);
        
        }

        private void button9_Click(object sender, EventArgs e)
        {
            agregarProducto(6);
           
        }

        private void button10_Click(object sender, EventArgs e)
        {
            agregarProducto(7);
          
        }

        private void button11_Click(object sender, EventArgs e)
        {
            agregarProducto(8);
           
        }

        private void button12_Click(object sender, EventArgs e)
        {
            agregarProducto(9);
        
        }

        private void button13_Click(object sender, EventArgs e)
        {
            agregarProducto(10);
          
        }

        private void button14_Click(object sender, EventArgs e)
        {
            agregarProducto(11);
           
        }

        private void button15_Click(object sender, EventArgs e)
        {
            agregarProducto(12);
          
        }

        private void button16_Click(object sender, EventArgs e)
        {
            agregarProducto(13);
            
        }

        private void button17_Click(object sender, EventArgs e)
        {
            agregarProducto(14);
            
        }

        private void button18_Click(object sender, EventArgs e)
        {
            agregarProducto(15);
           
        }

        private void button19_Click(object sender, EventArgs e)
        {
            agregarProducto(16);
           
        }

        private void button20_Click(object sender, EventArgs e)
        {
            agregarProducto(17);
       
        }

        private void button21_Click(object sender, EventArgs e)
        {
            agregarProducto(18);
       
        }

        private void button22_Click(object sender, EventArgs e)
        {
            agregarProducto(19);
            
        }

        private void button23_Click(object sender, EventArgs e)
        {
            agregarProducto(20);
           
        }
        private void agregarProducto(int pos)
        {
  //          Querys query = new Querys();

//            Producto producto = query.buscarProducto(idProducto);

            DataGridViewRow row = (DataGridViewRow)gridProductos.Rows[0].Clone();
            row.Cells[0].Value = Convert.ToString(lista[pos].id);
            row.Cells[1].Value = lista[pos].nombre;
            row.Cells[2].Value = Convert.ToString(lista[pos].precio);
            row.Cells[3].Value = "1";
            gridProductos.Rows.Add(row);
            actualizarTotal();
        }

        private void txtBuscar_Enter(object sender, EventArgs e)
        {
            Querys query = new Querys();
            List<Clientes> listClientes;
            listClientes = query.BuscarCliente(txtBuscar.Text);
            if (lista.Count == 0)
            {
            }
            else
            {
                           }
        }
    }
   
    }
