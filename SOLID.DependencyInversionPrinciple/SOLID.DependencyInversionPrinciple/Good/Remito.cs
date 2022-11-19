using SOLID.DependencyInversionPrinciple.Bad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.DependencyInversionPrinciple
{
    class Remito : IImprimible
    {
        public Remito(int numero, DateTime fecha, int bultos)
        {
            CantBultos = bultos;
            Numero = numero;
            Fecha = fecha;
        }

        public int CantBultos { get; set; }
        public DateTime Fecha { get; set; }
        public int Numero { get; set; }
        public void Imprimir()
        {
            Console.WriteLine($"Imprimiendo remito numero {Numero} del {Fecha} con un numero de bultos de {CantBultos}");

        }
    }
}