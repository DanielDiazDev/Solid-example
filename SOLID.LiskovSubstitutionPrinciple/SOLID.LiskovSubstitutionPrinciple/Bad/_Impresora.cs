using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.LiskovSubstitutionPrinciple.Bad
{
    class _Impresora
    {
        public void ImprimirRemito(_Remito unRemito)
        {
            Console.WriteLine(unRemito.Imprimir());
        }

        public void ImprimirFactura(_Factura unafactura)
        {
            Console.WriteLine(unafactura.Imprimir());
        }

        public void ImprimirNotaCredito(_NotaCredito unaNotaCredito)
        {
            Console.WriteLine(unaNotaCredito.Imprimir());
        }
    }
}