using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    public class EnvioFragil : Envio
    {
        public string PropiedadEspecial { get; set; }

        public override string ProcesarEntrega()
        {
            return "EnvioFragil ejecutando acción específica";
        }
    }
}
