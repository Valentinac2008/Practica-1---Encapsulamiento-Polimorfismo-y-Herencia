using System;

namespace ConsoleApp3
{
    List<Empleado> lista = new List<Empleado>();
    lista.Add(new Programador());
lista.Add(new Diseñador());

foreach(Empleado item in lista){
    Console.WriteLine(item.Trabajar());
}


}
