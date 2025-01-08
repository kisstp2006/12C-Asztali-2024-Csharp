using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoList
{
    class Program
    {

        static void Main(string[] args)
        {
            // A jarmuvek listaja
            List<JarmuClass> jarmuvek = new List<JarmuClass>();

            // Adja meg a file nevét
            Console.Write("Kérem adja meg a fájl nevét: ");
            string fileName = Console.ReadLine();
            //Kiserlet a file beolvasására

            try
            {
                Beolvas(fileName, jarmuvek);
                Console.WriteLine("\nAdatok sikeresen beolvasva.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Hiba történt a fájl beolvasása során: " + ex.Message);
                return;
            }
            // Kiíratás táblázatos formában
            Console.WriteLine("\nA beolvasott adatok:");
            Kiir(jarmuvek);
        }

        private static void Beolvas(string fileName, List<JarmuClass> jarmuvek)
        {

            throw new NotImplementedException();
        }
    }
}
