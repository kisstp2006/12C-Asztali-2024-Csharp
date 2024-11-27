using System;

namespace TöbbElemV2
{
    class TobbElemOsztály
    {
        private int szam;
        private bool IsParos;

        public TobbElemOsztály()
        {
            this.szam = 0;
            this.IsParos = false;
        }
        public void GetSzam(int p)
        {
            this.szam = p;
        }
        public void SetSzamTípus()
        {
            this.IsParos = szam % 2 == 0;
        }
        public bool OutSzamTípus()
        {

            return IsParos;
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

            while (paros + paratlan < 100)
            {
                Console.WriteLine("Adjon meg egy számot");
                var szam = Convert.ToInt32(Console.ReadLine());
                a.GetSzam(szam);
                a.SetSzamTípus();
                if (a.OutSzamTípus())
                {
                    valasz = "páros";
                    paros += szam;
                }
                else
                {
                    valasz = "páratlan";
                    paratlan += szam;
                }

            }
            Console.WriteLine($"A szám típusa " + valasz);
            Console.ReadKey();
        }
    }
}
