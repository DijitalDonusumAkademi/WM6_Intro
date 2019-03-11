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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection
                ("Data Source=WISSEN\\MSSQL2017; Initial Catalog=NorthwindSabah; uid=zulal; pwd=12345");
        int CategoryId;
        //List<Category> liste = new List<Category>();
        Category secilen;
        private void Form4_Load(object sender, EventArgs e)
        {
            GetAllCategories();
        }

        private void GetAllCategories()
        {
            cbCategories.Items.Clear();
            SqlCommand comm = new SqlCommand
               ("select CategoryId, CategoryName, Description from Categories", conn);
            if (conn.State == ConnectionState.Closed) conn.Open();
            SqlDataReader dr;
            try
            {
                dr = comm.ExecuteReader();
                while (dr.Read())
                {
                    Category c = new Category();
                    c.CategoryId = Convert.ToInt32(dr[0]);
                    c.CategoryName = dr[1].ToString();
                    //c.Description = dr[2].ToString();
                    cbCategories.Items.Add(c);

                }
                dr.Close();
            }
            catch (Exception ex)
            {
                string hata = ex.Message;
            }
            finally { conn.Close(); }
        }

        private void cbCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            secilen = cbCategories.SelectedItem as Category;
            CategoryId = secilen.CategoryId;
            txtCategory.Text = CategoryId.ToString();
            lvProducts.Items.Clear();
            SqlCommand comm = new SqlCommand
                ("select ProductID, ProductName, UnitPrice, UnitsInStock, p.CategoryID,CategoryName from Products p inner join Categories c on p.CategoryID = c.CategoryID where CategoryName=@CategoryName", conn);
            comm.Parameters.Add("@CategoryName", SqlDbType.VarChar).Value = secilen.CategoryName;
            if (conn.State == ConnectionState.Closed) conn.Open();
            SqlDataReader dr;
            try
            {
                dr = comm.ExecuteReader();
                int i = 0;
                while (dr.Read())
                {
                    lvProducts.Items.Add(dr[0].ToString());
                    lvProducts.Items[i].SubItems.Add(dr[1].ToString());
                    lvProducts.Items[i].SubItems.Add(dr[2].ToString());
                    lvProducts.Items[i].SubItems.Add(dr[3].ToString());
                    lvProducts.Items[i].SubItems.Add(dr[4].ToString());
                    lvProducts.Items[i].SubItems.Add(dr[5].ToString());
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

        private void btnSave_Click(object sender, EventArgs e)
        {

            if (txtCategory.Text.Trim() != "" && txtProduct.Text.Trim() != ""  && txtUnitPrice.Text.Trim()!="" && txtUnitsInStock.Text.Trim()!= "")
            {
                Product yeni = new Product();
                yeni.CategoryId = CategoryId;
                yeni.ProductName = txtProduct.Text;
                yeni.UnitPrice = Convert.ToDecimal(txtUnitPrice.Text);
                yeni.UnitsInStock = Convert.ToInt32(txtUnitsInStock.Text);
                SqlCommand comm = new SqlCommand
                   //("Insert into Categories(CategoryName, Description) values (@CategoryName, @Description)", conn);   // Categories tablosuna insert ile data ekledik.
                   ("insert into Products(ProductName, UnitPrice, UnitsInStock, CategoryID, Discontinued, SupplierID) values(@ProductName,@UnitPrice, @UnitsInStock, @CategoryID, 1, 1)", conn);
                comm.Parameters.Add("@ProductName", SqlDbType.NVarChar).Value = yeni.ProductName;
                comm.Parameters.Add("@UnitPrice", SqlDbType.Money).Value = yeni.UnitPrice;
                comm.Parameters.Add("@UnitsInStock", SqlDbType.SmallInt).Value = yeni.UnitsInStock;
                comm.Parameters.Add("@CategoryID", SqlDbType.Int).Value = yeni.CategoryId;
                if (conn.State == ConnectionState.Closed) conn.Open();
                try
                {
                    bool Sonuc = Convert.ToBoolean(comm.ExecuteNonQuery());
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
    }
}

