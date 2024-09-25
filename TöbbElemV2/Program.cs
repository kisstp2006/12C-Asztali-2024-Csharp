using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TöbbElemV2
{
    class TobbElemOsztály
    {
        private int szam;
        private bool IsParos;

        public TobbElemOsztály()
        {
        }
        public void GetSzam(int szam)
        {

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string valasz = String.Empty;
            int paros = 0;
            int paratlan = 0;
            TobbElemOsztály a = new TobbElemOsztály();

            while (paros+paratlan<100)
            {
                Console.WriteLine("Adjon meg egy számot");
                var szam = Convert.ToInt32(Console.ReadLine());

            }
        }
    }
}
