using System;
using System.Collections.Generic;

namespace Esercizio2_278
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quanti numeri vuoi inserire?");
            int n = int.Parse(Console.ReadLine());
            int max = int.MaxValue;
            int min = int.MinValue;
            Random r = new Random();
            List<int> lista = new List<int>();
            for (int i = 0; i < n; i++)
            {
                lista.Add(r.Next(min, max));
                min = lista[i];
            }

        }
    }
}
