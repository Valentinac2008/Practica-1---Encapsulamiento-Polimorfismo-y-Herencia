using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    public class Instrumento
    {
        private string modelo;

        public string Modelo
        {
            get { return modelo; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                    modelo = value;
                else
                    modelo = "Desconocido";
            }
        }

        public Instrumento(string modelo)
        {
            Modelo = modelo;
        }

        public virtual string TocarNota()
        {
            return "Sonando nota musical.";
        }
    }
}
