using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QUARTO_jatek
{
    public partial class Jatek : Form
    {
        static int palyameret = 4;
        static int kepmeret = 50;
        static int gap = 20; //px
        static List<Babu> babuk = new List<Babu>();
        static Players player1;
        static Players player2;
        public Jatek(string Player1, string Player2)
        {
            InitializeComponent();
            BabuFeltoltes();
            PalyaGeneralas();
            RandomKezdes(Player1, Player2);
        }


        private void PalyaGeneralas()
        {
            Point nullpoz = new Point(100, 100);
            for (int sor = 0; sor < palyameret; sor++)
            {
                for (int oszlop = 0; oszlop < palyameret; oszlop++)
                {
                    PictureBox mezo = new PictureBox();
                    mezo.Size = new Size(kepmeret, kepmeret);
                    mezo.Location = new Point(nullpoz.X + sor * (gap + kepmeret), nullpoz.Y + oszlop * (gap + kepmeret));
                    mezo.BackColor = Color.Gray;
                    mezo.SizeMode = PictureBoxSizeMode.Zoom;
                    //mezo.Tag = new Point(sor, oszlop);
                    this.Controls.Add(mezo);
                }
            }
        }

        private void RandomKezdes(string Player1, string Player2)
        {
            Random r = new Random();
            int rkezd = r.Next(1, 3);
            if (rkezd == 1)
            {
                player1 = new Players(0, Player1);
                player2 = new Players(1, Player2);
            }
            else { player1 = new Players(0, Player2); player2 = new Players(1, Player1); }
            //nevLBL1.Text = player1.Nev;
            //nevLBL2.Text = player2.Nev;
            //
            //jatekosKomm.Text = $"{player1.Nev} következik...";
        }
        private void BabuFeltoltes()
        {
            List<Image> kepek = new List<Image>() {
                Properties.Resources.Kicsi_Piros_Lyukas_Kör,
                Properties.Resources.Kicsi_Piros_Lyukas_Négyzet,
                Properties.Resources.Kicsi_Piros_Teli_Kör,
                Properties.Resources.Kicsi_Piros_Teli_Négyzet,
                Properties.Resources.Kicsi_Fekete_Lyukas_Kör,
                Properties.Resources.Kicsi_Fekete_Lyukas_Négyzet,
                Properties.Resources.Kicsi_Fekete_Teli_Kör,
                Properties.Resources.Kicsi_Fekete_Teli_Négyzet,
                Properties.Resources.Nagy_Piros_Lyukas_Kör,
                Properties.Resources.Nagy_Piros_Lyukas_Négyzet,
                Properties.Resources.Nagy_Piros_teli_Kör,
                Properties.Resources.Nagy_Piros_Teli_Négyzet,
                Properties.Resources.Nagy_Fekete_Lyukas_Kör,
                Properties.Resources.Nagy_Fekete_Lyukas_Négyzet,
                Properties.Resources.Nagy_Fekete_Teli_Kör,
                Properties.Resources.Nagy_Fekete_Teli_Négyzet
            };
            for (int i = 0; i < 16; i++)
            {
                babuk.Add(new Babu(kepek[i], Convert.ToBoolean((i / 8) % 2), Convert.ToBoolean((i / 4) % 2), Convert.ToBoolean((i / 2) % 2), Convert.ToBoolean(i % 2)));
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            switch (MessageBox.Show(this, "Biztosan be akarod zárni a játékot? A játék elvész!", "Játék feladása", MessageBoxButtons.YesNo))
            {
                case DialogResult.No:
                    e.Cancel = true;
                    break;
                default:
                    break;
            }
        }
        private void TovabbJatszik(DialogResult valasz)
        {
            if (valasz == DialogResult.Yes)
            {
                Jatek jatek = new Jatek(player1.Nev, player2.Nev);
                this.Visible = false;
                jatek.ShowDialog();
                Close();
            }
            else
            {
                Close();
            }
        }
    }
}
