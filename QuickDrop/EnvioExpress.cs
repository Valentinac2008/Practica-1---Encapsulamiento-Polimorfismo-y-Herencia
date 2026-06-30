using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    public class EnvioExpress : Envio
    {
        public string PropiedadEspecial { get; set; }

        public override string ProcesarEntrega()
        {
            return "EnvioExpress ejecutando acción específica";
        }
    }
}
