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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void startBtn_Click(object sender, EventArgs e)
        {
            new Jatek(player1Name.Text, player2Name.Text).Show();
            this.Hide();
        }

        private void player1Name_TextChanged(object sender, EventArgs e) { Mehet(); }


        private void player2Name_TextChanged(object sender, EventArgs e) { Mehet(); }

        private void Mehet()
        {
            if (player1Name.Text == "" || player2Name.Text == "" || player2Name.Text == player1Name.Text)
            {
                startBtn.Enabled = false;
            }
            else
            {
                startBtn.Enabled = true;
            }

        }
        private void button1_Click(object sender, EventArgs e)
        {
            string message = "Quarto társasjáték kezdésekor a tábla üres. A kezdési jogot megszerzett játékos nem lép, hanem megjelöli, hogy az ellenfélnek melyik figurával kell lépnie. Ezután a játékosok felváltva lépnek. A soron következő játékos az ellenfele által kijelölt figurával köteles lépni, azt a tábla valamelyik szabad mezőjére kell tennie. A győzelemhez a következő szükséges: a tábla egyenesen, keresztben vagy átlósan négy egy vonalban levő mezőjén négy olyan figurának kell állnia, amelyek a felsorolt négy jellemző valamelyikét nézve egy csoportba tartoznak (például négy szögletes figura).";
            MessageBox.Show(message, "Játékszabály", MessageBoxButtons.OK);
        }
    }
}
