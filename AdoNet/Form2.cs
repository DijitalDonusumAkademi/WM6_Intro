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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection
                ("Data Source=WISSEN\\MSSQL2017; Initial Catalog=NorthwindSabah; uid=zulal; pwd=12345");

        private void button1_Click(object sender, EventArgs e)
        {
            lvCategories.Items.Clear();
            SqlCommand comm = new SqlCommand
                ("select CategoryID, CategoryName,Description from Categories",conn); // Sql den gelecek sorgumuz. Bir liste gelecegi iççin sqldatareader tipinde bir degişken tanımlayıp gelen listeyi ona eşitlicez.
            if (conn.State == ConnectionState.Closed) conn.Open();
            SqlDataReader dr;
            try
            {
                dr = comm.ExecuteReader();
                int i = 0;
                while (dr.Read()) // Bir liste geldiği için o liste elemanlarının her biri için işlem yapabilmek istiyorsak dongu kullanmalıyız. reader satır satır okuyacak. Her bir satırdaki kolonlarıda obje obje alıp istediğimiz ture cevirip listview a aktarabiliriz.
                {
                    //lvCategories.Items.Add(dr["CategoryId"].ToString());
                    // ilk sırada oldugu için id yi listview in ıtemlarına eklicez. Categoryname ve description u da subitemlarına eklicez.
                    lvCategories.Items.Add(dr[0].ToString()); //Bir satır ekliyoruz. Ve satıra ne gelmesini istiyorsak parantez içine onu yazıyoruz.
                    // Itemların subitemlrını açabiliyoruz.
                    lvCategories.Items[i].SubItems.Add(dr[1].ToString()); // O satırın yanına devam edebilmek için de subitem kullanıyoruz.Items[i] bu ifade hangi satıra subitem eklenecek onun temsil ediyor. o subitem a ne gelmesini istiyorsakta yine parantez içine onu yazıyoruz.
                    lvCategories.Items[i].SubItems.Add(dr[2].ToString()); //Aynı satırda bir yana daha gectik.
                    i++; // Bir snraki satıra gecebilmesi için özellikle subitemlarda i yi 1 arttırıyoruz.
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                string hata = ex.Message;
            }
            finally { conn.Close(); }
            
        }
    }
}
