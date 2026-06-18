using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class Camioneta : Vehiculo
    {
        public bool Traccion4x4 { get; set; }

        public Camioneta(string marca, bool traccion4x4)
            : base(marca)
        {
            Traccion4x4 = traccion4x4;
        }

        public override string Arrancar()
        {
            return $"La camioneta {Marca} arranca con tracción 4x4: {Traccion4x4}.";
        }
    }
}
