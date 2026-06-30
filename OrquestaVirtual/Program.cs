using ConsoleApp4;
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<Instrumento> instrumentos = new List<Instrumento>();
            new Guitarra("Yamaha", 6);
            new Piano("Casio", 88);

        foreach (Instrumento i in instrumentos)
        {
            Console.WriteLine(i.TocarNota());
        }
    }
}
