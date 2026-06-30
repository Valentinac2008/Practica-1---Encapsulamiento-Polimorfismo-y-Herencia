using ConsoleApp6;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;

class Program
{
    static void Main()
    {
        List<Torreta> lista = new List<Torreta>();
        lista.Add(new TorretaLaser());
        lista.Add(new Lanzamisiles());

        foreach (Torreta item in lista)
        {
            Console.WriteLine(item.Disparar());
        }
            

    }
}