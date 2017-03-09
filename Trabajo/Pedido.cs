using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//using System.Threading.Tasks;

namespace Pollos
{
    class Pedido
    {
       public int idPedidos;
        public int idCliente;
        public DateTime fechaPedido;
        public string comentarios;
        public Decimal totalPedido;
        public Pedido()
        {
            idPedidos = 0;
            idCliente = 0;
            comentarios = "";
            totalPedido = 0;

        }
    }
    
}
