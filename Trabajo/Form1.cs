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
    
    public partial class Form1 : Form
    {
        public bool loginSuccesful = false;
        public String idUsuario = "";
       
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string respuesta = login.Buscar(txtUsuario.Text, txtContra.Text);

            if (respuesta.Equals(""))
            {
                MessageBox.Show("Usuario o Contraseña incorrectos");
            }
            else
            if(respuesta.Equals("Error base de datos"))
            {
                MessageBox.Show("Error al conectarse a la base de datos");
            }
            else
            {
                idUsuario = respuesta;
                loginSuccesful = true;
                Close();
                
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DatosConexion conector = new DatosConexion();
            conector.Show();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            //loginSuccesful = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}