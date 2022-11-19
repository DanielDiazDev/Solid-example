using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.DependencyInversionPrinciple.Bad
{
    class _NotaCredito : _DocumentoContable
    {
        public _NotaCredito(int numero, DateTime fecha, double importe) : base(numero, fecha, importe)
        {
            _sigla = "NC";
        }

        public override double Total()
        {
            return Importe * 1.21 * -1;
        }
    }
}