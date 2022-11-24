﻿using System;
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
        static List<Babu> babuk = new List<Babu>();
        static Players player1;
        static Players player2;
        public Jatek(string Player1, string Player2)
        {
            InitializeComponent();
            BabuFeltoltes();
            RandomKezdes(Player1, Player2);
        }
        private void RandomKezdes(string Player1, string Player2)
        {
            Random r = new Random();
            int rkezd = r.Next(1, 3);
            if  (rkezd == 1)     { player1 = new Players(0, Player1); 
                                           player2 = new Players(1, Player2); }
            else    { player1 = new Players(0, Player2); player2 = new Players(1, Player1); }
            nevLBL1.Text = player1.Nev;
            nevLBL2.Text = player2.Nev;

            jatekosKomm.Text = $"{player1.Nev} következik";
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
