using Hastane.Lib.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hastane.Lib.Helpers
{
    public class FormHelper
    {
        // Form elemanlarında ortak yaptığımız veya surekli tekrar edecek işlemler icin böyle bir sınıf oluşturduk.
        public static void FormuTemizle(Form form)
        {
            foreach (Control control in form.Controls)
            {
                if (control is TextBox) // Tüm form esnelerinde ortak olan prop lar icin bu sekilde yazım yeterli
                    control.Text = string.Empty;
                else if (control is ComboBox cmb)   // Fakat nesnenin sadece kendine ait özelliğini kullanacaksak bu sekilde yazmalıyız.
                    cmb.SelectedIndex = -1;
                else if (control is DateTimePicker dtp)
                    dtp.Value = DateTime.Now;
                else if (control is CheckedListBox chcklst)
                    chcklst.SelectedIndex = -1;
                else if (control is ListBox lst)
                    lst.SelectedIndex = -1;
                else if (control is PictureBox pcb)
                    pcb.Image = null;

            }
        }

        public static void ListBoxYenile<T>(ListBox lstBox,List<T> data) where T:Kisi   // Bir listbox parametresi bir de list alıyor. Gelen listbox ın datasource unu gelen listteki elemanlar ile dolduruyoruz.
        {
            lstBox.DataSource = data;
        }
    }
}
