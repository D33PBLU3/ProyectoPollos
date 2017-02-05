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
    public partial class DatosConexion : Form
    {
        public DatosConexion()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Encrypt encrypt = new Encrypt();
            string str = encrypt.encrypt(txtIp.Text);

            System.IO.StreamWriter file = new System.IO.StreamWriter("conexion.txt");
            file.WriteLine(str);
            file.Close();

            Hide();

            MessageBox.Show("Datos guardados corectamente");
        }
    }
}

