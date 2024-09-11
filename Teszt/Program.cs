using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teszt
{
    class Program
    {
        static void Main(string[] args)
        {
            int Összeg = 0;
            //Teszt 
            while(Összeg<100) { 
                Console.WriteLine("Adjon meg számokat addig ameddig az összegük nem éri el a 100 at");
                var szam = int.Parse(Console.ReadLine());
                if (szam!=null) //Hogyha semmit nem írunk be nem fut le a program mivel rendes inputra vár
                {
                Console.WriteLine("A jelenleg megadott szám: "+szam.ToString());
                Összeg += szam;
                Console.WriteLine("Az eddigi összeg: "+Összeg);
                    if (Összeg >= 100)
                    {
                        Console.WriteLine("Az eddigi összeg több mint 100: " + Összeg);
                        Console.ReadKey();
                        break;
                    }
                    
                }
            }

            Console.WriteLine("Szia, Hello világ");
        }
    }
}
