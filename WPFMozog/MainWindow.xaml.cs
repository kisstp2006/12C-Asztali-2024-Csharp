using System.Windows;

namespace WPFMozog
{
    public partial class MainWindow : Window
    {
        private int valtmagassag = 20, valtszelesseg = 20;
        private float OpacityVar = 1f;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnJobb_Click(object sender, RoutedEventArgs e)
        {
            if (Left + Width + 5 <= SystemParameters.WorkArea.Width)
                Left += 5;
        }

        private void btnFel_Click(object sender, RoutedEventArgs e)
        {
            if (Top > 0)
                Top -= 5;
        }

        private void btnFelul_Click(object sender, RoutedEventArgs e)
        {
            Top = 0;
        }

        private void btnJobbszel_Click(object sender, RoutedEventArgs e)
        {
            Left = SystemParameters.WorkArea.Width - Width;
        }

        private void btnLe_Click(object sender, RoutedEventArgs e)
        {
            if (Top + Height + 5 <= SystemParameters.WorkArea.Height)
                Top += 5;
        }

        private void btnAlul_Click(object sender, RoutedEventArgs e)
        {
            Top = SystemParameters.WorkArea.Height - Height;
        }

        private void button9_Click(object sender, RoutedEventArgs e)
        {
            Left = (SystemParameters.WorkArea.Width - Width) / 2;
            Top = (SystemParameters.WorkArea.Height - Height) / 2;
        }

        private void btnBalra_Click(object sender, RoutedEventArgs e)
        {
            if (Left > 0)
                Left -= 5;
        }

        private void btnBalszel_Click(object sender, RoutedEventArgs e)
        {
            Left = 0;
        }

        private void btnOpNo_Click(object sender, RoutedEventArgs e)
        {
            if (OpacityVar < 1)
            {
                OpacityVar += 0.1f;
                Opacity = OpacityVar;
            }
        }

        private void btnOpCsok_Click(object sender, RoutedEventArgs e)
        {
            if (OpacityVar > 0.1)
            {
                OpacityVar -= 0.1f;
                Opacity = OpacityVar;
            }
        }

        private void btnMeretNo_Click(object sender, RoutedEventArgs e)
        {
            if (Height + valtmagassag <= SystemParameters.WorkArea.Height)
                Height += valtmagassag;

            if (Width + valtszelesseg <= SystemParameters.WorkArea.Width)
                Width += valtszelesseg;
        }

        private void btnCsok_Click(object sender, RoutedEventArgs e)
        {
            if (Height - valtmagassag >= 100) // Minimum height
                Height -= valtmagassag;

            if (Width - valtszelesseg >= 100) // Minimum width
                Width -= valtszelesseg;
        }
    }
}
