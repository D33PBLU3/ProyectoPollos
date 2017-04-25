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
        String nombreAux = "";
        String dirAux = "";
        String entreAux = "";
        String colAux = "";
        List<detallePedido> detalle;
        List<Producto> lista;
        Decimal [] preciosProd;
        Clientes c;
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
                button24.Text = lista[21].nombre;
                button25.Text = lista[22].nombre;
                button26.Text = lista[23].nombre;
                button27.Text = lista[24].nombre;
                button28.Text = lista[25].nombre;
                button29.Text = lista[26].nombre;
                button30.Text = lista[27].nombre;
                button31.Text = lista[28].nombre;
                button32.Text = lista[29].nombre;


                preciosProd = new Decimal[50];

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
                string id = idCliente.Text;
                string colonia = textColonia.Text;
                string nombre = txtNombreCliente.Text;
                string dir = txtDireccionCliente.Text;
                string calles = txtEntreCallesCliente.Text;
                string tel = telLabel.Text;


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

        private void button1_Click(object sender, EventArgs e)
        {
            Querys query = new Querys();

            try
            {

                string id = idCliente.Text;

                if (id == "")
                {
                    MessageBox.Show("No se ha seleccionado algun cliente");
                }
                else
                {

                    int respuesta = query.EliminarCliente(id);

                    if (respuesta == 1)
                    {
                        idCliente.Text = "";
                        textColonia.Text = "";
                        txtNombreCliente.Text = "";
                        txtDireccionCliente.Text = "";
                        txtEntreCallesCliente.Text = "";
                        telLabel.Text = "";
                        txtBuscar.Text = "";

                        MessageBox.Show("El cliente se ha eliminado");
                    }
                    else
                    {
                        MessageBox.Show("Ocurrio un error vuelva a intentarlo");
                    }
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
            //Actualizar();
            listaProductos = new List<Producto>();
            gridProductos.MultiSelect = false;
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
            c.id = idCliente.Text;
            if (c.id == "")
            {
                c.nombre = txtNombreCliente.Text;
                c.tel = txtBuscar.Text; 
                c.direccion = txtDireccionCliente.Text;
                c.colonia = txtColoniaCliente.Text;
                c.calles = txtEntreCallesCliente.Text;
                c.id = Convert.ToString(query.AgregarClienteRetornId(txtNombreCliente.Text, txtBuscar.Text, txtDireccionCliente.Text, textColonia.Text, txtEntreCallesCliente.Text));
                //return;
            }
            
            if (nombreAux != txtNombreCliente.Text || dirAux != txtDireccionCliente.Text || entreAux != txtEntreCallesCliente.Text || colAux != textColonia.Text)
            {
                query.EditarCliente(c.id, txtNombreCliente.Text, txtBuscar.Text, txtDireccionCliente.Text, txtEntreCallesCliente.Text, textColonia.Text);
            }

            //else
            //{
                actualizarTotal();
                pedido.idPedidos = Convert.ToInt32(query.AgregarPedido(Convert.ToInt32(c.id), txtComen.Text, Convert.ToDecimal(labelTotal.Text)));
            pedido = query.buscarPedido(pedido.idPedidos);
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
                pedido.comentarios = txtComen.Text;
                Impresion im = new Impresion();
                c.nombre = txtNombreCliente.Text;
                c.tel = txtBuscar.Text;
                c.direccion = txtDireccionCliente.Text;
                c.colonia = txtColoniaCliente.Text;
                c.calles = txtEntreCallesCliente.Text;
            im.imprimirPedido(c,pedido,listaProductos);
               // MessageBox.Show("Pedido creado exitosamente");
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
            //}
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
                //lbNomCliente.Text = c.nombre;
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
            labelTotal.Text = Convert.ToString("0");
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
            seleccionEnsalada sl = new seleccionEnsalada();
            sl.ShowDialog();
            for (int i = 0; i < 4; i++)
            {
                if (sl.ensaladas.ElementAt(i).cantidad > 0)
                {
                    DataGridViewRow row = (DataGridViewRow)gridProductos.Rows[0].Clone();
                    row.Cells[0].Value = Convert.ToString(sl.ensaladas.ElementAt(i).idProductos);
                    row.Cells[1].Value = sl.ensaladas.ElementAt(i).nombre;
                    row.Cells[2].Value = Convert.ToString(0.00);
                    row.Cells[3].Value = Convert.ToString(sl.ensaladas.ElementAt(i).cantidad);
                    gridProductos.Rows.Add(row);
                }
            }


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
            row.Cells[3].Selected = true;
            gridProductos.BeginEdit(true);
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

        private void gridProductos_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtBuscar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter|| e.KeyCode == Keys.Tab)
            {
                Querys query = new Querys();
                List<Clientes> listClientes;
                listClientes = query.BuscarClienteIgual(txtBuscar.Text);
                if (listClientes.Count == 0)
                {
                    idCliente.Text = "";
                    colAux = textColonia.Text = "";
                    nombreAux = txtNombreCliente.Text = "";
                    dirAux = txtDireccionCliente.Text = "";
                    entreAux = txtEntreCallesCliente.Text = "";
                    telLabel.Text = "";
                    MessageBox.Show("Registre al cliente");
                    txtNombreCliente.Focus();
                }
                else
                {
                    foreach (Clientes cliente in listClientes)
                    {
                        idCliente.Text = cliente.id;
                        colAux = textColonia.Text = cliente.colonia;
                        nombreAux = txtNombreCliente.Text = cliente.nombre;
                        dirAux = txtDireccionCliente.Text = cliente.direccion;
                        entreAux = txtEntreCallesCliente.Text = cliente.calles;
                        telLabel.Text = txtBuscar.Text;
                    }
                }
            }
        }

        private void button24_Click(object sender, EventArgs e)
        {
            agregarProducto(21);
        }

        private void button27_Click(object sender, EventArgs e)
        {
            agregarProducto(22);
        }

        private void button26_Click(object sender, EventArgs e)
        {
            agregarProducto(23);
        }

        private void button25_Click(object sender, EventArgs e)
        {
            agregarProducto(24);
        }
        
        private void numPedido_KeyDown(object sender, KeyEventArgs e)
        {   Querys query=new Querys();
            try
            {
                if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab)
                {
                    pedido.idPedidos = Convert.ToInt32(numPedido.Text);
                    pedido = query.buscarPedido(pedido.idPedidos);
                    c = query.BuscarClienteId(pedido.idCliente);
                    txtNombreCliente.Text = c.nombre;
                    txtBuscar.Text = c.tel;
                    txtDireccionCliente.Text = c.direccion;
                    txtColoniaCliente.Text= c.colonia;
                }
            }
            catch
            {

            }
        }

        private void numPedido_KeyDown_1(object sender, KeyEventArgs e)
        {
            Querys query = new Querys();
            try
            {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab)
            {
                pedido.idPedidos = Convert.ToInt32(numPedido.Text);

                pedido = query.buscarPedido(pedido.idPedidos);
                if (pedido != null)
                {
                        gridProductos.Rows.Clear();
                        
                    txtComen.Text = pedido.comentarios;
                    lbFecha.Text = Convert.ToString(pedido.fechaPedido);
                    c = query.BuscarClienteId(pedido.idCliente);
                    if (c != null)
                    {
                        txtNombreCliente.Text = c.nombre;
                        txtBuscar.Text = c.tel;
                        txtDireccionCliente.Text = c.direccion;
                        txtColoniaCliente.Text = c.colonia;
                        txtEntreCallesCliente.Text = c.calles;
                    }
                    detalle = query.buscarDetalle(pedido.idPedidos);
                    if (detalle != null)
                    {
                        foreach (detallePedido dp in detalle)
                        {
                            Producto p = new Producto();
                            p = query.buscarProducto(dp.idProducto);
                            DataGridViewRow row = (DataGridViewRow)gridProductos.Rows[0].Clone();
                            row.Cells[0].Value = Convert.ToString(p.id);
                            row.Cells[1].Value = p.nombre;
                            row.Cells[2].Value = Convert.ToString(p.precio);
                            row.Cells[3].Value = dp.cantidad;
                            gridProductos.Rows.Add(row);
                        }
                        actualizarTotal();
                    }
                        btnAceptarPedido.Visible = false;
                }
            }
            }
            catch
            {

            }
        }

        private void gridProductos_CellValueChanged_1(object sender, DataGridViewCellEventArgs e)
        {
            actualizarTotal();
        }

        private void gridProductos_RowsRemoved_1(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            actualizarTotal();
        }

        private void gridProductos_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {
            actualizarTotal();
        }

        private void button28_Click(object sender, EventArgs e)
        {
            agregarProducto(25);
        }

        private void button29_Click(object sender, EventArgs e)
        {
            agregarProducto(26);
        }

        private void button30_Click(object sender, EventArgs e)
        {
            agregarProducto(27);
        }

        private void button31_Click(object sender, EventArgs e)
        {
            agregarProducto(28);
        }

        private void button32_Click(object sender, EventArgs e)
        {
            agregarProducto(29);
        }

        private void gridProductos_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            gridProductos.CurrentCell = null;
            gridProductos.Rows[e.RowIndex].Selected = true;
        }
    }
   
    }
