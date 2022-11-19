using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.LiskovSubstitutionPrinciple.Bad
{
    class _Factura : _Documento
    {
        public _Factura(int numero, DateTime fecha) : base(numero, fecha)
        {
            _sigla = "FC";
        }
    }
}