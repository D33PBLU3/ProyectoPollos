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
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
          
            
        }

        private void btnServicioDomicilio_Click(object sender, EventArgs e)
        {
            SevicioDomicilio servicioDom = new SevicioDomicilio();
            servicioDom.Show();
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {
            Hide();
            Form1 login = new Form1();
            login.ShowDialog();
            if (login.loginSuccesful)
            {
                Show();
            }
            else
                Close();
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            Productos productos=new Productos();
            productos.Show();
        }

        private void btnConfiguracionUsuarios_Click(object sender, EventArgs e)
        {
            Configuracion config = new Configuracion();
            config.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            adminClientes adClientes = new adminClientes();
            adClientes.Show();
        }
    }
}
