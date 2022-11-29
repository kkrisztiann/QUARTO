using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace clean_QUARTO
{
    public partial class Mezo : PictureBox
    {
        public Point Helyzet;
        public bool Szabad;
        public Babu Tipus;

        public Mezo(Babu babu, Point hely){
            Helyzet = hely;
            Szabad = true;
            Tipus = babu;

        }

        public Mezo(Point hely)
        {
            Helyzet = hely;
            Szabad = true;
            Tipus = null;
        }

    }
}
