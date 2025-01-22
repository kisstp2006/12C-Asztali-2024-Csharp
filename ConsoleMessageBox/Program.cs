using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Windows;


namespace ConsoleMessageBox
{
    class Program
    {
        //
        [DllImport("User32.dll", CharSet = CharSet.Unicode)]
        public static extern int MessageBox(IntPtr h, string m, string c, int type);

        static void Main(string[] args)
        {
            Console.ReadKey();
               var result = MessageBox((IntPtr)0, "Doboz", "Üzenet doboz", 1);

            if (result == 1)
            {
                Console.WriteLine("Ok nyomva");
                Console.ReadKey();
            }

            if(result == 2)
            {
                Console.WriteLine("Mégse nyomva");
                Console.ReadKey();
            }
        }
    }
}
