﻿using System;

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
            PrintTriangleProperties(randomTriangle);

            // Felhasználói bemenet
            Console.WriteLine("\nKérem az oldalakat:");
            Console.Write("a: ");
            int userA = int.Parse(Console.ReadLine());
            Console.Write("b: ");
            int userB = int.Parse(Console.ReadLine());
            Console.Write("c: ");
            int userC = int.Parse(Console.ReadLine());

            HTipus userTriangle = new HTipus(userA, userB, userC);
            PrintTriangleProperties(userTriangle);
        }

        static void PrintTriangleProperties(HTipus triangle)
        {
            Console.WriteLine($"Ez háromszög: {triangle.EzHaromszog()}");
            Console.WriteLine($"Derékszögű: {triangle.Derekszogue()}");
            Console.WriteLine($"Egyenlő szárú: {triangle.Egyenloszarue()}");
            Console.WriteLine($"Egyenlő oldalú: {triangle.Egyenlooldalu()}");
        }
    }
}
