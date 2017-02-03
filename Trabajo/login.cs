using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Trabajo{
    class login{
        public static string Buscar(string usuario, string contrasena){
            MySqlCommand comando = new MySqlCommand(String.Format(
                "SELECT nombre from usuarios where usuario = '{0}' and contrasena = '{1}'", 
                usuario, contrasena), DB.ObtenerConexion());

            MySqlDataReader lector = comando.ExecuteReader();

            String result = "";

            while (lector.Read()){
                result = lector.GetString(0);
            }

            return result;
        }
    }
}
