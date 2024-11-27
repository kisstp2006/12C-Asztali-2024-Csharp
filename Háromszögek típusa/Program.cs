using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Háromszögek_típusa
{
    class Program
    {
        public int  a, b, c;
        static void Main(string[] args)
        {
            Console.WriteLine("Kérem az A oldalt:");
            a = int.Parse(Console.ReadLine());
            HTipus haromszogtipus = new HTipus(1,2,5);
            if (haromszogtipus.EzHaromszog())
            {

            }
        }
    }
}
