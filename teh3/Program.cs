using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teh3
{
    class Program
    {
        static void Main(string[] args)
        {
            int luku1, luku2, luku3, summa, keskiarvo;

            Console.Write("Anna luku1 > ");
            luku1 = int.Parse(Console.ReadLine());

            Console.Write("Anna luku2 > ");
            luku2 = int.Parse(Console.ReadLine());

            Console.Write("Anna luku3 > ");
            luku3 = int.Parse(Console.ReadLine());

            summa = luku1 + luku2 + luku3;
            keskiarvo = summa / 3;

            Console.WriteLine("Lukujen summa: " + summa);
            Console.WriteLine("Lukujen keskiarvo: " + keskiarvo);
        }
    }
}
