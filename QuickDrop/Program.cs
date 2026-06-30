using ConsoleApp7;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;

class Program
{
    static void Main()
    {
        List<Envio> lista = new List<Envio>();
        lista.Add(new EnvioExpress());
        lista.Add(new EnvioFragil());

        foreach (Envio item in lista)
        {
            Console.WriteLine(item.ProcesarEntrega());
        }
            
    }
}