using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mátrix
{
    class MatrixN
    {
        //Class viariables
        int n1 = 0;
        int n2 = 0;
        public MatrixN()
        {

        }
        public void MatrixMeret(int magassag, int hossusag)
        {
             n1 = magassag;
             n2 = hossusag;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mátrix");
            Console.ReadKey();
            
        }
    }
}
