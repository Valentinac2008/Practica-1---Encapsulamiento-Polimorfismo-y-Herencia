using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Plato
    {
        private string dato;

        public string Dato
        {
            get { return dato; }
            set { dato = string.IsNullOrWhiteSpace(value) ? "Valor por defecto" : value; }
        }

        public virtual string Preparar()
        {
            return "Plato ejecutando acción";
        }
    }

}
