using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    public class Lanzamisiles : Torreta
    {
        public string PropiedadEspecial { get; set; }

        public override string Disparar()
        {
            return "Lanzamisiles ejecutando acción específica";
        }
    }

}
