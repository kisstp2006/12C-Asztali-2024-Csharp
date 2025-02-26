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
            // No changes needed here
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
            if (Height - valtmagassag >= 100) // Ensure minimum height
                Height -= valtmagassag;

            if (Width - valtszelesseg >= 100) // Ensure minimum width
                Width -= valtszelesseg;
        }

        private void btnOpNo_Click(object sender, EventArgs e)
        {
            if (OpacityVar > 0.1f)
            {
                OpacityVar -= 0.1f;
                Opacity = OpacityVar;
            }
        }

        private void btnOpCsok_Click(object sender, EventArgs e)
        {
            if (OpacityVar < 1f)
            {
                OpacityVar += 0.1f;
                Opacity = OpacityVar;
            }
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
            var kijelzokozep = new Point((windowsizewidth - Width) / 2, (windowsizeheight - Height) / 2);
            Location = kijelzokozep;
        }

        private void btnBalra_Click(object sender, EventArgs e)
        {
            if (Location.X > 0)
                Location = new Point(Location.X - 5, Location.Y);
            else
                Location = new Point(0, Location.Y);
        }

        private void btnBalszel_Click(object sender, EventArgs e)
        {
            Location = new Point(0, Location.Y);
        }

        private void btnLe_Click(object sender, EventArgs e)
        {
            if (Location.Y < Screen.GetWorkingArea(this).Height - Height)
                Location = new Point(Location.X, Location.Y + 5);
            else
                Location = new Point(Location.X, Screen.GetWorkingArea(this).Height - Height);
        }

        private void btnJobb_Click(object sender, EventArgs e)
        {
            if (Location.X < Screen.GetWorkingArea(this).Width - Width)
                Location = new Point(Location.X + 5, Location.Y);
            else
                Location = new Point(Screen.GetWorkingArea(this).Width - Width, Location.Y);
        }

        private void btnJobbszel_Click(object sender, EventArgs e)
        {
            Location = new Point(Screen.GetWorkingArea(this).Width - Width, Location.Y);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
