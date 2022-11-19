using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.SingleResponsabilityPrinciple.Good
{
    public class Item
    {
        public Item(Producto producto, int cantidad)
        {
            Producto = producto;
            Cantidad = cantidad;
        }

        public Producto Producto { get; set; }
        public int Cantidad { get; set; }


        public double Subtotal()
        {
            return Cantidad * Producto.Precio;
        }
    }
}
