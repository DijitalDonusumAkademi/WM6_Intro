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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection
                ("Data Source=WISSEN\\MSSQL2017; Initial Catalog=NorthwindSabah; uid=zulal; pwd=12345");
        private void Form3_Load(object sender, EventArgs e)
        {
            GetAllCategories();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtCategoryName.Text.Trim() != "")
            {
                SqlCommand comm = new SqlCommand
                    ("Insert into Categories(CategoryName, Description) values (@CategoryName, @Description)", conn);   // Categories tablosuna insert ile data ekledik. data ile ilgili işlemler yaptıgımız için nonquery ile kontrol yapıyoruz.
                comm.Parameters.Add("@CategoryName", SqlDbType.VarChar).Value = txtCategoryName.Text;   // Prametreler tanımladık ve bu parametre degerlerinin nereden alınacagını gosterdik.
                comm.Parameters.Add("@Description", SqlDbType.VarChar).Value = txtDescription.Text;
                if (conn.State == ConnectionState.Closed) conn.Open();
                try 
                {
                    //int Sonuc = comm.ExecuteNonQuery();
                    //if (Sonuc>0)
                    //{
                    //    MessageBox.Show("Kayıt eklendi");
                    //    GetAllCategories();
                    //}
                    //else
                    //{ MessageBox.Show("Kayıt gerceklesmedi"); }

                    bool Sonuc =Convert.ToBoolean( comm.ExecuteNonQuery());
                    if (Sonuc)
                    {
                        MessageBox.Show("Kayıt eklendi");
                        GetAllCategories();
                    }
                    else
                    { MessageBox.Show("Kayıt gerceklesmedi"); }
                }
                catch (Exception ex)
                {
                    string hata = ex.Message;
                }
                finally { conn.Close(); }


            }
            else
            {
                MessageBox.Show("CategoryName girmelisiniz.Eksik Bilgi!");
            }
        }
        private void GetAllCategories()
        {
            lvCategories.Items.Clear();
            SqlCommand comm = new SqlCommand
                ("select CategoryID, CategoryName,Description from Categories", conn);
            if (conn.State == ConnectionState.Closed) conn.Open();
            SqlDataReader dr;
            try
            {
                dr = comm.ExecuteReader();
                int i = 0;
                while (dr.Read())
                {
                    //lvCategories.Items.Add(dr["CategoryId"].ToString());
                    lvCategories.Items.Add(dr[0].ToString());
                    lvCategories.Items[i].SubItems.Add(dr[1].ToString());
                    lvCategories.Items[i].SubItems.Add(dr[2].ToString());
                    i++;
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
