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
    public partial class Form2 : Form
    {
        int press = 0;
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        void Actualizar()
        {
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();

            Querys query = new Querys();

            String id = Txid.Text;

            List<VentaClas> listas = query.BuscarVentasId(id);

            foreach (VentaClas p in listas)
            {

                DataGridViewRow row = (DataGridViewRow)dataGridView1.Rows[0].Clone();
                row.Cells[0].Value = p.idVenta;
                row.Cells[1].Value = p.fechaPedido;
                row.Cells[2].Value = p.comentarios;
                row.Cells[3].Value = p.totalVenta;

                dataGridView1.Rows.Add(row);
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            
          
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                Actualizar();
                
            }
        }

        private void dataGridView1_ColumnRemoved(object sender, DataGridViewColumnEventArgs e)
        {
           
        }

        private void dataGridView1_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
          
        }

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
         
        }

        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (dataGridView1.Rows.GetRowCount(DataGridViewElementStates.Selected) > 0) {
                try
                {
                    Querys query = new Querys();
                int i = dataGridView1.SelectedRows[0].Index;



                
                    String a = dataGridView1.Rows[i].Cells[0].Value.ToString();

                
                query.EliminarVenta(a);

                Actualizar();
                }
                catch (Exception a) {
                }
            }
        }
    }
}
