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
    public partial class Configuracion : Form
    {
        public Configuracion()
        {
            InitializeComponent();
            listaUsuarios.FullRowSelect = true;
            Actualizar();
        }


        private void Actualizar()
        {
            listaUsuarios.Items.Clear();

            List<Usuarios> lista = new List<Usuarios>();

            Querys query = new Querys();

            string buscar = textBuscar.Text;

            lista = query.BuscarUsuario(buscar);

            int cont = 0;

            if (lista.Count == 0)
            {
            }
            else
            {
                foreach (Usuarios usuario in lista)
                {
                    listaUsuarios.Items.Add(usuario.id, 0);
                    listaUsuarios.Items[cont].SubItems.Add(usuario.nickName);
                    listaUsuarios.Items[cont].SubItems.Add(usuario.pass);
                    listaUsuarios.Items[cont].SubItems.Add(usuario.tipo);

                    cont++;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            addEdit add = new addEdit("add", "", "", "", "NINGUNO");
            add.ShowDialog();
            Actualizar(); 
        }

        private void textBuscar_TextChanged(object sender, EventArgs e)
        {
            Actualizar();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                string id = listaUsuarios.SelectedItems[0].SubItems[0].Text;
                string nick = listaUsuarios.SelectedItems[0].SubItems[1].Text;
                string pass = listaUsuarios.SelectedItems[0].SubItems[2].Text;
                string permiso = listaUsuarios.SelectedItems[0].SubItems[3].Text;

                addEdit edit = new addEdit("edit", id, nick, pass, permiso);
                edit.ShowDialog();
                Actualizar();

            }
            catch
            {
                MessageBox.Show("No se ha seleccionado algun cliente");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Querys query = new Querys();

            try
            {

                string id = listaUsuarios.SelectedItems[0].SubItems[0].Text;

                int respuesta = query.EliminarUsuario(id);

                if (respuesta == 1)
                {
                    listaUsuarios.Items.Remove(listaUsuarios.SelectedItems[0]);
                    MessageBox.Show("El usuario se ha eliminado");
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
    }
}
