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
        Usuarios usuario;
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
                usuario = new Usuarios();

                Querys query = new Querys();

                usuario = query.BuscarUsuarioId(login.idUsuario);
                if (usuario.tipo.Equals("VENTAS"))
                {
                    btnServicioDomicilio.Enabled = false;
                    btnProductos.Enabled = false;
                    btnConfiguracionUsuarios.Enabled = false;
                }

                if (usuario.tipo.Equals("PEDIDOS"))
                {
                    btnProductos.Enabled = false;
                    btnConfiguracionUsuarios.Enabled = false;
                    btnVentas.Enabled = false;
                }

                if (usuario.tipo.Equals("NINGUNO"))
                {
                    btnServicioDomicilio.Enabled = false;
                    btnProductos.Enabled = false;
                    btnConfiguracionUsuarios.Enabled = false;
                    btnVentas.Enabled = false;
                    button1.Enabled = false;
                }

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

        private void btnVentas_Click(object sender, EventArgs e)
        {
            Ventas ventas = new Ventas(usuario.id);
            ventas.Show();
        }

        private void btnRep_Click(object sender, EventArgs e)
        {
            reportes rep = new reportes();
            rep.Show();
        }
    }
}
