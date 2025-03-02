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

namespace WinFormKontrolleri
{
    public partial class ListBoxKontrolu : Form
    {
        public ListBoxKontrolu()
        {
            InitializeComponent();
        }

        private void btn_getir_Click(object sender, EventArgs e)
        {
            //string secilen = Lb_SehirListe.SelectedItem.ToString();
            string secilenler = "";
            foreach (var item in Lb_SehirListe.SelectedItems)
            {
                secilenler += "," + item.ToString();
            }
            lbl_ekran.Text = secilenler;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tb_sehir.Text))
            {
                Lb_SehirListe.Items.Add(tb_sehir.Text);
                tb_sehir.Text = "";
            }
           
        }

        private void btn_aktar_Click(object sender, EventArgs e)
        {
            foreach (var item in Lb_SehirListe.SelectedItems)
            {
                Lb_SehirListe2.Items.Add(item);
            }
            foreach (var item in Lb_SehirListe2.Items)
            {
                Lb_SehirListe.Items.Remove(item);
            }
        }
    }
}
