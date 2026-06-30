using System;

namespace ConsoleApp2
{
    List<Plato> lista = new List<Plato>();
    lista.Add(new Pizza());
lista.Add(new Ensalada());

foreach(Plato item in lista)
    Console.WriteLine(item.Preparar());



}