using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormKontrolleri.Model;

namespace WinFormKontrolleri
{
    public partial class AnaForm : Form
    {
        public AnaForm()
        {
            InitializeComponent();
        }

        private void AnaForm_Load(object sender, EventArgs e)
        {
            GirisForm frm = new GirisForm();
            frm.ShowDialog();
            
            toolStripStatusLabel1.Text = "Kullanici = " + LoginUser.user.FullName;
        }

        private void TSMI_Kategori_Click(object sender, EventArgs e)
        {
            DataGridKontrolu frm = new DataGridKontrolu();
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }
    }
}
