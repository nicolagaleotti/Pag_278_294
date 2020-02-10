using System;
using System.Collections.Generic;

namespace Esercizio4_294  //DA FINIRE
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quanti numeri vuoi?");
            int n = int.Parse(Console.ReadLine());
            int minimo = int.MinValue;
            int massimo = 1000;
            Console.WriteLine("Qual è il numero minore che vuoi nella lista?");
            int MAX = int.Parse(Console.ReadLine());
            Random r = new Random();
            List<int> lista = new List<int>();
            int numero;
            for(int i = 0; i < n; i++)
            {
                numero = r.Next(minimo, massimo);
                if (numero >= MAX)
                    lista.Add(numero);  
            }
            lista.Sort();
            Console.WriteLine($"Numeri della lista ordinati maggiori o uguali a {MAX} :");
            for (int i = 0; i < lista.Count; i++)
            {
                Console.WriteLine(lista[i]);
            }
            Console.ReadLine();
        }
    }
}
