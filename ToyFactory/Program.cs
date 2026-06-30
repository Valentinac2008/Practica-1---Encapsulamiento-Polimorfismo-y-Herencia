using ConsoleApp5;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;

class Program
{
    static void Main()
    {
        List<Juguete> lista = new List<Juguete>();
        lista.Add(new Muñeca());
        lista.Add(new AutoControl());

        foreach (Juguete item in lista)
        {
            Console.WriteLine(item.ProbarJuguete());
        }
           
    }
}
