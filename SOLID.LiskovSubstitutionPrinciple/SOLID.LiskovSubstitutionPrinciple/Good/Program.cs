using System;

namespace SOLID.LiskovSubstitutionPrinciple
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Impresora impresora = new Impresora();

            Remito rto = new Remito(3331, DateTime.Now, 10);
            Factura fc = new Factura(6645, DateTime.Now);
            NotaCredito nc = new NotaCredito(200, DateTime.Now);

            impresora.ImprimirRemito(rto);
            impresora.Imprimir(fc);
            impresora.Imprimir(nc);

            Console.ReadKey();
        }
    }
}
