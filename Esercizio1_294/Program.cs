using System;
using System.Collections.Generic;

namespace Esercizio1_294  //DA FINIRE
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            int max = 1000;
            int min = int.MinValue;
            int n = 30;
            List<int> lista = new List<int>();
            List<int> pari = new List<int>();
            for (int i = 0; i < n; i++)
            {
                lista.Add(r.Next(min, max));
                if (lista[i] % 2 == 0)
                    pari.Add(lista[i]);
            }
            for (int i = 0; i < pari.Count; i++)
            {
                int temp;
                for (int y = 0; y < pari.Count; y++)
                {
                    try
                    {
                        if (pari[y] > pari[y + 1])
                        {
                            temp = pari[y];
                            pari[y] = pari[y + 1];
                            pari[y + 1] = temp;
                        }
                    }
                    catch { }
                }
            }
            Console.WriteLine("Numeri della lista:");
            for (int i = 0; i < lista.Count; i++)
            {
                Console.WriteLine(lista[i]);
            }
            Console.WriteLine("Numeri pari ordinati:");
            for (int i = 0; i < pari.Count; i++)
            {
                Console.WriteLine(pari[i]);
            }
            Console.ReadLine();
        }
    }
}
