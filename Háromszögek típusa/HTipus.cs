using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Háromszögek_típusa
{
    class HTipus
    {
        private int a, b, c;
        public HTipus()
        {


        }
        public HTipus(int a, int b, int c )
        {
            this.a = a;
            this.b = b;
            this.c = c;

        }
        public bool EzHaromszog() {
            var igaze = false;
            if (this.a+ this.b > this.c)
            {
                igaze = true;
            }
            else if (this.a + this.c > this.b)
            {
                igaze = true;
            }
            else if (this.b + this.c > this.a)
            {
                igaze = true;
            }
            else
            {
                igaze = false;
            }
            return igaze;
        }
        public bool Derekszogue()
        {
            if (this.a* this.a + this.b * this.b = this.c * this.c)
            {

            }

            return false;
        }
    }
}
