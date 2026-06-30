using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class Empleado
    {
        private string dato;

        public string Dato
        {
            get { return dato; }
            set { dato = string.IsNullOrWhiteSpace(value) ? "Valor por defecto" : value; }
        }

        public virtual string Trabajar()
        {
            return "Empleado ejecutando acción";
        }
    }

}
