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
    public partial class ButtonKontrolu : Form
    {
        public ButtonKontrolu()
        {
            InitializeComponent();
        }

        private void btn_tikla_Click(object sender, EventArgs e)
        {
            this.Text = "Tıkladım Noolmuş";
            btn_tikla.Text = button1.Text = button2.Text = "Heeee";
        }
    }
}
