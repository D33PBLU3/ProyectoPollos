using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Pollos
{
    class login
    {
        
        public static string Buscar(string usuario, string contrasena)
        {
            MySqlConnection conectar = DB.ObtenerConexion();

            if(conectar != null)
            {
                MySqlCommand comando = new MySqlCommand(String.Format(
                "SELECT idUsuario from usuarios where nickName = '{0}' and password = '{1}' and estatusUsuario = 'ACTIVO'",
                usuario, contrasena), conectar);

                MySqlDataReader lector = comando.ExecuteReader();

                String result = "";

                while (lector.Read())
                {
                    result = lector.GetString(0);
                }

                return result;
            }
            return "Error base de datos";
        }
    }
}