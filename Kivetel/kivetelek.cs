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

        public void Altalanoshibakezeles()
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
                //throw;
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
                //throw;
            }

        }

        public void Hibakezeles2()
        {

        }
    }
}
