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
    public partial class DateTimeKontrolleri : Form
    {
        public DateTimeKontrolleri()
        {
            InitializeComponent();
            mc_takvim.MaxSelectionCount = 10;
            //mc_takvim.ShowToday = false;
            mc_takvim.ShowTodayCircle = false;
            mc_takvim.ShowWeekNumbers = true;
            SelectionRange x = mc_takvim.SelectionRange;
        }

        private void btn_TarihGetir_Click(object sender, EventArgs e)
        {
            DateTime secilen = dtp_Dogum.Value;

            int saat = Convert.ToInt32(nud_saat.Value);
            int Dakika = Convert.ToInt32(nud_saat.Value);

            lbl_tarih.Text = secilen.ToShortDateString();
            lbl_kisaTarih.Text = secilen.ToShortDateString();
            lbl_uzunTarih.Text = secilen.ToLongDateString();

            DateTime uretilen = Convert.ToDateTime(secilen.ToShortDateString() + " " + saat + ":" + Dakika + ":00");
            lbl_uretilen.Text = uretilen.ToString();
            
        }

        private void btn_aralik_Click(object sender, EventArgs e)
        {
            string aralik = mc_takvim.SelectionStart.ToString()+" - "+ mc_takvim.SelectionEnd.ToString();
            lbl_aralik.Text =aralik;

            TimeSpan ts = mc_takvim.SelectionEnd - mc_takvim.SelectionStart;
            int gun = Convert.ToInt32(ts.TotalDays);
            lbl_tarihfark.Text = gun.ToString();
        }
    }
}
