using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liste_2026_MihajloUrosevic
{
    internal class Graf_L
    {
        public string[] cvor;
        public List<Grana>[] lista;

        public Graf_L()
        {

        }
        public void Unos()
        {
            Console.WriteLine("Broj cvorova = ");
            int n = Convert.ToInt32(Console.ReadLine());
            cvor = new string[n];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Cvor {i} = ");
                cvor[i] = Console.ReadLine();
            }

            lista = new List<Grana>[n];
            for (int i = 0; i < n; i++)
            {
                lista[i] = new List<Grana>();
                Console.WriteLine($"Sused cvora {cvor[i]}");
                int sused = Convert.ToInt32(Console.ReadLine());

                while (sused != -1)
                {
                    Console.WriteLine($"Tezina grane {i}");
                    int tezina = Convert.ToInt32(Console.ReadLine());

                    Grana nova = new Grana();
                    nova.kraj = sused;
                    nova.tezina = tezina;
                    lista[i].Add(nova);
                }
            }
            Console.WriteLine();
        }
        public void Ispis()
        {

            for (int i = 0; i < cvor.Length; i++)
            {
                Console.WriteLine($"Cvor {i} = {cvor[i]}");
                foreach (Grana grana in lista[i])
                {
                    Console.WriteLine($"Sused cvora {i} je {grana.kraj}, a tezina je {grana.tezina}");
                }
            }
            
        }
    }
}
