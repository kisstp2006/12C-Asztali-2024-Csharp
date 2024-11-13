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


            Console.WriteLine("A oldal: 5cm \nBoldal=15cm \nColdal(Magassag)=15cm");
            Téglatest teglatest = new Téglatest();
            teglatest.ReadAoldal(5);
            teglatest.ReadBoldal(15);
            teglatest.ReadColdal(15);
            teglatest.TerfogatSzamit();
            teglatest.FelszinSzamit();
            Console.WriteLine("A téglalap felszine:"+ teglatest.Returnfelszin()+"cm");
            Console.WriteLine("A téglalap térfogata:"+ teglatest.ReturnTerfogat()+"cm2");
            Console.ReadKey();


            Console.WriteLine("Adja meg az 'a' oldalt: ");
            teglatest.ReadAoldal( int.Parse(Console.ReadLine()));
            Console.WriteLine("Adja meg az 'b' oldalt: ");
            teglatest.ReadBoldal(int.Parse(Console.ReadLine()));
            Console.WriteLine("Adja meg az 'c' oldalt: ");
            teglatest.ReadColdal(double.Parse(Console.ReadLine()));
            Console.WriteLine("A téglalap felszine:" + teglatest.Returnfelszin() + "cm");
            Console.WriteLine("A téglalap térfogata:" + teglatest.ReturnTerfogat() + "cm2");
        }
    }
}
