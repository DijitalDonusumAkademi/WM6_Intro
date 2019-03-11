using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kayit
{
    public partial class Form1 : Form
    {

        List<Kisi> kisilistesi;
        //List<Kisi> aramalar = new List<Kisi>();
        Kisi yeniKisi;

        public Form1()
        {
            InitializeComponent();
            kisilistesi = new List<Kisi>();
        }

        private void btnKayit_Click(object sender, EventArgs e)
        {
            yeniKisi = new Kisi();
            try
            {
                yeniKisi.Ad = txtAd.Text;
                yeniKisi.Soyad = txtSoyad.Text;
                yeniKisi.Email = txtEmail.Text;
                yeniKisi.Telefon = txtTelefon.Text;
                yeniKisi.TCKN = txtTCKN.Text;

                string kayit = $"{yeniKisi.Ad} {yeniKisi.Soyad}";

                kisilistesi.Add(yeniKisi);
                lstList.Items.Add(kayit);

                //MessageBox.Show($"Hosgeldin {yeniKisi.Ad} {yeniKisi.Soyad}");
                FormuTemizle();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {

            if (lstList.SelectedItem == null) return;


            for (int i = 0; i < kisilistesi.Count; i++)
            {
                if (lstList.SelectedIndex == i)
                {
                    try
                    {
                        kisilistesi[i].Ad = txtAd.Text;
                        kisilistesi[i].Soyad = txtSoyad.Text;
                        kisilistesi[i].Email = txtEmail.Text;
                        kisilistesi[i].Telefon = txtTelefon.Text;
                        kisilistesi[i].TCKN = txtTCKN.Text;

                        lstList.Items[i] = $"{ kisilistesi[i].Ad} {kisilistesi[i].Soyad}";
                        FormuTemizle();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }

            }

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < kisilistesi.Count; i++)
            {
                if (lstList.SelectedIndex == i)
                {
                    kisilistesi.RemoveAt(i);
                    lstList.Items.RemoveAt(i);
                    FormuTemizle();
                }
            }
        } 

        private void lstList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstList.SelectedItem == null) return;

            if (lstList.SelectedIndex != -1)
            {
                txtAd.Text = kisilistesi[lstList.SelectedIndex].Ad;
                txtSoyad.Text = kisilistesi[lstList.SelectedIndex].Soyad;
                txtTelefon.Text = kisilistesi[lstList.SelectedIndex].Telefon;
                txtEmail.Text = kisilistesi[lstList.SelectedIndex].Email;
                txtTCKN.Text = kisilistesi[lstList.SelectedIndex].TCKN;
            }

        }

        private void txtAra_TextChanged(object sender, EventArgs e)
        {
            lstList.Items.Clear();
            Ara();
        }

        private void FormuTemizle()
        {
            foreach (Control control in this.Controls)
            {
                if (control is TextBox)
                    control.Text = string.Empty;
                //else if (control is CheckBox)
                //    (control as CheckBox).Checked = false;
                //else if(control is ListBox lstBox)
                //    lstBox.Items.Clear();
            }
        }

        private void Ara()
        {
            for (int i = 0; i < kisilistesi.Count; i++)
            {
                if (kisilistesi[i].Ad.ToLower().Contains(txtAra.Text) || kisilistesi[i].Soyad.ToLower().Contains(txtAra.Text))
                {
                    lstList.Items.Add($"{ kisilistesi[i].Ad} {kisilistesi[i].Soyad}");
                    
                }                
                
            }
        }


    }
}
