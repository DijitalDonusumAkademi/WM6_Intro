using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UcakSavarOyunu.Lib
{
    public abstract class OyunBase
    {
        protected readonly ContainerControl container;

        protected OyunBase(ContainerControl container)
        {
            this.container = container;
            this.Container = container;
        }
        public PictureBox Resim { get; set; } = new PictureBox();
        public ContainerControl Container { get;  set; }
    }
}
