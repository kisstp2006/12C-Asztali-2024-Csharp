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
            return ((this.b + this.c > this.a) && (this.a + this.c > this.b) && (this.a + this.b > this.c));
        }
        public bool Derekszogue()
        {
            var igaze = false;
            if (this.a * this.a + this.b * this.b == this.c * this.c)
            {
                igaze = true;
            }

            return igaze;
        }
        public bool Egyenloszarue()
        {
            var igaze = false;
            if (this.a == this.b)
            {
                igaze = true;
            }
            if (this.a == this.c)
            {
                igaze = true;
            }
            if (this.b == this.c)
            {
                igaze = true;
            }
            return igaze;
        }
        public bool Egyenlooldalu()
        {
           
            return (this.a==this.b) && (this.c==this.b) ;
        }
    }
}
