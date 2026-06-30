using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class Diseñador : Empleado
    {
        public string PropiedadEspecial { get; set; }

        public override string Trabajar()
        {
            return "Disenador ejecutando acción específica";
        }
    }
}
