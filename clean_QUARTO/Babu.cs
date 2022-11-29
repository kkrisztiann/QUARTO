using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace clean_QUARTO
{
    public class Babu
    {
        public bool Nagy, Fekete, Teli, Negyzet;

        public Babu(bool nagy, bool fekete, bool teli, bool negyzet)
        {
            Nagy = nagy;
            Fekete = fekete;
            Teli = teli;
            Negyzet = negyzet;
        }
    }
}
