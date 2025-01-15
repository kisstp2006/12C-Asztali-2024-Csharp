using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poliformoop
{
    class PoliformOOP
    {
        static void Main(string[] args)
        {

            Haz Otthon = new Haz();

            No eva = new No("Eva", "zold");
            No lara = new No("Lara", "barna");
            No kati = new No("Kati", "barna");
            No sari = new No("Sari", "kék");
            No zsuzsi = new No("Zsuzsi", "zöldd");
            Ferfi ferfi = new Ferfi("Pisti",40);
            Ferfi adam = new Ferfi("Ádám",20);
            Ferfi dani = new Ferfi("Dani",20);
            Ferfi gergp = new Ferfi("Gergp",20);
            Ferfi attila = new Ferfi("Attola",20);

            if (eva is Nber) Otthon.hazajon((Nber)eva);
            Otthon.hazajon((Nber)eva);
            Otthon.hazajon((Nber)lara);
            Otthon.hazajon((Nber)kati);
            Otthon.hazajon((Nber)sari);
            Otthon.hazajon((Nber)zsuzsi);
            Otthon.hazajon((Nber)ferfi);
            Otthon.hazajon((Nber)adam);
            Otthon.hazajon((Nber)gergp);
            Otthon.hazajon((Nber)dani);
            Otthon.hazajon((Nber)attila);

            bool tovabb = true;
            do
            {
                Otthon.csenget();
                tovabb = (Console.ReadLine() == String.Empty) ? false : true;
            } while (tovabb);

            Console.ReadKey();
        }
    }
}
