using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRMEkranYonetimi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public List<object> Sayilar { get; set; }
        FrmNew _frmNew;
        FrmOpen _frmOpen;
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_frmNew == null || _frmNew.IsDisposed)
            {
                _frmNew = new FrmNew();
                _frmNew.MdiParent = this;
                _frmNew.Show();
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_frmOpen == null || _frmOpen.IsDisposed)
            {
                _frmOpen = new FrmOpen();
                _frmOpen.MdiParent = this;
                _frmOpen.Show();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Sayilar = new List<object> { 1, 2, 3, 4, 5, 6, 7 };
           
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox1.Items.AddRange(Sayilar.ToArray());
        }
    }
}
