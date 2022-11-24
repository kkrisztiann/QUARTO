using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace QUARTO_jatek
{
    class Babu
    {
        public bool Nagy, Fekete, Teli, Negyzet;
        //public Image Kep;

        public Babu(/*Image kep,*/bool nagy, bool fekete, bool teli, bool negyzet)
        {
            //Kep = kep;
            Nagy = nagy;
            Fekete = fekete;
            Teli = teli;
            Negyzet = negyzet;
        }
    }
}
