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
        public Jatek(string Player1, string Player2)
        {
            InitializeComponent();
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
