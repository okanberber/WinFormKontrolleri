using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormKontrolleri
{
    public partial class FlowLayoutPanelVeUserKontrol : Form
    {
        string path = "";
        ComboBox cb_goruntulemeSekli;
        public FlowLayoutPanelVeUserKontrol()
        {
            InitializeComponent();
            FormDesign();
        }
        private void FormDesign()
        {
            cb_goruntulemeSekli = new ComboBox();
            cb_goruntulemeSekli.Location = new Point(20, 370);
            cb_goruntulemeSekli.Size = new Size(250, 30);
            cb_goruntulemeSekli.Items.Add("Autosize");
            cb_goruntulemeSekli.Items.Add("Center Image");
            cb_goruntulemeSekli.Items.Add("Normal");
            cb_goruntulemeSekli.Items.Add("Stretch Image");
            cb_goruntulemeSekli.Items.Add("Zoom");
            cb_goruntulemeSekli.SelectedIndexChanged += Cb_goruntulemeSekli_SelectedIndexChanged;
            cb_goruntulemeSekli.Anchor = AnchorStyles.Bottom|AnchorStyles.Right;
            this.Controls.Add(cb_goruntulemeSekli);
            
        }

        private void Cb_goruntulemeSekli_SelectedIndexChanged(object sender, EventArgs e)
        {
            string secilen = cb_goruntulemeSekli.SelectedItem.ToString();
            switch(secilen)
            {
                case "Auto Size":
                    pictureBox1.SizeMode=PictureBoxSizeMode.AutoSize;
                    break;
                case "Center Image":
                    pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
                    break;
                case "Normal":
                    pictureBox1.SizeMode = PictureBoxSizeMode.Normal;
                    break;
                case "Stretch Image":
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                case "Zoom":
                    pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                    break;
            }
        }

        private void btn_KlasorSec_Click(object sender, EventArgs e)
        {
            //PictureBoxIleDoldur();
            UserKontrolIleDoldur();
        }

        private void UserKontrolIleDoldur()
        {
            DialogResult sonuc = folderBrowserDialog1.ShowDialog();
            if (sonuc == DialogResult.OK)
            {
                DirectoryInfo klasor = new DirectoryInfo(folderBrowserDialog1.SelectedPath);
                List<FileInfo> resimler = klasor.GetFiles().ToList();
                foreach (FileInfo item in resimler)
                {
                    if (item.Extension == ".jpg" || item.Extension == ".png" || item.Extension == ".jpeg")
                    {
                        ResimVeIsimKontrol usercontrol = new ResimVeIsimKontrol(item.FullName,item.Name);
                        flowLayoutPanel1.Controls.Add(usercontrol);
                    }
                }
            }
        }

        private void PictureBoxIleDoldur()
        {
            DialogResult sonuc = folderBrowserDialog1.ShowDialog();
            if (sonuc == DialogResult.OK)
            {
                path = folderBrowserDialog1.SelectedPath;

                DirectoryInfo klasor = new DirectoryInfo(path);
                List<FileInfo> dosyalar = klasor.GetFiles().ToList();
                foreach (FileInfo fi in dosyalar)
                {
                    if (fi.Extension == ".jpg" || fi.Extension == ".png" || fi.Extension == ".jpeg")
                    {
                        PictureBox resimtasiyici = new PictureBox();
                        resimtasiyici.Cursor = Cursors.Hand;
                        resimtasiyici.Click += Resimtasiyici_Click;
                        resimtasiyici.SizeMode = PictureBoxSizeMode.Zoom;
                        resimtasiyici.Size = new Size(200, 100);
                        resimtasiyici.ImageLocation = fi.FullName;
                        flowLayoutPanel1.Controls.Add(resimtasiyici);
                    }
                }
            }
        }

        private void Resimtasiyici_Click(object sender, EventArgs e)
        {
           PictureBox resim = (PictureBox)sender;
            pictureBox1.ImageLocation = resim.ImageLocation;
        }
    }
}
