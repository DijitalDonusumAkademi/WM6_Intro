using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UcakSavarOyunu.Lib.Abstracts
{
    public abstract class OyunAraclari
    {
        public PictureBox AracResmi { get; protected set; } = new PictureBox();
        protected OyunAraclari()
        {
            AracResmi.Size = new Size(40, 40);
            AracResmi.SizeMode = PictureBoxSizeMode.StretchImage;
        }

    }
}
