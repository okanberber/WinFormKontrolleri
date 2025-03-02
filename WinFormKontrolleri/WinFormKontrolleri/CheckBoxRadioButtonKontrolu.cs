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
    public partial class CheckBoxRadioButtonKontrolu : Form
    {
        public CheckBoxRadioButtonKontrolu()
        {
            InitializeComponent();
            rb_erkek.Checked = true;
            rb_evli.Checked = true;
        }

        private void btn_gonder_Click(object sender, EventArgs e)
        {
            //lbl_ekran.Text = cb_secim.Checked.ToString();
            if (cb_secim.Checked)
            {
                lbl_ekran.Text = "Gönderme işlemi başarılı";
            }
            else
            {
                MessageBox.Show("Sözleşmeyi kabul etmelisiniz", "Sözleşme Kabulü");
            }
        }

        private void btn_getir_Click(object sender, EventArgs e)
        {
            string diller = "";
            if(cb_ingilizce.Checked){diller += "ingilizce";}
            if(cb_almanca.Checked){diller += "almanca";}
            if(cb_swailice.Checked){diller += "swailice";}
            lbl_ekran2.Text = "Diller = " + diller;

            string cinsiyet = "Erkek";
            if (rb_kadin.Checked)
            {
                cinsiyet = "Kadın";
            }
            string medenidurum = "Evli";
            if (rb_bekar.Checked)
            {
                medenidurum = "Bekar";
            }
            lbl_ekran3.Text = "Cinsiyet = " + cinsiyet + "Medeni Durum = " + medenidurum;
        }
    }
}
