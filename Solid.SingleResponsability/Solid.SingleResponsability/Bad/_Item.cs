using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.SingleResponsabilityPrinciple.Bad
{
    public class _Item
    {
        public _Item(_Producto producto, int cantidad)
        {
            Producto = producto;
            Cantidad = cantidad;
        }

        public _Producto Producto { get; set; }
        public int Cantidad { get; set; }
    }
}
