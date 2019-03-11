using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdoNet
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // Kullanmak istediğimiz sql server ın bağlantı ozelliklerini tanımlıyoruz.
        SqlConnection conn = new SqlConnection
                ("Data Source=MELIKE\\MYSQL; Initial Catalog=NorthwindSabah; uid=wissen; pwd=12345");
        private void btnGetCategory_Click(object sender, EventArgs e)
        {
            
            if (txtCategoryId.Text.Trim() != "")
            {
                // Sql de calısacak sorgumuzu tanımlıyoruz.
                SqlCommand comm = new SqlCommand
                //($"select CategoryName from Categories where CategoryID = {txtCategoryId.Text}", conn); // txtCategoriId ye yazdıgımız ıd ye gore getiriyor.
                //("select CategoryName from Categories where CategoryID = 4", conn);   // 4. ıd deki categoriyi getir.

                ("select CategoryName from Categories where CategoryID =@Id", conn);    // Belirtilen baglantıya göre calıstırılacak sorgumuz. Dışarıdan veri istediğimizde @ ile degişken tanımlıyoruz.Bu yontem daha guvenli
                comm.Parameters.Add("@Id", SqlDbType.Int).Value = Convert.ToInt32(txtCategoryId.Text); //Bu satırın anlamı: Bu command in parametrelerine şu tanımladıgım id yi ekle ki onun sql deki türü integerdır ve degerini textboxtan alıcaktır.Onu da integera cevirmeliyim. // Herbir parametre için ayrı ayrı ekleme yapmalıyız.

                if (conn.State == ConnectionState.Closed) conn.Open();  // Bağlantı kapalıysa acılır.
                try
                {
                    txtCategoryName.Text = comm.ExecuteScalar().ToString(); // Sorgudan tek bir deger donecegi için scalar kullandık ve text e yazacagımız için object turunde geleni string e cevirik.
                }
                catch (SqlException ex)
                {
                    string hata = ex.Message;
                }
                catch (Exception ex)
                {
                    string hata = ex.Message;
                }
                finally
                {
                    conn.Close();   // Her durumda baglantı kapanacak.
                }
            }
        }
    }
}
