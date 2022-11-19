using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.OpenClosedPrinciple
{
    public class CajaAhorro : DocumentoContable
    {
        public CajaAhorro(int numero) : base(numero)
        {

        }

        public override string Descripcion()
        {
            return $"CA-{Numero}";

        }
    }
}
