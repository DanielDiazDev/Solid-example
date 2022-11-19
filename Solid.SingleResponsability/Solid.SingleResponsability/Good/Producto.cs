using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.SingleResponsabilityPrinciple
{
    public class Producto
    {
        public Producto(string descripcion, double precio)
        {
            Precio = precio;
            Descripcion = descripcion;
        }

        public double Precio { get; set; }
        public string Descripcion { get; set; }
    }
}
