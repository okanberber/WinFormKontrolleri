using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormKontrolleri.Model;

namespace WinFormKontrolleri
{
    public partial class GirisForm : Form
    {
        bool islogin = false;
        public GirisForm()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            // using otomatik olarak try finally komutlari uretir
            if (!string.IsNullOrEmpty(tb_kullaniciAdi.Text) && !string.IsNullOrEmpty(tb_sifre.Text))
            {
                using (SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS; Initial Catalog=NORTHWND; Integrated Security=True"))
                {
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandText = "SELECT EmployeeID,FirstName,LastName, Firstname+' '+LastName FROM Employees WHERE UserName=@un AND Password=@pss";
                    cmd.Parameters.AddWithValue("@un", tb_kullaniciAdi.Text);
                    cmd.Parameters.AddWithValue("@pss", tb_sifre.Text);
                    con.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    User kullanici = null;
                    while (reader.Read())
                    {
                       kullanici = new User();
                        kullanici.ID = reader.GetInt32(0);
                        kullanici.Name = reader.GetString(1);
                        kullanici.Surname = reader.GetString(2);
                        kullanici.FullName = reader.GetString(3);
                    }
                    if(kullanici != null)
                    {
                        LoginUser.user = kullanici;
                        islogin = true;
                        this.Close();
                    }
                    else
                    {
                        
                        MessageBox.Show("Kullanici Bulunamadi", "Uyari", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

            }//using parantezi bittigi anda using icerisinde olusturulan nesneyi dispose eder(Yok eder)
            }
            else
            {
                MessageBox.Show("Kullanici Adi ve Sifre Bos Birakilamaz", "Uyari", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void GirisForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(islogin == false)
            {
                Application.Exit();
            }
        }
    }
}
