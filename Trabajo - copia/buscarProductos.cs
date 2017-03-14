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
    public partial class buscarProductos : Form
    {
        public Producto p;
        public bool encontrado=false;
        public buscarProductos()
        {
            InitializeComponent();
        }

        private void buscarProductos_Load(object sender, EventArgs e)
        {
            Querys query = new Querys();
            List<Producto> lista;
            lista = query.getProductos();

            foreach (Producto p in lista)
            {
                DataGridViewRow row = (DataGridViewRow)gridBusquedaProductos.Rows[0].Clone();
                row.Cells[0].Value = Convert.ToString(p.id);
                row.Cells[1].Value = p.nombre;
                row.Cells[2].Value = p.tipo;
                row.Cells[3].Value = Convert.ToString(p.precio);
                
                gridBusquedaProductos.Rows.Add(row);
            }
        }

        private void gridBusquedaProductos_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
           

        }

        private void gridBusquedaProductos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            p = new Producto();
            p.id = Convert.ToInt32(((DataGridView)sender).Rows[e.RowIndex].Cells[0].Value);
            p.nombre = (string)(((DataGridView)sender).Rows[e.RowIndex].Cells[1].Value);
            p.tipo = (string)((DataGridView)sender).Rows[e.RowIndex].Cells[2].Value;
            p.precio = Convert.ToDecimal(((DataGridView)sender).Rows[e.RowIndex].Cells[3].Value);
            encontrado = true;
            Close();
        }
    }
}
