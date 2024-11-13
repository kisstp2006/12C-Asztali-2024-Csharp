using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            Téglatest teglatest = new Téglatest();
            teglatest.ReadAoldal(5);
            teglatest.ReadBoldal(15);
            teglatest.ReadColdal(15);
            teglatest.TerfogatSzamit();
            teglatest.FelszinSzamit();
            Console.WriteLine("\n A téglatest felszine:" + teglatest.Returnfelszin()+"cm");
            Console.WriteLine("\n A téglatest térfogata:" + teglatest.ReturnTerfogat()+"cm2");
            Console.ReadKey();


            Téglatest teglatest2 = new Téglatest();
            Console.WriteLine("Adja meg az 'a' oldalt: ");
            teglatest2.ReadAoldal( int.Parse(Console.ReadLine()));
            Console.WriteLine("Adja meg az 'b' oldalt: ");
            teglatest2.ReadBoldal(int.Parse(Console.ReadLine()));
            Console.WriteLine("Adja meg az 'c' oldalt: ");
            teglatest2.ReadColdal(double.Parse(Console.ReadLine()));
            teglatest2.TerfogatSzamit();
            teglatest2.FelszinSzamit();
            Console.WriteLine("A téglatest felszine:" + teglatest2.Returnfelszin() + "cm");
            Console.WriteLine("A téglatest térfogata:" + teglatest2.ReturnTerfogat() + "cm2");
            Console.ReadKey();
        }
    }
}
