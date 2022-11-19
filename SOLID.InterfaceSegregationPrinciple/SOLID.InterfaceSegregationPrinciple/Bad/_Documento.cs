using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.InterfaceSegregationPrinciple.Bad
{
    public abstract class _Documento
    {
        public _Documento(int numero, DateTime fecha)
        {
            Fecha = fecha;
            Numero = numero;
        }

        public DateTime Fecha { get; set; }
        public int Numero { get; set; }

        public abstract void Imprimir();
        public abstract void EnviarPorEmail();
    }
}