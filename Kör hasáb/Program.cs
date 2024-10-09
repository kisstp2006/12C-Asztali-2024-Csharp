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
            //Osztály felhasználása
            //1. objektum
            Kor kor = new Kor();
            kor.ReadSugar(15);
            kor.SetKerulet();
            kor.SetTerulet();
            Console.WriteLine("A sugara a körnek: "+kor.GetSugar());
            Console.WriteLine("A kerüéete a körnek: "+kor.GetKerulet());
            Console.WriteLine("A terüéete a körnek: "+ kor.GetTerulet());
            Console.ReadKey();
            #endregion Eof 1. oobjektum

            #region 2. objektum
            Console.Clear();
            Kor k2 = new Kor(28.7);
            k2.SetKerulet();
            k2.SetTerulet();
            Console.WriteLine("A sugara a körnek: " + k2.GetSugar());
            Console.WriteLine("A kerüéete a körnek: " + k2.GetKerulet());
            Console.WriteLine("A terüéete a körnek: " + k2.GetTerulet());
            Console.ReadKey();
            #endregion
        }
    }
}
