using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.LiskovSubstitutionPrinciple.Bad
{
    class _NotaCredito : _Documento
    {
        public _NotaCredito(int numero, DateTime fecha) : base(numero, fecha)
        {
            _sigla = "NC";
        }
    }
}