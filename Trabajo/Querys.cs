﻿using System;
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
                "SELECT * FROM clientes WHERE telefonoCliente LIKE '%" + tel + "%' and estatusCliente = 'ACTIVO'"), conectar);

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

        public int EditarCliente(string id, string nombre, string tel, string dir, string calle, string colonia)
        {
            MySqlConnection conectar = DB.ObtenerConexion();
        
            if (conectar != null)
            {
                MySqlCommand comando = new MySqlCommand(String.Format(
                "UPDATE clientes SET nombreCliente = '{0}', telefonoCliente = '{1}', direccionCliente = '{2}', entreCallesCliente = '{3}', coloniaCliente = '{4}' WHERE idClientes = '{5}'"
                ,nombre, tel, dir, calle, colonia, id), conectar);

                if(comando.ExecuteNonQuery() == 1)
                {
                    return 1;
                }else
                {
                    return 0;
                }

                
            }
            return 0;
        }

        public int EliminarCliente(string id)
        {
            MySqlConnection conectar = DB.ObtenerConexion();

            if (conectar != null)
            {
                MySqlCommand comando = new MySqlCommand(String.Format(
                "UPDATE clientes SET estatusCliente = 'INACTIVO' WHERE idClientes = '{0}'"
                , id), conectar);

                if (comando.ExecuteNonQuery() == 1)
                {
                    return 1;
                }
                else
                {
                    return 0;
                }


            }
            return 0;
        }
        public int AgregarProducto(string nombre, string tipo,Decimal precio)
        {
            MySqlConnection conectar = DB.ObtenerConexion();
            string preciotx = String.Format("{0:0.00}", precio);
            preciotx = preciotx.Replace(",", ".");
            if (conectar != null)
            {

                int retorno = 0;

                MySqlCommand comando = new MySqlCommand(String.Format(
                "INSERT INTO Productos(nombreProducto, tipoProducto, precioProducto) VALUES('{0}', '{1}', '{2}')",
                nombre,tipo,preciotx ), conectar);

                retorno = comando.ExecuteNonQuery();

                return retorno;
            }
            return 0;
        }
        public int EditarProducto(int id,string nombre,string tipo,Decimal precio)
        {
            MySqlConnection conectar = DB.ObtenerConexion();
            string preciotx = String.Format("{0:0.00}", precio);
            preciotx = preciotx.Replace(",", ".");
            if (conectar != null)
            {
                MySqlCommand comando = new MySqlCommand(String.Format(
                "UPDATE Productos SET nombreProducto = '{0}', tipoProducto = '{1}', precioProducto = '{2}' where idProductos='{3}'"
                , nombre,tipo,preciotx,id ), conectar);

                if (comando.ExecuteNonQuery() == 1)
                {
                    return 1;
                }
                else
                {
                    return 0;
                }


            }
            return 0;
        }
        public List<Producto> getProductos()
        {
            MySqlConnection conectar = DB.ObtenerConexion();

            List<Producto> lista = new List<Producto>();

            if (conectar != null)
            {
                MySqlCommand comando = new MySqlCommand(String.Format(
                "SELECT * FROM productos WHERE estatusProducto = 'ACTIVO'"), conectar);

                MySqlDataReader lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    Producto p = new Producto();
                    p.id = Convert.ToInt32(lector.GetString(0));
                    p.nombre = lector.GetString(2);
                    p.tipo = lector.GetString(1);
                    p.precio = Convert.ToDecimal(lector.GetString(3));
                    p.estatus = lector.GetString(4);
                    
                    lista.Add(p);
                }
                return lista;
            }
            return null;
        }

        public int EliminarProducto(string id)
        {
            MySqlConnection conectar = DB.ObtenerConexion();

            if (conectar != null)
            {
                MySqlCommand comando = new MySqlCommand(String.Format(
                "UPDATE Productos SET estatusProducto = 'INACTIVO' WHERE idProductos = '{0}'"
                , id), conectar);

                if (comando.ExecuteNonQuery() == 1)
                {
                    EliminarSubProductos(Convert.ToInt32(id));
                    return 1;
                }
                else
                {
                    return 0;
                }


            }
            return 0;
        }

        public List<Usuarios> BuscarUsuario(string nick)
        {
            MySqlConnection conectar = DB.ObtenerConexion();

            List<Usuarios> lista = new List<Usuarios>();

            if (conectar != null)
            {
                MySqlCommand comando = new MySqlCommand(String.Format(
                "SELECT * FROM usuarios WHERE nickName LIKE '%" + nick + "%' and estatusUsuario = 'ACTIVO'"), conectar);

                MySqlDataReader lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    Usuarios usuario = new Usuarios();
                    usuario.id = lector.GetString(0);
                    usuario.nickName = lector.GetString(1);
                    usuario.pass = lector.GetString(2);
                    usuario.tipo = lector.GetString(3);
                    usuario.status = lector.GetString(4);

                    lista.Add(usuario);
                }
                return lista;
            }
            return null;
        }

        public int AgregarUsuario(string nombre, string pass, string permis)
        {
            MySqlConnection conectar = DB.ObtenerConexion();

            if (conectar != null)
            {

                int retorno = 0;

                MySqlCommand comando = new MySqlCommand(String.Format(
                "INSERT INTO usuarios(nickName, password, tipoPermiso) VALUES('{0}', '{1}', '{2}')",
                nombre, pass, permis), conectar);

                retorno = comando.ExecuteNonQuery();

                return retorno;
            }
            return 0;
        }

        public int EditarUsuario(string id, string nick, string pass, string permis)
        {
            MySqlConnection conectar = DB.ObtenerConexion();

            if (conectar != null)
            {
                MySqlCommand comando = new MySqlCommand(String.Format(
                "UPDATE usuarios SET nickName = '{0}', password = '{1}', tipoPermiso = '{2}' WHERE idUsuario = '{3}'"
                , nick, pass, permis, id), conectar);

                if (comando.ExecuteNonQuery() == 1)
                {
                    return 1;
                }
                else
                {
                    return 0;
                }


            }
            return 0;
        }

        public int EliminarUsuario(string id)
        {
            MySqlConnection conectar = DB.ObtenerConexion();

            if (conectar != null)
            {
                MySqlCommand comando = new MySqlCommand(String.Format(
                "UPDATE usuarios SET estatusUsuario = 'INACTIVO' WHERE idUsuario = '{0}'"
                , id), conectar);

                if (comando.ExecuteNonQuery() == 1)
                {
                    return 1;
                }
                else
                {
                    return 0;
                }


            }
            return 0;
        }
        public int AgregarSubProducto(int idProductos, int idSubProductos, decimal cantidad)
        {
            MySqlConnection conectar = DB.ObtenerConexion();
            string cantidadtx = String.Format("{0:0.00}", cantidad);
            cantidadtx = cantidadtx.Replace(",", ".");
            if (conectar != null)
            {

                int retorno = 0;

                MySqlCommand comando = new MySqlCommand(String.Format(
                "INSERT INTO subProductos(idproductos,idSubProducto, cantidad) VALUES('{0}', '{1}', '{2}')",
                idProductos, idSubProductos, cantidadtx), conectar);

                retorno = comando.ExecuteNonQuery();

                return retorno;
            }
            return 0;
        }
        /*public int EditarSubProducto(int idProductos, int idSubProducto, Decimal cantidad)
        {
            MySqlConnection conectar = DB.ObtenerConexion();
            string cantidadtx = String.Format("{0:0.00}", cantidad);
            cantidadtx = cantidadtx.Replace(",", ".");
            if (conectar != null)
            {
                MySqlCommand comando = new MySqlCommand(String.Format(
                "UPDATE SubProductos SET idProductos = '{0}', idSubProducto = '{1}', cantidad = '{2}' where idProductos='{3}' and idSubProducto='{1}'"
                , nombre, tipo, preciotx, id), conectar);

                if (comando.ExecuteNonQuery() == 1)
                {
                    return 1;
                }
                else
                {
                    return 0;
                }


            }
            return 0;
        }*/
        public int EliminarSubProductos (int idProductos)
        {

            MySqlConnection conectar = DB.ObtenerConexion();
            if (conectar != null)
            {

                int retorno = 0;

                MySqlCommand comando = new MySqlCommand(String.Format(
                "DELETE FROM subProductos WHERE idProductos='{0}'",
                idProductos), conectar);

                retorno = comando.ExecuteNonQuery();

                return retorno;
            }
            return 0;

        }
        public int getLastProducto()
        {
            MySqlConnection conectar = DB.ObtenerConexion();

            List<Usuarios> lista = new List<Usuarios>();
            Producto p = new Producto();
            if (conectar != null)
            {
                MySqlCommand comando = new MySqlCommand(String.Format(
                "SELECT max(idProductos) FROM productos WHERE estatusProducto='ACTIVO'"), conectar);

                MySqlDataReader lector = comando.ExecuteReader();

                while (lector.Read())
                {
                   
                    p.id = Convert.ToInt32(lector.GetString(0));
                    
                }
                return p.id;
            }
            return -1;
        }
        public List<SubProducto> getSubProductos(int idProducto)
        {
            MySqlConnection conectar = DB.ObtenerConexion();

            List<SubProducto> lista = new List<SubProducto>();

            if (conectar != null)
            {
                MySqlCommand comando = new MySqlCommand(String.Format(
                "select productos.idproductos,productos.nombreproducto,productos.tipoProducto,productos.precioProducto,subproductos.cantidad from productos,subproductos where '{0}'="+
                "subproductos.idProductos and productos.idProductos=subProductos.idSubProducto",idProducto) ,conectar);

                MySqlDataReader lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    SubProducto sp = new SubProducto();
                    sp.idSubProducto = Convert.ToInt32(lector.GetString(0));
                    sp.nombre = lector.GetString(1);
                    sp.tipo = lector.GetString(2);
                    sp.precio = Convert.ToDecimal(lector.GetString(3));
                    sp.cantidad = Convert.ToDecimal(lector.GetString(4));
                    lista.Add(sp);
                }
                return lista;
            }
            return null;
        }
        public long AgregarPedido(int id, string comentario, decimal total)
        {
            MySqlConnection conectar = DB.ObtenerConexion();

            if (conectar != null)
            {

                int retorno = 0;

                MySqlCommand comando = new MySqlCommand(String.Format(
                "INSERT INTO pedidos(idCliente, comentarios, totalPedido) VALUES('{0}', '{1}', '{2}')",
                id, comentario, total), conectar);

                retorno = comando.ExecuteNonQuery();

                if(retorno == 1)
                {
                    return comando.LastInsertedId;
                }

                return retorno;
            }
            return 0;
        }
        public int AgregarDetallePedido(decimal cantidad, decimal precio, int idPedido, int idProducto)
        {
            MySqlConnection conectar = DB.ObtenerConexion();

            if (conectar != null)
            {

                int retorno = 0;

                MySqlCommand comando = new MySqlCommand(String.Format(
                "INSERT INTO detallepedido(cantidad, precio, idpedido, idproducto) VALUES('{0}', '{1}', '{2}', '{3}')",
                cantidad, precio, idPedido, idProducto), conectar);

                retorno = comando.ExecuteNonQuery();

                return retorno;
            }
            return 0;
        }
    }
}
