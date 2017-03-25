using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pollos
{
    class VentaClas
    {
        public int idVenta;
        public int idUsuario;
        public DateTime fechaPedido;
        public string comentarios;
        public Decimal totalVenta;
        public VentaClas()
        {
            idVenta = 0;
            idUsuario = 0;
            comentarios = "";
            totalVenta = 0;

        }
    }
}
