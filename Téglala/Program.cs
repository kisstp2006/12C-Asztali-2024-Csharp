using System;

namespace Téglalap
{
    class Program
    {
        static void Main(string[] args)
        {
            Teglalapszamitasok teglaszam = new Teglalapszamitasok();
            teglaszam.ReadAoldal(150);
            teglaszam.ReadBoldal(2501);
            teglaszam.TeruletSzam();
            teglaszam.KeruletSzam();
            Console.WriteLine($"A kerület az : {teglaszam.GetKerulet()} cm A terület: {teglaszam.GetTerulet()} cm2, Az a oldal : {teglaszam.GetAoldal()} b oldal : {teglaszam.GetBoldal()}");
            Console.ReadKey();


            Console.WriteLine("\n A oldal: 5cm \nBoldal=15cm \nColdal(Magassag)=15cm");
            Hasab hasab1 = new Hasab();
            hasab1.ReadAoldal(5);
            hasab1.ReadBoldal(15);
            hasab1.ReadColdal(15);
            hasab1.TerfogatSzamit();
            hasab1.FelszinSzamit();
            Console.WriteLine("\n A téglatest felszine:" + hasab1.Returnfelszin() + "cm");
            Console.WriteLine("\n A téglatest térfogata:" + hasab1.ReturnTerfogat() + "cm2");
            Console.ReadKey();


            Hasab hasab = new Hasab();
            Console.WriteLine("Adja meg az 'a' oldalt: ");
            hasab.ReadAoldal(int.Parse(Console.ReadLine()));
            Console.WriteLine("Adja meg az 'b' oldalt: ");
            hasab.ReadBoldal(int.Parse(Console.ReadLine()));
            Console.WriteLine("Adja meg az 'c' oldalt: ");
            hasab.ReadColdal(double.Parse(Console.ReadLine()));
            hasab.TerfogatSzamit();
            hasab.FelszinSzamit();
            Console.WriteLine("A téglatest felszine:" + hasab.Returnfelszin() + "cm");
            Console.WriteLine("A téglatest térfogata:" + hasab.ReturnTerfogat() + "cm2");
            Console.ReadKey();



        }
    }
}
