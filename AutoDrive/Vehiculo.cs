using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class Vehiculo
    {
        private string marca;

        public string Marca
        {
            get { return marca; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                    marca = value;
                else
                    marca = "Sin Marca";
            }
        }

        public Vehiculo(string marca)
        {
            Marca = marca;
        }

        public virtual string Arrancar()
        {
            return $"El vehículo {Marca} ha arrancado.";
        }
    }
}
