using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.DependencyInversionPrinciple.Bad
{
    class _Impresora
    {
        public void Imprimir(_Factura factura)
        {
            Console.WriteLine($"Imprimiendo factura {factura.Numero} del {factura.Fecha} por un importe de {factura.Importe}");
        }

        public void Imprimir(_NotaCredito notaCredito)
        {
            Console.WriteLine($"Imprimiendo nota de credito {notaCredito.Numero} del {notaCredito.Fecha} por un importe de {notaCredito.Importe}");
        }

        public void Imprimir(_FacturaLuz facturaLuz)
        {
            Console.WriteLine($"Imprimiendo factura de luz con codigo de pago nro {facturaLuz.CodigoPago} por un importe de {facturaLuz.Importe}");
        }

        public void Imprimir(_Municipal municipal)
        {
            Console.WriteLine($"Imprimiendo impuesto municipal de partida {municipal.Partida} por un importe de {municipal.Importe}");
        }

        public void Imprimir(_ReciboSueldo reciboSueldo)
        {
            Console.WriteLine($"Imprimiendo recibo de sueldo del legajo {reciboSueldo.Legajo} por un total de {reciboSueldo.Total}");
        }

        public void Imprimir(_Remito remito)
        {
            Console.WriteLine($"Imprimiendo remito numero {remito.Numero} del {remito.Fecha} con un numero de bultos de {remito.CantBultos}");
        }
    }
}