using System;

namespace ConsoleApp1
{
    List<Dispositivo> lista = new List<Dispositivo>();
    lista.Add(new AspiradoraRobot());
    lista.Add(new LamparaInteligente());

    foreach(Dispositivo item in lista)
    Console.WriteLine(item.EjecutarFuncion());

}