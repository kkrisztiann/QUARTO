using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace clean_QUARTO
{
    public partial class Jatek : Form
    {
        static int palyameret = 4;
        static int kepmeret = 80; //px
        static int gap = 0; //px
        static List<Mezo> lista = new List<Mezo>();
        static Mezo[,] Matrix = new Mezo[palyameret, palyameret];
        static Point nullpoz = new Point(310, 100);
        static Mezo Aktiv = null;
        static Button Btn;
        static Mezo Kijelolt = null;
        static int Nagyobb = 60;
        static Point Cel = new Point(nullpoz.X + kepmeret/2 - Nagyobb / 2, nullpoz.Y + (Matrix.GetLength(0)*2-1) * (kepmeret + gap) + 20);
        static int odaszamlalo = 0;
        static int leszamlalo = 0;
        static int irany = -2;
        static int max = 25;
        static int jelenitszamlalo = 0;
        static Mezo Megjelenitendo;
        static Point eredeti;


        public Jatek(string player1, string player2)
        {

            InitializeComponent();
            BabuFeltoltes();
            PalyaGeneralas();
            VeglegesitGomb();

        }

        private void VeglegesitGomb()
        {
            Button btn = new Button();
            btn.Size = new Size(120, 30);
            btn.Text = "Véglegesít";
            btn.Location = new Point(nullpoz.X + kepmeret/2 - (btn.Size.Width + gap) / 2, nullpoz.Y + (Matrix.GetLength(1)*2-1) * (gap + kepmeret) + 20);
            this.Controls.Add(btn);
            Btn = btn;
            btn.Click += delegate (object sender, EventArgs e)
            {
                if (Aktiv != null)
                {
                    Btn.Visible = false;
                    Kijelolt = Aktiv;
                    Aktiv = null;
                    Kijelolt.BackColor = Color.Transparent;
                    Kijelolt.BringToFront();
                    irany = -irany;
                    ListaTimer.Start();
                    Odavisz.Start();
                }
            };
            hatter.Size = new Size((palyameret * 2 - 1) * kepmeret + 30, (palyameret * 2 - 1) * kepmeret + 30);
            hatter.Location = new Point(nullpoz.X + kepmeret / 2 - hatter.Width / 2, nullpoz.Y - 15);
        }

        private void Odavisz_Tick(object sender, EventArgs e)
        {
            double xMozgas = Kijelolt.Location.X + Convert.ToDouble(Cel.X - Kijelolt.Location.X) * (Convert.ToDouble(odaszamlalo) / max);
            double yMozgas = Kijelolt.Location.Y + Convert.ToDouble(Cel.Y - Kijelolt.Location.Y) * (Convert.ToDouble(odaszamlalo) / max);
            Kijelolt.Location = new Point(Convert.ToInt32(xMozgas), Convert.ToInt32(yMozgas));
            odaszamlalo++;
            if (odaszamlalo >= max)
            {
                Kijelolt.Location = Cel;
                odaszamlalo = 0;
                Odavisz.Stop();
            }
        }
        private void ListaTimer_Tick(object sender, EventArgs e)
        {
            foreach (Mezo item in lista)
            {
                if (Kijelolt != item)
                {
                    item.Location = new Point(item.Location.X, item.Location.Y + irany);
                }
            }
            leszamlalo++;
            if (leszamlalo >= max)
            {
                if (irany < 0)
                {
                    Btn.Visible = true;
                }
                leszamlalo = 0;
                ListaTimer.Stop();
            }
        }

        private void PalyaGeneralas()
        {
            for (int sor = 0; sor < palyameret; sor++)
            {
                for (int oszlop = 0; oszlop < palyameret; oszlop++)
                {
                    Mezo mezo = new Mezo(new Point(sor, oszlop));
                    mezo.Size = new Size(kepmeret, kepmeret);
                    mezo.Location = new Point(nullpoz.X - sor * ((gap+kepmeret)) + oszlop*(gap + kepmeret), nullpoz.Y + sor*(gap + kepmeret) + oszlop * (gap + kepmeret));
                    mezo.BackColor = Color.FromArgb(100, 215, 215, 215);
                    mezo.SizeMode = PictureBoxSizeMode.Zoom;
                    Matrix[sor, oszlop] = mezo;
                    this.Controls.Add(mezo);
                    mezo.BringToFront();
                    mezo.Click += delegate (object sender, EventArgs e)
                    {
                        if (mezo.Szabad && Kijelolt != null && leszamlalo == 0 && odaszamlalo == 0 && jelenitszamlalo == 0)
                        {
                            Aktiv = null;
                            mezo.Image = Kijelolt.Image;
                            mezo.Tipus = Kijelolt.Tipus;
                            mezo.Szabad = false;
                            Megjelenitendo = mezo;
                            lista.Remove(Kijelolt);
                            eredeti = Megjelenitendo.Location;
                            Megjelenit.Start();
                            irany = -irany;
                            ListaTimer.Start();
                            if (WinCheck(mezo))
                            {
                                MessageBox.Show("Nyertél ügyi bügyi");
                            }
                            else if (lista.Count == 0)
                            {
                                MessageBox.Show("Döntetlen bügyi");
                            }
                        }
                    };
                    Kerekit(mezo, mezo.Size.Width);
                    
                }
            }
        }

        private void Megjelenit_Tick(object sender, EventArgs e)
        {
            double size = Kijelolt.Size.Width - (Convert.ToDouble(jelenitszamlalo) / Convert.ToDouble(max)) * (Kijelolt.Size.Width);
            Kijelolt.Size = new Size(Convert.ToInt32(size), Convert.ToInt32(size));
            double xHelyzet = Kijelolt.Location.X + (Convert.ToDouble(jelenitszamlalo) / Convert.ToDouble(max)) * (Kijelolt.Size.Width / 2);
            double yHelyzet = Kijelolt.Location.Y + (Convert.ToDouble(jelenitszamlalo) / Convert.ToDouble(max)) * (Kijelolt.Size.Height / 2);
            Kijelolt.Location = new Point(Convert.ToInt32(xHelyzet), Convert.ToInt32(yHelyzet));
            
            size = (Convert.ToDouble(jelenitszamlalo) / Convert.ToDouble(max)) * (kepmeret);
            Megjelenitendo.Size = new Size(Convert.ToInt32(size), Convert.ToInt32(size));
            xHelyzet = eredeti.X+kepmeret/2 - (Convert.ToDouble(jelenitszamlalo) / Convert.ToDouble(max)) * (Megjelenitendo.Size.Width / 2);
            yHelyzet = eredeti.Y+kepmeret/2 - (Convert.ToDouble(jelenitszamlalo) / Convert.ToDouble(max)) * (Megjelenitendo.Size.Height / 2);
            Megjelenitendo.Location = new Point(Convert.ToInt32(xHelyzet), Convert.ToInt32(yHelyzet));
            

            jelenitszamlalo++;
            if (jelenitszamlalo >= max)
            {
                Megjelenitendo.Size = new Size(kepmeret, kepmeret);
                Megjelenitendo.Location = eredeti;
                Kijelolt.Size = new Size(0, 0);
                Megjelenitendo = null;
                Kijelolt.Visible = false;
                Kijelolt = null;
                jelenitszamlalo = 0;
                Megjelenit.Stop();
            }
        }
        /*
                                      <=======]}======
                                        --.   /|
                                       _\"/_.'/
                                     .'._._,.'
                                     :/ \{}/
                                    (L / --',----._
                                        |          \\
                                       : / -\ .'-'\ / |
                                        \\, ||    \|
                                         \/ ||    ||
        */
        private bool WinCheck(Mezo mezo)
        {
            int winszamlalo = 0;
            //vízszintes
            for (int j = 0; j < palyameret; j++)
            {
                if (VizszintWinCheck(winszamlalo,mezo, j)) return true;
                
            }
            //függőleges
            for (int j = 0; j < palyameret; j++)
            {
                if (FuggolegesWinCheck(winszamlalo, mezo, j)) return true;
            }
            //atlo1
            if (mezo.Helyzet.X==mezo.Helyzet.Y)
            {
                for (int j = 0; j < palyameret; j++)
                {
                    if (Atlo1WinCheck(winszamlalo, mezo, j)) return true;
                }
            }
            //atlo2
            if (mezo.Helyzet.X+mezo.Helyzet.Y==palyameret-1)
            {
                for (int j = 0; j < palyameret; j++)
                {
                    if (Atlo2WinCheck(winszamlalo, mezo, j)) return true;
                }
            }
            return false;
        }

        private bool Atlo2WinCheck(int winszamlalo, Mezo mezo, int j)
        {
            int seged = 0;
            winszamlalo = 0;
            for (int i = palyameret-1; i > -1; i--)
            {
                if (!Matrix[seged,i].Szabad)
                {
                    if (Matrix[seged,i].Tipus[j] == mezo.Tipus[j])
                    {
                        winszamlalo++;
                        if (winszamlalo == palyameret) return true;
                    }
                }
                else break;
                seged++;
            }
            return false;
        }

        private bool Atlo1WinCheck(int winszamlalo, Mezo mezo, int j)
        {
            winszamlalo = 0;
            for (int i = 0; i < palyameret; i++)
            {
                if (!Matrix[i, i].Szabad)
                {
                    if (Matrix[i,i].Tipus[j] == mezo.Tipus[j])
                    {
                        winszamlalo++;
                        if (winszamlalo == palyameret) return true;
                    }
                }
                else break;
            }
            return false;
        }

        private bool FuggolegesWinCheck(int winszamlalo, Mezo mezo, int j)
        {
            winszamlalo = 0;
            for (int i = 0; i < palyameret; i++)
            {
                if (!Matrix[mezo.Helyzet.X, i].Szabad)
                {
                    if (Matrix[mezo.Helyzet.X, i].Tipus[j] == mezo.Tipus[j])
                    {
                        winszamlalo++;
                        if (winszamlalo == palyameret) return true;
                    }
                }
                else break;
            }
            return false;
        }

        private bool VizszintWinCheck(int winszamlalo, Mezo mezo, int j)
        {
            winszamlalo = 0;
            for (int i = 0; i < palyameret; i++)
            {
                if (!Matrix[i, mezo.Helyzet.Y].Szabad)
                {
                    if (Matrix[i, mezo.Helyzet.Y].Tipus[j] == mezo.Tipus[j])
                    {
                        winszamlalo++;
                        if (winszamlalo == palyameret) return true;
                    }
                }
                else return false;
            }
            return false;
        }

        private void BabuFeltoltes()
        {
            int lentgap = 20;
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

            Point nullpozi = new Point(nullpoz.X + kepmeret / 2 - (kepek.Count * (lentgap + Nagyobb) / 4), nullpoz.Y + (Matrix.GetLength(1)*2-1) * (gap + kepmeret) + 50);
            for (int i = 0; i < kepek.Count; i++)
            {
                Mezo mezo = new Mezo($"{((i / 8) % 2)}{(i / 4) % 2}{(i / 2) % 2}{i % 2}", new Point(-1, -1));
                mezo.Image = kepek[i];
                lista.Add(mezo);
                mezo.Size = new Size(Nagyobb, Nagyobb);
                mezo.SizeMode = PictureBoxSizeMode.StretchImage;
                mezo.Location = new Point(nullpozi.X + (i / 2) * (mezo.Size.Width + lentgap), nullpozi.Y + (i % 2 == 1 ? 0 : 1) * (mezo.Size.Width));
                this.Controls.Add(mezo);
                mezo.Click += delegate (object sender, EventArgs e) 
                {
                    Kijelol(mezo);   
                };
                if (mezo.Tipus[3] == '1') Kerekit(mezo, mezo.Size.Width - 30);
                else Kerekit(mezo, mezo.Size.Width);
                mezo.Name = i.ToString();
            }
        }

        private void Kerekit(Mezo pictureBox, int size)
        {
            Rectangle r = new Rectangle(0, 0, pictureBox.Width, pictureBox.Height);
            System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();
            int d = size;
            gp.AddArc(r.X, r.Y, d, d, 180, 90);
            gp.AddArc(r.X + r.Width - d, r.Y, d, d, 270, 90);
            gp.AddArc(r.X + r.Width - d, r.Y + r.Height - d, d, d, 0, 90);
            gp.AddArc(r.X, r.Y + r.Height - d, d, d, 90, 90);
            pictureBox.Region = new Region(gp);
        }

        private void Kijelol(Mezo mezo)
        {
            if (Kijelolt == null)
            {
                if (Aktiv != null)
                {
                    Aktiv.BackColor = Color.Transparent;
                }
                Aktiv = mezo;
                Aktiv.BackColor = Color.Gray;
            }
        }

        private void Jatek_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
