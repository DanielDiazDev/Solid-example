using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.DependencyInversionPrinciple.Bad
{
    class _Municipal : _Impuesto
    {
        public _Municipal(double importe, string partida) : base(importe)
        {
            Partida = partida;
        }

        public string Partida { get; set; }
    }
}