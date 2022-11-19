using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.LiskovSubstitutionPrinciple.Bad
{
    public abstract class _Documento
    {
        protected string _sigla;

        public _Documento(int numero, DateTime fecha)
        {
            Numero = numero;
            Fecha = fecha;
        }

        public DateTime Fecha { get; set; }
        public int Numero { get; set; }


        public string Imprimir()
        {
            return $"Imprimiendo {Descripcion()}";
        }

        public virtual string Descripcion()
        {
            return $"{_sigla} nro {Numero} de fecha {Fecha.ToShortDateString()}";
        }
    }
}

