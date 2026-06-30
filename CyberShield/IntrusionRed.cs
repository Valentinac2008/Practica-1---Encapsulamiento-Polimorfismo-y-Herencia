using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    public class IntrusionRed : Alerta
    {
        public string PropiedadEspecial { get; set; }

        public override string DispararProtocolo()
        {
            return "IntrusionRed ejecutando acción específica";
        }
    }

}
