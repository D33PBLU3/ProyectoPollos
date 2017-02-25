using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pollos
{
    class SubProducto
    {
       public int idProductos;
       public int idSubProducto;
       public Decimal cantidad;
       public string nombre;
       public string tipo;
       public string estatus;
       public decimal precio;
       public  SubProducto()
        {
            idProductos = 0;
            idSubProducto = 0;
            cantidad = 0;
            precio = 0;
            tipo = "";
        }
    }
}
