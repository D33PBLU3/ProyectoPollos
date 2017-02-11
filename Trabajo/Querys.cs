using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Pollos
{
    class Querys
    {
        public int AgregarCliente(string nombre, string tel, string direccion, string colonia, string entre)
        {
            MySqlConnection conectar = DB.ObtenerConexion();

            if (conectar != null)
            {

                int retorno = 0;

                MySqlCommand comando = new MySqlCommand(String.Format(
                "INSERT INTO clientes(nombreCliente, telefonoCliente, direccionCliente, entreCallesCLiente, coloniaCliente) VALUES('{0}', '{1}', '{2}', '{3}', '{4}')",
                nombre, tel, direccion, entre, colonia), conectar);

                retorno = comando.ExecuteNonQuery();

                return retorno;
            }
            return 0;
        }

        public List<Clientes> BuscarCliente(string tel)
        {
            MySqlConnection conectar = DB.ObtenerConexion();
            
            List<Clientes> lista = new List<Clientes>();

            if (conectar != null)
            {
                MySqlCommand comando = new MySqlCommand(String.Format(
                "SELECT * FROM clientes WHERE telefonoCliente = '{0}' and estatusCliente = 'ACTIVO'", tel), conectar);

                MySqlDataReader lector = comando.ExecuteReader();
                
                while (lector.Read())
                {
                    Clientes cliente = new Clientes();
                    cliente.id = lector.GetString(0);
                    cliente.nombre = lector.GetString(1);
                    cliente.tel = lector.GetString(2);
                    cliente.direccion = lector.GetString(3);
                    cliente.calles = lector.GetString(4);
                    cliente.colonia = lector.GetString(5);
                    cliente.status = lector.GetString(6);

                    lista.Add(cliente);
                }
                return lista;
            }
            return null;
        }
    }
}
