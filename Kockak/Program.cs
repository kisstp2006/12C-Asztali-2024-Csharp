using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kockak
{
    class Program
    {
        static void Main(string[] args)
        {
            // Üres konstruktor
            NegyszogClass negyszog1 = new NegyszogClass();
            Console.WriteLine($"Terület: {negyszog1.GetTerulet()}, Kerület: {negyszog1.GetKerulet()}");

            // Négyzet konstruktor
            NegyszogClass negyszog2 = new NegyszogClass(4);
            Console.WriteLine($"Terület: {negyszog2.GetTerulet()}, Kerület: {negyszog2.GetKerulet()}");

            // Téglalap konstruktor
            NegyszogClass negyszog3 = new NegyszogClass(4, 5);
            Console.WriteLine($"Terület: {negyszog3.GetTerulet()}, Kerület: {negyszog3.GetKerulet()}");

            // SetOldal1 teszt
            negyszog1.SetOldal1(6);
            Console.WriteLine($"Terület: {negyszog1.GetTerulet()}, Kerület: {negyszog1.GetKerulet()}");

            // SetOldal2 teszt
            negyszog1.SetOldal2(6, 7);
            Console.WriteLine($"Terület: {negyszog1.GetTerulet()}, Kerület: {negyszog1.GetKerulet()}");
        }
    }
}
