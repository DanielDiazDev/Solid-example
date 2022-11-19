using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.SingleResponsabilityPrinciple.Bad
{
    public class _Factura
    {
        public _Factura(int numero, string apellido, string nombre)
        {
            Numero = numero;
            Apellido = apellido;
            Nombre = nombre;
            Items = new List<_Item>();
        }

        public int Numero { get; set; }
        public DateTime Fecha { get; set; }
        public string Apellido { get; set; }
        public string Nombre { get; set; }
        public List<_Item> Items { get; set; }


        public double Total()
        {
            double total = 0;
            foreach (var item in Items)
            {
                total += item.Cantidad * item.Producto.Precio;
            }
            return total;
        }
    }
}
