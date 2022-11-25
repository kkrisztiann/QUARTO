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
        static PictureBox Aktiv=new PictureBox();
        static int palyameret = 4;
        static int kepmeret = 80;
        static int gap = 20; //px
        static List<Babu> babuk = new List<Babu>();
        static List<PictureBox> lentibabuk = new List<PictureBox>();
        static Players player1;
        static Players player2;
        public Jatek(string Player1, string Player2)
        {
            InitializeComponent();
            BabuFeltoltes();
            PalyaGeneralas();
            RandomKezdes(Player1, Player2);
            Lenti();
        }

        private void Lenti()
        {
            int segedvaltozo=0;
            Point nullpoz = new Point(30, 600);
            for (int sor = 0; sor < palyameret + 4; sor++)
            {
                for (int oszlop = 0; oszlop < palyameret - 2; oszlop++)
                {
                    PictureBox mezo = new PictureBox();
                    mezo.Size = new Size(kepmeret - 20, kepmeret - 20);
                    mezo.Location = new Point(nullpoz.X + sor * (gap + kepmeret - 20), nullpoz.Y + oszlop * (gap + kepmeret - 20));
                    //mezo.BackColor = Color.Gray;
                    mezo.Image = babuk[segedvaltozo].Kep;
                    segedvaltozo++;
                    mezo.SizeMode = PictureBoxSizeMode.Zoom;
                    this.Controls.Add(mezo);
                    lentibabuk.Add(mezo);
                    mezo.Click += delegate (object sender, EventArgs e)
                    {
                        LentiClick(mezo);
                    };
                }
            }
        }

        private void LentiClick(PictureBox mezo)
        {
            foreach (PictureBox item in lentibabuk)
            {
                item.BackColor = Color.Transparent;
            }
            Aktiv = mezo;
            Aktiv.BackColor = Color.HotPink;
        }

        private void PalyaGeneralas()
        {

            Point nullpoz = new Point(155, 100);
            for (int sor = 0; sor < palyameret; sor++)
            {
                for (int oszlop = 0; oszlop < palyameret; oszlop++)
                {
                    PictureBox mezo = new PictureBox();
                    mezo.Size = new Size(kepmeret, kepmeret);
                    mezo.Location = new Point(nullpoz.X + sor * (gap + kepmeret), nullpoz.Y + oszlop * (gap + kepmeret));
                    mezo.BackColor = Color.Gray;
                    mezo.SizeMode = PictureBoxSizeMode.Zoom;
                    this.Controls.Add(mezo);
                    mezo.Click += delegate (object sender, EventArgs e)
                    {

                    };
                }
            }
            //gomb
            Button veglegesit = new Button();
            veglegesit.Location = new Point(300, 530);
            veglegesit.BackColor = Color.Cornsilk;
            veglegesit.Size = new Size(100, 30);
            veglegesit.Font = new Font("Arial", 12, FontStyle.Bold);
            veglegesit.Text = "Véglegesít";
            this.Controls.Add(veglegesit);
            //label
            Label kommunikacio = new Label();
            kommunikacio.Left=(this.ClientSize.Width-kommunikacio.Size.Width)/2;
            //kommunikacio.Size = new Size(100, 30);
            kommunikacio.Font = new Font("Arial", 12, FontStyle.Bold);
            kommunikacio.Text = "Kommunikáció";
            this.Controls.Add(kommunikacio);
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
