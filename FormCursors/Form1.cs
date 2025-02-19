namespace FormCursors
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_MouseMove(object sender, MouseEventArgs e)
        {
            var N = e.X;
            var M = e.Y;
            Console.WriteLine(N + "  " + M);

            label1.Text = $"X:{N}  és Y:{M}";
            label1.Top = N;
            label1.Left = M;
        }
    }
}
