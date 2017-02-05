using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Pollos
{
    public class DB
    {
        public static MySqlConnection ObtenerConexion()
        {
            try
            {
                Encrypt encrypr = new Encrypt();

                String ip = "";

                System.IO.StreamReader file = new System.IO.StreamReader("conexion.txt");

                ip = file.ReadLine();
                ip = encrypr.decrypt(ip);

                MySqlConnection conectar = new MySqlConnection("server=" + ip + "; database=tienda1; Uid=root; pwd=;");

                file.Close();
                conectar.Open();
                return conectar;
            }
            catch (MySqlException ex)
            {
                int codigoError = ex.Number; ;
            }
            return null;
        }
    }
}
