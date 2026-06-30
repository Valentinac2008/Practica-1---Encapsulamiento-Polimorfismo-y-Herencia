using System;

namespace ConsoleApp4
{
    static void main()
    {

        List<Alerta> lista = new List<Alerta>()
        {
            lista.Add(new IntrusionRed());
        lista.Add(new MalwareDetectado());

        };
        

        foreach (Alerta item in lista)
        {
            Console.WriteLine(item.DispararProtocolo());
        }
            
    }

}