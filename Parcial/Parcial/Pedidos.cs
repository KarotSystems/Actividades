using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial
{
    public class Pedido
    {
        public int NumeroPedido { get; set; }
        public DateTime Fecha { get; set; }
        public Cliente Cliente { get; set; }
        public double Monto { get; set; }
        public double Total { get; private set; }

        public Pedido(int numeroPedido, Cliente cliente, double monto)
        {
            NumeroPedido = numeroPedido;
            Cliente = cliente;
            Monto = monto;
            Fecha = DateTime.Now;
        }

        public void CalcularTotal(double monto)
        {
            if (Cliente is ClientePremium premium)
            {
                Total = monto - (monto * premium.Descuento / 100);
            }
            else
            {
                Total = monto;
            }
        }
    }

}
