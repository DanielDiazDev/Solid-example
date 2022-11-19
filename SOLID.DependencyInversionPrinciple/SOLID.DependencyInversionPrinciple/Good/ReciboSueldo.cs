using SOLID.DependencyInversionPrinciple.Bad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.DependencyInversionPrinciple
{
    class ReciboSueldo : IImprimible
    {
        public ReciboSueldo(int legajo, double total)
        {
            Total = total;
            Legajo = legajo;
        }

        public double Total { get; set; }
        public int Legajo { get; set; }
        public void Imprimir()
        {
            Console.WriteLine($"Imprimiendo recibo de sueldo del legajo {Legajo} por un total de {Total}");

        }
    }
}