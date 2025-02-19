namespace FormMozga
{
    public partial class Form1 : Form
    {
        //osztály változók
        private int valtmagassag = 20, valtszelesseg = 20, windowsizewidth, windowsizeheight;
        private float OpacityVar = 1f;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnMeretNo_Click(object sender, EventArgs e)
        {
            windowsizewidth = Screen.GetWorkingArea(this).Width;
            windowsizeheight = Screen.GetWorkingArea(this).Height;

            if (windowsizeheight > Height + valtmagassag)
                Height += valtmagassag;


            if (windowsizewidth > Width + valtszelesseg)
                Width += valtszelesseg;

        }

        private void btnCsok_Click(object sender, EventArgs e)
        {
            windowsizewidth = Screen.GetWorkingArea(this).Width;
            windowsizeheight = Screen.GetWorkingArea(this).Height;
            Console.WriteLine(Height);
            Console.WriteLine(windowsizeheight / 2);

            if (windowsizeheight / 2 < Height - valtmagassag)
                Height -= valtmagassag;
            if (windowsizewidth / 2 < Width - valtszelesseg)
                Width -= valtszelesseg;
        }

        private void btnOpNo_Click(object sender, EventArgs e)
        {

            if (OpacityVar > 0.1)
            {
                OpacityVar -= 0.1f;
            }

            Opacity = OpacityVar;
        }

        private void btnOpCsok_Click(object sender, EventArgs e)
        {
            if (OpacityVar < 1)
            {
                OpacityVar += 0.1f;
            }

            Opacity = OpacityVar;
        }

        private void btnFelul_Click(object sender, EventArgs e)
        {
            Location = new Point(Location.X, 0);
        }

        private void btnAlul_Click(object sender, EventArgs e)
        {
            windowsizeheight = Screen.GetWorkingArea(this).Height;
            Location = new Point(Location.X, windowsizeheight - Height);
        }

        private void btnFel_Click(object sender, EventArgs e)
        {
            if (Location.Y > 0)
                Location = new Point(Location.X, Location.Y - 5);
            else
                Location = new Point(Location.X, 0);

        }

        private void button9_Click(object sender, EventArgs e)
        {
            windowsizewidth = Screen.GetWorkingArea(this).Width;
            windowsizeheight = Screen.GetWorkingArea(this).Height;
            var kijelzokozep = new Point(windowsizewidth/5, windowsizeheight/5);
            Location = kijelzokozep;

        }
    }
}
