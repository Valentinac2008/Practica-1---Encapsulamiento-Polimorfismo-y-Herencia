using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    public class Piano : Instrumento
    {
        public int NumeroTeclas { get; set; }

        public Piano(string modelo, int numeroTeclas)
            : base(modelo)
        {
            NumeroTeclas = numeroTeclas;
        }

        public override string TocarNota()
        {
            return $"El piano {Modelo} toca una nota con {NumeroTeclas} teclas.";
        }
    }
}
