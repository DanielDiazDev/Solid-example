using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.DependencyInversionPrinciple.Bad
{
    class _ReciboSueldo
    {
        public _ReciboSueldo(int legajo, double total)
        {
            Total = total;
            Legajo = legajo;
        }

        public double Total { get; set; }
        public int Legajo { get; set; }
    }
}