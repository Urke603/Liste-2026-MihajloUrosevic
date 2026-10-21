using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liste_2026_MihajloUrosevic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Graf_L novi = new Graf_L();
            bool Tacno = true;

            while (Tacno)
            {
                Console.WriteLine("Odaberite:");
                Console.WriteLine("1: Unos");
                Console.WriteLine("2: Snimi");
                Console.WriteLine("3: Ucitaj");
                Console.WriteLine("4: Ispis");
                Console.WriteLine("0: Kraj");
                int n = Convert.ToInt32(Console.ReadLine());

                switch (n)
                {
                    case 1:
                        novi = new Graf_L();
                        novi.Unos();
                        break;
                    case 4:
                        if (novi != null)
                        {
                            novi.Ispis();
                        }
                        break;
                    case 0:
                        Tacno = false;
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
