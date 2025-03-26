using System;

namespace Halmazok
{
    public partial class Form1 : Form
    {
        Random rnd = new Random();
        List<int> ahalmazszamok = new List<int>();
        List<int> bhalmazszamok = new List<int>();

        public Form1()
        {
            InitializeComponent();
        }

        private void generate_Click(object sender, EventArgs e)
        {
            ahalmaz.Items.Clear();
            bhalmaz.Items.Clear();
            metszetform.Items.Clear();
            unionform.Items.Clear();
            BcomplementA.Items.Clear();
            AcomplementB.Items.Clear();
            //A halmaz generálása
            for (int i = 0; i < mennyit.Value; i++)
            {
                var random = rnd.Next(Convert.ToInt32(minimum.Value), Convert.ToInt32(maximum.Value));
                ahalmaz.Items.Add(random.ToString());
            }
            //B halmaz generálása
            for (int i = 0; i < mennyit.Value; i++)
            {
                var random = rnd.Next(Convert.ToInt32(minimum.Value), Convert.ToInt32(maximum.Value));
                bhalmaz.Items.Add(random.ToString());
            }
            halmazok_mutatása();
        }
        private void halmazok_mutatása()
        {
            //Console.WriteLine("Halmazok kiírása elkezdõdöt");

            for (int i = 0; i < ahalmaz.Items.Count; i++)
            {
                ahalmazszamok.Add(int.Parse(ahalmaz.Items[i].ToString()));

            }

            for (int i = 0; i < bhalmaz.Items.Count; i++)
            {
                bhalmazszamok.Add(int.Parse(bhalmaz.Items[i].ToString()));
            }
            //Metszet
            var metszet = ahalmazszamok.Intersect(bhalmazszamok).ToList();
            for (int i = 0; i < metszet.Count(); i++)
            {
                metszetform.Items.Add(metszet[i].ToString());
            }
            //Union
            var unio = ahalmazszamok.Union(bhalmazszamok).ToList();
            for (int i = 0; i < unio.Count(); i++)
            {
                unionform.Items.Add(unio[i].ToString());
            }
            // A complementer B 
            var acomplB = ahalmazszamok.Except(bhalmazszamok).ToList();
            for (int i = 0; i < acomplB.Count(); i++)
            {
                AcomplementB.Items.Add(acomplB[i].ToString());
            }


            // B complementer A
            var BcomplA = bhalmazszamok.Except(ahalmazszamok).ToList();
            for (int i = 0; i < BcomplA.Count(); i++)
            {
                BcomplementA.Items.Add(BcomplA[i].ToString());
            }
        }

        private void metszetform_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
