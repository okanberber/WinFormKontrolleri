using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using WinFormKontrolleri.Model;

namespace WinFormKontrolleri
{
    public partial class ComboBoxKontrolu : Form
    {
        List<Marka> markalar = new List<Marka>();
        public ComboBoxKontrolu()
        {
            InitializeComponent();
            markalar.Add(new Marka() { ID =1, Isim ="Bosch"});
            markalar.Add(new Marka() { ID =2, Isim ="Milwakie"});
            markalar.Add(new Marka() { ID =3, Isim ="Hilti"});
            markalar.Add(new Marka() { ID =4, Isim ="Black Decker"});
            cb_Markalar.ValueMember = "ID";
            cb_Markalar.DisplayMember = "Isim";
            cb_Markalar.DataSource = markalar;
        }

        private void btn_departmanSec_Click(object sender, EventArgs e)
        {
            
            //string secilen = cb_departman.SelectedItem.ToString();
            string secilen = cb_departman.Text;
            if(secilen != "Seçiniz...")
            {
                lbl_secilenDepartman.Text = secilen;
            }
            else
            {
                lbl_secilenDepartman.Text = "Lütfen Seçim Yapınız";
            }
        }

        private void cb_egitim_SelectedIndexChanged(object sender, EventArgs e)
        {
            string secilen = cb_egitim.SelectedItem.ToString();
            lbl_Eğitim.Text = secilen;
        }

        private void btn_MarkaSec_Click(object sender, EventArgs e)
        {
            //string secilen = "ID = " + cb_Markalar.SelectedValue.ToString();
            //secilen += "Isim = " + cb_Markalar.SelectedItem.ToString();
            Marka m = (Marka)cb_Markalar.SelectedItem;
            lbl_MarkaLabel.Text = "ID = " + m.ID + "Isim = " + m.Isim;
        }
    }
}
