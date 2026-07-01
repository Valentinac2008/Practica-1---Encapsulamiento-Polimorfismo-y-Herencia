using ConsoleApp8;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;

class Program
{
    static void Main()
    {
        List<Hechizo> lista = new List<Hechizo>();
        lista.Add(new BolaFuego());
        lista.Add(new EscudoHielo());

        foreach (Hechizo item in lista) {
            Console.WriteLine(item.Lanzar());
        }


    }
}