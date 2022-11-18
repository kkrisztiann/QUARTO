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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string message = "A kezdési jogot megszerzett játékos nem lép, hanem megjelöli, hogy az ellenfélnek melyik figurával kell lépnie. Ezután a játékosok felváltva lépnek. A soron következő játékos az ellenfele által kijelölt figurával köteles lépni, azt a tábla valamelyik szabad mezőjére kell tennie. A győzelemhez a következő szükséges: a tábla egyenesen, keresztben vagy átlósan négy egy vonalban levő mezőjén négy olyan figurának kell állnia, amelyek a felsorolt négy jellemző valamelyikét nézve egy csoportba tartoznak.";
            MessageBox.Show(message, "Játékszabály", MessageBoxButtons.OK);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string player1 = textbox1.Text;
            string player2 = textBox2.Text;
            if (textbox1.Text.Length == 0) player1 = "player1";
            if (textBox2.Text.Length == 0) player2 = "player2";

            Jatek jatek = new Jatek(player1, player2);

            this.Visible = false;
            jatek.ShowDialog();
            Close();
        }
    }
}
