using System;

namespace Solid.SingleResponsabilityPrinciple
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cliente c = new Cliente();
            c.Apellido = "Diaz";
            c.Nombre = "Daniel";
            Factura f = new Factura(234124, c);

            Item i1 = new Item(new Producto("Queso", 10), 5);
            Item i2 = new Item(new Producto("Fideos", 32), 4);
            Item i3 = new Item(new Producto("Zanahorias", 12), 6);

            f.Items.Add(i1);
            f.Items.Add(i2);
            f.Items.Add(i3);

            Console.WriteLine(f.Total());

            Console.ReadKey();
        }
    }
}
