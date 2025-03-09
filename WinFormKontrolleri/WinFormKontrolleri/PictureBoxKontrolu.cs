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
    public partial class PictureBoxKontrolu : Form
    {
        public PictureBoxKontrolu()
        {
            InitializeComponent();
            cb_sizeMod.SelectedIndex = 1;
        }

        private void PictureBoxKontrolu_Load(object sender, EventArgs e)
        {
            pb_resim.ImageLocation = "../../images/HD-wallpaper-among-us-karakter-among-us-art-beyaz-cizim-game-kirmizi-resim.jpg";
            pb_resim.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void cb_sizeMod_SelectedIndexChanged(object sender, EventArgs e)
        {
            string secilen = cb_sizeMod.SelectedItem.ToString();
            switch (secilen)
            {
                case "Oylece Birak":
                    pb_resim.SizeMode = PictureBoxSizeMode.Normal;
                    break;
                case "Resmi Sigdir":
                    pb_resim.SizeMode = PictureBoxSizeMode.Zoom;
                    break;
                case "Resmi Esnet":
                    pb_resim.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                case "Resmi Ortala":
                    pb_resim.SizeMode = PictureBoxSizeMode.CenterImage;
                    break;
                default:
                    break;
            }
        }
    }
}
