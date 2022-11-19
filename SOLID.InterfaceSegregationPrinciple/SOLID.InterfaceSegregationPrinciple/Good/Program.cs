using System;

namespace SOLID.InterfaceSegregationPrinciple
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Factura factura = new Factura(1234, DateTime.Now);
            factura.CAI = "2143234";

            FacturaElectronica facturaElectronica = new FacturaElectronica(23432, DateTime.Now);
            facturaElectronica.CAE = "23565676";

            facturaElectronica.Imprimir();
            facturaElectronica.EnviarPorEmail();
            factura.Imprimir();
            Console.ReadKey();
        }
    }
}
