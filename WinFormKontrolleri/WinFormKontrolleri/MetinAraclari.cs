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
    public partial class MetinAraclari : Form
    {
        public MetinAraclari()
        {
            InitializeComponent();
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            int count = textBox7.Text.Length;
            lbl_count.Text = Convert.ToString(20-count);
        }
    }
}
