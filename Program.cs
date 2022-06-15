using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.SDK_Laboratoire1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\t\t\t\t\tConvertiseur alphabetique! ");
            Console.WriteLine("\n\t\t\t\t\t\t\t A = La ");
            Console.WriteLine("\n\t\t\t\t\t\t\t B = Si ");
            Console.WriteLine("\n\t\t\t\t\t\t\t C = Do ");
            Console.WriteLine("\n\t\t\t\t\t\t\t D = Re ");
            Console.WriteLine("\n\t\t\t\t\t\t\t E = Mi ");
            Console.WriteLine("\n\t\t\t\t\t\t\t F = Fa ");
            Console.WriteLine("\n\t\t\t\t\t\t\t G = Sol ");
            Console.Write("\n\t\t\t\t\t\tEcrire votre choix: ");
            string choix = Console.ReadLine();
            var input = Console.ReadLine();
            Console.WriteLine("\t\t\t\t\t\tTu as choisi: " + choix);
        }
    }
}
