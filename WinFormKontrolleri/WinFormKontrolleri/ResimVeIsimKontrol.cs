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
    public partial class ResimVeIsimKontrol : UserControl
    {
        public ResimVeIsimKontrol()
        {
            InitializeComponent();
        }
        public ResimVeIsimKontrol(string imagepath, string name)
        {
            InitializeComponent();
            pictureBox1.ImageLocation = imagepath;
            label1.Text = name;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
