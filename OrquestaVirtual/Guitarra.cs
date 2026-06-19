using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    public class Guitarra : Instrumento
    {
        public int NumeroCuerdas { get; set; }

        public Guitarra(string modelo, int numeroCuerdas)
            : base(modelo)
        {
            NumeroCuerdas = numeroCuerdas;
        }

        public override string TocarNota()
        {
            return $"La guitarra {Modelo} toca una nota con {NumeroCuerdas} cuerdas.";
        }
    }
}
