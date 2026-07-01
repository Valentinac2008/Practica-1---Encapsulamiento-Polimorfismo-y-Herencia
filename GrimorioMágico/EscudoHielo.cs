using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    public class EscudoHielo : Hechizo
    {
        public string PropiedadEspecial { get; set; }

        public override string Lanzar()
        {
            return "EscudoHielo ejecutando acción específica";
        }
    }

}
