using ConsoleApp3;
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<Vehiculo> vehiculos = new List<Vehiculo>();
            new AutoElectrico("Tesla", 500);
            new Camioneta("Ford", true);

        foreach (Vehiculo v in vehiculos)
        {
            Console.WriteLine(v.Arrancar());
        }
    }
}
