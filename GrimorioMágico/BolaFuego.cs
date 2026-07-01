using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    public class BolaFuego : Hechizo
    {
        public string PropiedadEspecial { get; set; }

        public override string Lanzar()
        {
            return "BolaFuego ejecutando acción específica";
        }
    }

}
