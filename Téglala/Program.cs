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
        }
    }
}
