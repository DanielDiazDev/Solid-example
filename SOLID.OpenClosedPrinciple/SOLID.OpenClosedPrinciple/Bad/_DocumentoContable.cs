using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.OpenClosedPrinciple.Bad
{
    public class _DocumentoContable
    {
        public _DocumentoContable(_TipoDocumentoContable tipo, int numero)
        {
            Tipo = tipo;
            Numero = numero;
        }

        public DateTime Fecha { get; set; }
        public double Importe { get; set; }
        public int Numero { get; set; }
        public _TipoDocumentoContable Tipo { get; set; }

        public string Descripcion()
        {
            switch (Tipo)
            {
                case _TipoDocumentoContable.Factura:
                    return $"FC-{Numero}";

                case _TipoDocumentoContable.NotaCredito:
                    return $"NC-{Numero}";

                default:
                    return "N/D";
            }
        }
    }
}
