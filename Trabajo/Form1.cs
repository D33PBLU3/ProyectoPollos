using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trabajo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string respuesta = login.Buscar(txtUsuario.Text, txtContra.Text);

            if (respuesta.Equals("")){
                MessageBox.Show("Usuario o Contraseña incorrectos");
            }
            else{
                MessageBox.Show("Conectado");
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }
    }
}
