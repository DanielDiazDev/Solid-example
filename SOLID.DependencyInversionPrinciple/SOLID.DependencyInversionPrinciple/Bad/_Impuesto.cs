using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.DependencyInversionPrinciple.Bad
{
    public abstract class _Impuesto
    {
        public _Impuesto(double importe)
        {
            Importe = importe;
        }

        public double Importe { get; set; }
    }
}