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
    public partial class MDIIcinAnaForm : Form
    {
        public MDIIcinAnaForm()
        {
            InitializeComponent();
        }

        private void TSMI_MetinAraclariForm_Click(object sender, EventArgs e)
        {
            Form[] acikFormlar = this.MdiChildren;
            bool acikmi = false;
            foreach (Form form in acikFormlar)
            {
                if(form.GetType() == typeof(MetinAraclari))
                {
                    acikmi = true;
                    form.Activate();//Form Acilmissa En One Getir
                }
            }
            if(acikmi == false)
            {
                MetinAraclari frm = new MetinAraclari();
                frm.MdiParent = this;
                frm.WindowState = FormWindowState.Maximized;
                frm.Show();
            }

        }

        private void TSMI_MetinEditoruAc_Click(object sender, EventArgs e)
        {
            Form[] acikFormlar = this.MdiChildren;
            bool acikmi = false;
            foreach (Form form in acikFormlar)
            {
                if (form.GetType() == typeof(MetinEditorum))
                {
                    acikmi = true;
                    form.Activate();//Form Acilmissa En One Getir
                }
            }
            if (acikmi == false)
            {
                MetinEditorum frm = new MetinEditorum();
                frm.MdiParent = this;
                frm.Show();
            }
        }
    }
}
