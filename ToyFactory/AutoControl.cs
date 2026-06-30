using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    public class AutoControl : Juguete
    {
        public string PropiedadEspecial { get; set; }

        public override string ProbarJuguete()
        {
            return "AutoControl ejecutando acción específica";
        }
        
    }
}
