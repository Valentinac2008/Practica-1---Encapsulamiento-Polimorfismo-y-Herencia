using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Ensalada : Plato
    {
        public string PropiedadEspecial { get; set; }

        public override string Preparar()
        {
            return "Ensalada ejecutando acción específica";
        }
    }
}
