using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercizio14
{
    class Program2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("inserisci il prezzo: ");
            int prz1 = int.Parse(Console.ReadLine());
            

            Console.WriteLine("inserisci il prezzo: ");
            int prz2 = int.Parse(Console.ReadLine());
            if (prz1 > prz2)
            {
                double sconto = prz2 * 50 / 100;
                double total =  prz2 - sconto;
                double totale = total + prz1;
                Console.WriteLine($"il totale è {totale}");
            }
            else if(prz2>prz1)
            {
                double sconto = prz1 * 50 / 100;
                double totaleMaggior = prz2 - sconto;
                double totaleMaggiore = totaleMaggior + prz2;
                Console.WriteLine($"il totale è {totaleMaggiore}");
            }
            Console.ReadLine();
        }
    }
}
