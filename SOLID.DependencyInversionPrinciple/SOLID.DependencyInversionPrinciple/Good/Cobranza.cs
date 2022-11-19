using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.DependencyInversionPrinciple
{
    public class Cobranza : IImprimible
    {
        public Cobranza(double importe, int numero)
        {
            Importe = importe;
            Numero = numero;
        }

        public double Importe { get; set; }
        public int Numero { get; set; }

        public void Imprimir()
        {
            Console.WriteLine($"Imprimiendo cobranza numero {Numero} de un importe de {Importe}");
        }
    }
}
