using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class AutoElectrico : Vehiculo
    {
        public int Autonomia { get; set; }

        public AutoElectrico(string marca, int autonomia)
            : base(marca)
        {
            Autonomia = autonomia;
        }

        public override string Arrancar()
        {
            return $"El auto eléctrico {Marca} arranca silenciosamente. Autonomía: {Autonomia} km.";
        }
    }
}