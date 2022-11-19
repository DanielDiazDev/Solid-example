using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.InterfaceSegregationPrinciple.Bad
{
    class _FacturaElectronica : _Documento
    {
        public _FacturaElectronica(int numero, DateTime fecha) : base(numero, fecha) { }
        public string CAE { get; set; }


        public override void EnviarPorEmail()
        {

            Console.WriteLine($"Enviando por email la factura electronica {Numero} del dia {Fecha}");
        }

        public override void Imprimir()
        {
            Console.WriteLine($"Imprimiendo la factura electronica {Numero} del dia {Fecha}");
        }
    }
}