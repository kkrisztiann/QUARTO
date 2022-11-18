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
        static List<Babu> babuk = new List<Babu>();
        public Jatek(string Player1, string Player2)
        {
            InitializeComponent();
            BabuFeltoltes();
        }

        private void BabuFeltoltes()
        {
            List<Image> kepek = new List<Image>();
            for (int i = 0; i < 16; i++)
            {
                babuk.Add(new Babu(kepek[i], Convert.ToBoolean((i / 8) % 2), Convert.ToBoolean((i / 4) % 2), Convert.ToBoolean((i / 2) % 2), Convert.ToBoolean(i % 2)));
            }

            //kepek = new List<Babu>()
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
    }
}
