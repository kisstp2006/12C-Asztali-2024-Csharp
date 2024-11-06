using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kör_hasáb
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 1.objektum
            // Kör osztály felhasználása
            //1. objektum
            Kor k1 = new Kor(); //Azt a konstruktort hívja meg amelynek nincs paramétere
            k1.ReadSugar(15);
            k1.SetKerulet();
            k1.SetTerulet();
            Console.WriteLine("A sugara a körnek: "+k1.GetSugar());
            Console.WriteLine("A kerüéete a körnek: "+k1.GetKerulet());
            Console.WriteLine("A terüéete a körnek: "+ k1.GetTerulet());
            Console.ReadKey();
            #endregion 1. objektum vége

            #region 2. objektum
            Console.Clear();
            Kor k2 = new Kor(28.7);//Azt a konstruktort hívja meg amelynek van paramétere
            k2.SetKerulet();
            k2.SetTerulet();
            Console.WriteLine("A sugara a körnek: " + k2.GetSugar());
            Console.WriteLine("A kerüéete a körnek: " + k2.GetKerulet());
            Console.WriteLine("A terüéete a körnek: " + k2.GetTerulet());
            Console.ReadKey();
            #endregion 2. objektum vége

            #region Kör 2 használata
            Kor2 k21 = new Kor2(24.5);
            Console.WriteLine($"A kör adatai: \n sugár= "+ k21.GetSugar()+"\n Terület: "+k21.GetTerulet()+"\n Terule: "+k21.GetKerulet());
            Console.ReadKey();
            #endregion

            #region Térfogat
            Henger henger = new Henger(15, 30);
            Console.WriteLine("Térfogat: "+henger.GetTerfogat()+"\n Sugara: "+henger.GetSugar()+"\n Magassag"+henger.GetMagassag());
            Console.ReadKey();
            #endregion
        }
    }
}
