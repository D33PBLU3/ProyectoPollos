﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
                "SELECT nombre from usuarios where usuario = '{0}' and contrasena = '{1}'",
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