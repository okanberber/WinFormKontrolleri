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
using WinFormKontrolleri.Model;

namespace WinFormKontrolleri
{
    public partial class DataGridKontrolu : Form
    {
        int rowindex = -1;
        public DataGridKontrolu()
        {
            InitializeComponent();
        }

        private void DataGridKontrolu_Load(object sender, EventArgs e)
        {
            //DataTableNedir();
            //DataGridDataBind();

            //DataGridDataBind2();

            //DataGridDataBind3();

            DataGridDataBind4();
        }
        private void DataGridDataBind4()
        {
            SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS; Initial Catalog=NORTHWND; Integrated Security=True");
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "SELECT * FROM Categories";
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("kategori No");
            dt.Columns.Add("Kategori Isim");
            dt.Columns.Add("Açıklama");
            while (reader.Read())
            {
                int id = reader.GetInt32(0);
                string name = reader.GetString(1);
                string description = reader.GetString(2);
                dt.Rows.Add(id, name, description);
            }
            //dt.Load(reader);
            dataGridView1.DataSource = dt;
        }
        private void DataGridDataBind3()
        {
            List<Category> categories = new List<Category>();
            SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS; Initial Catalog=NORTHWND; Integrated Security=True");
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "SELECT * FROM Categories";
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Category cat = new Category();
                cat.ID = reader.GetInt32(0);
                cat.Name = reader.GetString(1);
                cat.Description = reader.GetString(2);
                categories.Add(cat);
            }
            dataGridView1.DataSource = categories;
        }

        private void DataGridDataBind2()
        {
            SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS; Initial Catalog=NORTHWND; Integrated Security=True");
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "SELECT * FROM Products";

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter();
            SqlCommandBuilder sqlcommand = new SqlCommandBuilder();
            sqlcommand.DataAdapter = da;
            da.SelectCommand = cmd;
            da.Fill(dt);

            dataGridView1.DataSource = dt;

        }

        private void DataGridDataBind()
        {
            //Northwind veri tabanından ürünleri çekelim
            SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS; Initial Catalog=NORTHWND; Integrated Security=True");
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "SELECT * FROM Products";
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            dataGridView1.DataSource = dt;
        }
        private void DataTableNedir()
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Kolon 1");
            dataTable.Columns.Add("Kolon 2");
            dataTable.Columns.Add("Kolon 3");

            dataTable.Rows.Add(1, "Kategori 1", "Aciklama 1");
            dataTable.Rows.Add(2, "Kategori 2", "Aciklama 2");
            ParamsNedir("3", "Murtaza", "Suayipoglu");
            dataGridView1.DataSource = dataTable;
        }
        
        public void ParamsNedir(params string[] isimler)
        {
            //params anahtar sozcugu metodun alacagi parametre sayisi belli olmadiginda kullanilabilir.Kendisine gonderilen ayni turdeki parametreleri dizi indexlerine otomatik olarak yerlestirir ve dizi olarak kullanima sunar
            //dataTable.Rows.Add(isimler[0],isimler[1],isimler[2]);
            MessageBox.Show(isimler[0]);
        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Right){
                dataGridView1.ClearSelection();
                rowindex = dataGridView1.HitTest(e.X, e.Y).RowIndex;
                if (rowindex != -1)
                {
                    // MessageBox.Show("Sag Buton Tiklandi");
                    contextMenuStrip1.Show(dataGridView1, e.X, e.Y);
                   
                    dataGridView1.Rows[rowindex].Selected = true;
                }
            }
           
           
        }

        private void TSMI_duzenle_Click(object sender, EventArgs e)
        {
            if(rowindex != -1)
            {
                btn_duzenle.Visible = true;
                int id = Convert.ToInt32(dataGridView1.Rows[rowindex].Cells[0].Value);
                //MessageBox.Show(id.ToString(),"Secilen Kategori ID");

                Category c = new Category();
                SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS; Initial Catalog=NORTHWND; Integrated Security=True");
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandText = "SELECT CategoryID,CategoryName,Description FROM Categories WHERE CategoryID=@id";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id", id);

                try
                {
                    con.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        tb_id.Text = reader.GetInt32(0).ToString();
                        tb_isim.Text = reader.GetString(1);
                        //if (!reader.IsDBNull(2))
                        //{
                        //    c.Description = reader.GetString(2);
                        //}
                        //else
                        //{
                        //    c.Description = "";
                        //}
                        tb_Aciklama.Text = reader.IsDBNull(2) == false ? reader.GetString(2) : "";
                    }
                }
                catch
                {
                    MessageBox.Show("Kategori getirilirken bir hata olustu", "Hata");
                }
                finally
                {
                    con.Close(); 
                }
            }
        }

        private void BTN_Ekle_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tb_isim.Text))
            {
                SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS; Initial Catalog=NORTHWND; Integrated Security=True");
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandText = "INSERT INTO Categories(CategoryName,Description) VALUES(@name,@des)";

                cmd.Parameters.AddWithValue("@name", tb_isim.Text);
                cmd.Parameters.AddWithValue("@des", tb_Aciklama.Text);

                try
                {
                    con.Open();
                    cmd.ExecuteNonQuery();
                    tb_Aciklama.Text = tb_isim.Text = "";
                    MessageBox.Show("Kategori Basariyla Eklenmistir", "Basarili");
                }
                catch
                {
                    MessageBox.Show("Kategori Eklenirken bir hata olustu", "Hata var");
                }
                finally
                {
                    con.Close();
                }
                DataGridDataBind4();
            }
            
        }

        private void btn_duzenle_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tb_isim.Text))
            {
                SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS; Initial Catalog=NORTHWND; Integrated Security=True");
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandText = "UPDATE Categories SET CategoryName=@cn,Description=@des WHERE CategoryID=@id";
                cmd.Parameters.AddWithValue("@cn", tb_isim.Text);
                cmd.Parameters.AddWithValue("@des", tb_Aciklama.Text);
                cmd.Parameters.AddWithValue("@id",tb_id.Text);
                try
                {
                    con.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Kategori Basariyla Guncellenmistir", "Basarili");
                }
                catch
                {
                    MessageBox.Show("Kategori Guncellenirken bir hata olustu", "Hata var");
                }
                finally
                {
                    con.Close();
                }
                btn_duzenle.Visible = false;
                tb_id.Text = tb_isim.Text = tb_Aciklama.Text = "";
                DataGridDataBind4();
            }
           
        }

        private void TSMI_sil_Click(object sender, EventArgs e)
        {
            if (rowindex != -1)
            {
                int id = Convert.ToInt32(dataGridView1.Rows[rowindex].Cells[0].Value);

                if(MessageBox.Show($"{id} id'li kategori silinecektir.\nOnayliyor musunuz?","Kategori Sil",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS; Initial Catalog=NORTHWND; Integrated Security=True");
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandText = "DELETE FROM Categories WHERE CategoryID=@id";
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@id", id);
                    try
                    {
                        con.Open();
                        cmd.ExecuteNonQuery();
                    }
                    finally
                    {
                        con.Close();
                    }
                    DataGridDataBind4();
                }
            }
        }
    }
}
