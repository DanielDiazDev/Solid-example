using System;
using System.Collections.Generic;

namespace SOLID.DependencyInversionPrinciple
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Impresora impresora = new Impresora();

            Factura factura = new Factura(1234, DateTime.Now, 30);
            NotaCredito notaCredito = new NotaCredito(432, DateTime.Now, 100);
            Remito remito = new Remito(543, DateTime.Now, 50);
            FacturaLuz facturaLuz = new FacturaLuz(654, "3465456464");
            Municipal municipal = new Municipal(1233, "45565774");

            Cobranza cobranza = new Cobranza(4345, 344);


            List<IImprimible> listas = new List<IImprimible>();
            listas.Add(factura);
            listas.Add(notaCredito);
            listas.Add(remito);
            listas.Add(facturaLuz);
            listas.Add(municipal);
            listas.Add(cobranza);

            foreach(var item in listas)
            {
                impresora.Imprimir(item);
            }
            Console.ReadKey();
        }
    }
}
