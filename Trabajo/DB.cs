using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//using System.Threading.Tasks;
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

                string str = "";
                string ip = "";
                string db = "";
                string usu = "";
                string pass = "";

                try
                {
                    System.IO.StreamReader file = new System.IO.StreamReader("conexion.txt");


                    str = file.ReadLine();
                    str = encrypr.decrypt(str);

                    char[] delimitador = { '-' };

                    string[] parse = str.Split(delimitador);

                    ip = parse[0];
                    db = parse[1];
                    usu = parse[2];
                    pass = parse[3];

                    MySqlConnection conectar = new MySqlConnection("server=" + ip + "; database=" + db + "; Uid=" + usu + "; pwd=" + pass + ";");

                    file.Close();
                    conectar.Open();
                    return conectar;
                }
                catch 
                {
                    return null;
                }
            }
            catch (MySqlException ex)
            {
                int codigoError = ex.Number; ;
            }
            return null;
        }
    }
}
