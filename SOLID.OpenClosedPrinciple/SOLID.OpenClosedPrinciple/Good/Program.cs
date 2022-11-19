using System;

namespace SOLID.OpenClosedPrinciple
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DocumentoContable unaFactura = new Factura(123456);
            Console.WriteLine(unaFactura.Descripcion());
            DocumentoContable unaDebito = new NotaDebito(654321);
            Console.WriteLine(unaDebito.Descripcion());
            DocumentoContable unaCajaAhorro = new CajaAhorro(567890);
            Console.WriteLine(unaCajaAhorro.Descripcion());
        }
    }
}
