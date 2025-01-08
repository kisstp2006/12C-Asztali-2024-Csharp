using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kivetel
{
    class kivetelek
    {
        public void Nincskivetel()
        {
            Console.WriteLine("Nincs kivetel kezeles");
            int szam = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"A beírt szám:{szam}");
            Console.ReadKey();
        }

        public void Altalanokivetel()
        {
            Console.WriteLine("Van kivetel kezeles");

            try
            {
                int szam = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"A beírt szám:{szam}");
                Console.ReadKey();
            }
            catch
            {
                Console.WriteLine("hiba");
               
            }

        }
        public void Altalanoshibakezeles2()
        {
            Console.WriteLine("Van kivetel kezeles");

            try
            {
                int szam = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"A beírt szám:{szam}");
                Console.ReadKey();
            }
            catch (Exception e)
            {
                Console.WriteLine("A következő hiba lépett fel :", e);
                
            }

        }

        public void OsHiba()
        {
            Console.WriteLine("Van kivetel kezeles");

            try
            {
                int szam = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"A beírt szám:{szam}");
                Console.ReadKey();
            }
            catch (FormatException e)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(e);
              
            }
        }
        public void Kivetelsajatosztalyak()
        {
            Console.WriteLine("Van kivetel kezeles");

            try
            {
                int szam = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"A beírt szám:{szam}");
                Console.ReadKey();
            }
            catch (FormatException e)
            {
                throw new ArgumentException("Hiba");
              
            }

        }
    }
}
