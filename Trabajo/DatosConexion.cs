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
    public partial class DatosConexion : Form
    {
        public DatosConexion()
        {
            InitializeComponent();

            Encrypt encrypt = new Encrypt();
            string strr = "";
            string ipr = "";
            string dbr = "";
            string usur = "";
            string passr = "";

            try
            {

                System.IO.StreamReader filer = new System.IO.StreamReader("conexion.txt");

                strr = filer.ReadLine();
                strr = encrypt.decrypt(strr);

                char[] delimitador = { '-' };

                string[] parse = strr.Split(delimitador);

                ipr = parse[0];
                dbr = parse[1];
                usur = parse[2];
                passr = parse[3];

                txtIp.Text = ipr;
                txtDB.Text = dbr;
                txtUsuario.Text = usur;
                txtContrasena.Text = passr;

                filer.Close();
            }
            catch(Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Encrypt encrypt = new Encrypt();
           
            string ip = txtIp.Text;
            string db = txtDB.Text;
            string usuario = txtUsuario.Text;
            string contrasena = txtContrasena.Text;

            string cadena = ip + "-" + db + "-" + usuario + "-" + contrasena;

            string str = encrypt.encrypt(cadena);


            System.IO.StreamWriter file = new System.IO.StreamWriter("conexion.txt");
            file.WriteLine(str);
            file.Close();

            Hide();

            MessageBox.Show("Datos guardados corectamente");
        }
    }
}

