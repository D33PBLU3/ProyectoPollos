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
    
    public partial class ProductosAdmin : Form
    {
        Producto prod;
        public int operacion;
        public ProductosAdmin()
        {
            InitializeComponent();
            listSubProductos.FullRowSelect = true;
            listSubProductos.CheckBoxes = true;
            listSubProductosAg.CheckBoxes = true;
            operacion = 0;
            prod = new Producto();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            SubProducto sp = new SubProducto();
                Querys query = new Querys();
                int resultado = 0;
                prod.nombre = txtNombreProducto.Text;
                prod.tipo = txtTipoProducto.Text;
                prod.precio = Convert.ToDecimal(txtPrecio.Text);
                if (prod.nombre == "" || prod.tipo == "")
                {
                    MessageBox.Show("Ingresa todo los datos");
                    return;
                }
            if (operacion == 1)
            {
                resultado = query.AgregarProducto(prod.nombre, prod.tipo, prod.precio);
                if (prod.tipo == "PAQUETE")
                {
                    sp.idProductos = query.getLastProducto();
                    /*for (int i = 0; i < listSubProductosAg.Items.Count; i++)
                    {
                        sp.idSubProducto = Convert.ToInt32(listSubProductosAg.Items[i].Text);
                        sp.cantidad = Convert.ToDecimal(listSubProductosAg.Items[i].SubItems[2].Text);
                        query.AgregarSubProducto(sp.idProductos, sp.idSubProducto, sp.cantidad);

                    }*/
                    foreach (DataGridViewRow row in gridProductos.Rows)
                    {
                        sp.idProductos  = Convert.ToInt32(row.Cells[0].Value);
                        sp.cantidad = Convert.ToDecimal(row.Cells[4].Value);
                        query.AgregarSubProducto(sp.idProductos, sp.idSubProducto, sp.cantidad);
                    }
                }
            }
            else
            {   
                resultado = query.EditarProducto(prod.id, prod.nombre, prod.tipo, prod.precio);
                query.EliminarSubProductos(prod.id);
                if (prod.tipo == "PAQUETE")
                {
                    sp.idProductos = prod.id;
                   // sp.idProductos = query.getLastProducto();
                    foreach (DataGridViewRow row in gridProductos.Rows)
                    {

                        sp.idSubProducto = Convert.ToInt32(row.Cells[0].Value);
                        if (sp.idSubProducto != 0)
                        {
                            sp.cantidad = Convert.ToDecimal(row.Cells[4].Value);
                            query.AgregarSubProducto(sp.idProductos, sp.idSubProducto, sp.cantidad);
                        }
                    }
                }
            }
                if (resultado > 0)
                {
                    Close();
                    MessageBox.Show("Producto Actualizado");
                }
                else
                {
                    MessageBox.Show("Error al actualizar el producto");

                }
           
        }
        public void setProducto(Producto p)
        {
            prod = p;
        }

        private void ProductosAdmin_Load(object sender, EventArgs e)
        {
            Querys query = new Querys();
            List<SubProducto> listaSub=new List<SubProducto>();
            if (operacion == 2)
            {
                listaSub = query.getSubProductos(prod.id);
                txtNombreProducto.Text = prod.nombre;
                txtPrecio.Text = Convert.ToString(prod.precio);
                txtTipoProducto.Text = prod.tipo;
                foreach (SubProducto sp in listaSub)
                {
                    DataGridViewRow row = (DataGridViewRow)gridProductos.Rows[0].Clone();
                    row.Cells[0].Value = Convert.ToString(sp.idSubProducto);
                    row.Cells[1].Value = sp.nombre;
                    row.Cells[2].Value = sp.tipo;
                    row.Cells[3].Value = Convert.ToString(sp.precio);
                    row.Cells[4].Value = Convert.ToString(sp.cantidad);

                    gridProductos.Rows.Add(row);
                }


            }
        }

        private void txtTipoProducto_TextChanged(object sender, EventArgs e)
        {
            if (txtTipoProducto.Text == "PAQUETE")
            {
                listSubProductos.Visible = true;
                listSubProductosAg.Visible = true;
                btn_agregarSubP.Visible = true;
                btn_quitarSubP.Visible = true;
                cantidadSubP.Visible = true;
                gridProductos.Visible = true;
                Querys query = new Querys();
                List<Producto> lista;
                lista = query.getProductos();
                int cont = 0;
                if (lista.Count == 0)
                {
                }
                else
                {
                    foreach (Producto p in lista)
                    {
                        listSubProductos.Items.Add(Convert.ToString(p.id), 0);
                        listSubProductos.Items[cont].SubItems.Add(p.nombre);
                        

                        cont++;
                    }
                }

            }
            else
            {
                listSubProductos.Visible = false;
                listSubProductosAg.Visible = false;
                btn_agregarSubP.Visible = false;
                btn_quitarSubP.Visible = false;
                cantidadSubP.Visible = false;
                gridProductos.Visible = false;

            }
        }

        private void btn_agregarSubP_Click(object sender, EventArgs e)
        {
            string cantidad;
            cantidad = cantidadSubP.Text;
            cantidadSubP.Text = "0,00";
            int j = listSubProductosAg.Items.Count;
            for (int i = 0; i < listSubProductos.Items.Count; i++)
            {
                if (listSubProductos.Items[i].Checked)
                {
                    listSubProductosAg.Items.Add(listSubProductos.Items[i].Text);
                    listSubProductosAg.Items[j].SubItems.Add(listSubProductos.Items[i].SubItems[1].Text);
                    listSubProductosAg.Items[j].SubItems.Add(cantidad);
                    listSubProductos.Items[i].Checked = false;
                    j++;

                }
                    
            }
        }

        private void btn_quitarSubP_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listSubProductosAg.Items.Count; i++)
            {
                if (listSubProductosAg.Items[i].Checked)
                {
                    listSubProductosAg.Items[i].Remove();
                    i--;

                }

            }
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
    }
}
