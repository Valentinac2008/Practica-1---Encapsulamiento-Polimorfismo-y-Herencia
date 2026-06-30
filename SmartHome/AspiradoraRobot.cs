using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class AspiradoraRobot : Dispositivo
    {
        public string PropiedadEspecial { get; set; }

        public override string EjecutarFuncion()
        {
            return "AspiradoraRobot ejecutando acción específica";
        }
    }

}
