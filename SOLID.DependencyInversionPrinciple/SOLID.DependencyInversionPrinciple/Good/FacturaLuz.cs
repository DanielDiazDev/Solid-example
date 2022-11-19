using SOLID.DependencyInversionPrinciple.Bad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.DependencyInversionPrinciple
{
    class FacturaLuz : Impuesto
    {
        public FacturaLuz(double importe, string codigoPago) : base(importe)
        {
            CodigoPago = codigoPago;
        }

        public string CodigoPago { get; set; }

        public override void Imprimir()
        {
            Console.WriteLine($"Imprimiendo factura de luz con codigo de pago nro {CodigoPago} por un importe de {Importe}");

        }
    }
}
