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
    public partial class addEdit : Form
    {
        string forma;
        string id;
        string nick;
        string pass;
        string permis;

        public addEdit(string forma, string id, string nick, string pass, string permis)
        {
            InitializeComponent();
            this.forma = forma;
            this.id = id;

            textNick.Text = nick;
            textPass.Text = pass;
            comboPermiso.Text = permis;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (forma == "add")
            {
                int resultado = 0;

                Querys query = new Querys();
                string nombre = textNick.Text;
                string pass = textPass.Text;
                string permis = comboPermiso.Text;

                if (nombre == "" || pass == "")
                {
                    MessageBox.Show("Todos los campos deben de estar llenos");
                }
                else
                {
                    resultado = query.AgregarUsuario(nombre, pass, permis);
                    if (resultado > 0 && resultado < 10)
                    {
                        textNick.Text = "";
                        textPass.Text = "";

                        this.Close();
                        MessageBox.Show("EL usuario se a registrado");
                    }else
                    if(resultado == 10)
                    {
                        MessageBox.Show("El NickName ya se encuentra registrado vuelva a intentarlo");
                    }
                    else
                    {
                        MessageBox.Show("Error al registrar el usuario");
                    }
                }
            }
            
            if(forma == "edit")
            {
                Querys query = new Querys();

                if (textNick.Text == "" || textPass.Text == "")
                {
                    MessageBox.Show("Todos los campos deben de estar llenos");
                }
                else
                {
                    int respuesta = query.EditarUsuario(id, textNick.Text, textPass.Text, comboPermiso.Text);

                    if (respuesta == 1)
                    {

                        this.Close();
                        MessageBox.Show("Los datos se editaron correctamente");
                    }
                    else
                    {
                        MessageBox.Show("Ocurrio un error vuelva a intentarlo");
                    }
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
