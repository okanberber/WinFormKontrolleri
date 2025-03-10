using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormKontrolleri
{
    public partial class MessageBoxKontrolu : Form
    {
        public MessageBoxKontrolu()
        {
            InitializeComponent();
        }

        private void btn_standart_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("icerik", "baslik");
            if(MessageBox.Show("icerik","baslik") == DialogResult.OK)
            {
                MessageBox.Show("Onaylandi");
            }
        }

        private void btn_evetHayir_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Benimle Evlenir Misin","Evlen",MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                MessageBox.Show("Evet Secildi");
            }
            else
            {
                MessageBox.Show("Hayir Secildi");
            }
        }

        private void btn_kaydetcik_Click(object sender, EventArgs e)
        {
            DialogResult sonuc = MessageBox.Show("Kaydetmek istiyor musun","Cikis",MessageBoxButtons.YesNoCancel);

            if(sonuc == DialogResult.Yes)
            {
                MessageBox.Show("Kayit Edildi", "Kayit Basarili");
            }
            if(sonuc == DialogResult.No)
            {
                Application.Exit();
            }
            if (sonuc == DialogResult.Cancel)
            {
                MessageBox.Show("Kullanici cikis islemini iptal etti", "Iptal edildi");
            }
        }

        private void btn_dene_Click(object sender, EventArgs e)
        {
            DialogResult sonuc = MessageBox.Show("Tekrar denemek ister misin", "Basarisiz", MessageBoxButtons.RetryCancel);

            if (sonuc == DialogResult.Retry)
            {
                MessageBox.Show("Retry Secildi");
            }
            else
            {
                MessageBox.Show("Keske deneseydin");
            }
        }

        private void btn_abort_Click(object sender, EventArgs e)
        {
            DialogResult sonuc = MessageBox.Show("Gorev Basarilamadi", "Basarisiz", MessageBoxButtons.AbortRetryIgnore);

            if (sonuc == DialogResult.Abort)
            {
                MessageBox.Show("Abort secildi");
            }
            if (sonuc == DialogResult.Retry)
            {
                MessageBox.Show("Retry secildi");
            }
            if (sonuc == DialogResult.Ignore)
            {
                MessageBox.Show("Ignore secildi");
            }
        }

        private void btn_info_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bilgilendirme","Info",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void btn_warning_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Uyari", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btn_error_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hata", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btn_question_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Naptin", "Question", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }

        private void btn_FormAc_Click(object sender, EventArgs e)
        {
            //MetinAraclari frm_Metin = new MetinAraclari();
            //frm_Metin.Show();
            
        }

        private void btn_sistemAc_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("calc");
        }

        private void btn_formAc2_Click(object sender, EventArgs e)
        {
            MetinAraclari frm_metin = new MetinAraclari();
            frm_metin.ShowDialog();
        }
    }
}
