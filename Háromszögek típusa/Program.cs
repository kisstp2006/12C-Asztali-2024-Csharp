using System;

namespace Háromszögek_típusa
{
    class Program
    {
        static void Main(string[] args)
        {
            // Automatikus tesztelés véletlenszerű értékekkel
            Random rand = new Random();
            int a = rand.Next(1, 20);
            int b = rand.Next(1, 20);
            int c = rand.Next(1, 20);

            HTipus randomTriangle = new HTipus(a, b, c);
            Console.WriteLine($"Random háromszög oldalak: a={a}, b={b}, c={c}");
            Írjakiaharomszogadatait(randomTriangle);

            // Felhasználói bemenet
            Console.WriteLine("\nKérem az oldalakat:");
            Console.Write("a: ");
            int userA = int.Parse(Console.ReadLine());
            Console.Write("b: ");
            int userB = int.Parse(Console.ReadLine());
            Console.Write("c: ");
            int userC = int.Parse(Console.ReadLine());

            HTipus userTriangle = new HTipus(userA, userB, userC);
            Írjakiaharomszogadatait(userTriangle);
            Console.ReadKey();
        }

        static void Írjakiaharomszogadatait(HTipus haromszog)
        {
            Console.WriteLine($"Ez háromszög: {haromszog.EzHaromszog()}");
            Console.WriteLine($"Derékszögű: {haromszog.Derekszogue()}");
            Console.WriteLine($"Egyenlő szárú: {haromszog.Egyenloszarue()}");
            Console.WriteLine($"Egyenlő oldalú: {haromszog.Egyenlooldalu()}");
        }
    }
}
