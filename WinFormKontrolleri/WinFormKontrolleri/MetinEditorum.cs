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
    public partial class MetinEditorum : Form
    {
        string yol = "";
        public MetinEditorum()
        {
            InitializeComponent();
            saveFileDialog1.Filter = "Zengin Metin Biçimi|*.rtf|Tüm Dosyalar|*.*";
            openFileDialog1.Filter = "Zengin Metin Biçimi|*.rtf|Tüm Dosyalar|*.*";
            FontFamily[] fontlar = FontFamily.Families;
            foreach (FontFamily item in fontlar)
            {
                TSCB_Font.Items.Add(item.Name);
            }
            TSCB_Font.SelectedItem = richTextBox1.Font.Name;
            TSCB_Size.SelectedItem = "11";
        }

        private void TSMI_Kapat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void TSMI_Kaydet_Click(object sender, EventArgs e)
        {
            DialogResult sonuc = saveFileDialog1.ShowDialog();
            if (sonuc == DialogResult.OK)
            {
                yol = saveFileDialog1.FileName;
                richTextBox1.SaveFile(yol);
                MessageBox.Show("Kayit Basarili");
            }
        }

        private void TSMI_Ac_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //richTextBox1.LoadFile(openFileDialog1.FileName);
                FileInfo fi = new FileInfo(openFileDialog1.FileName);
                if (fi.Extension == ".txt")
                {
                    StreamReader sr = new StreamReader(openFileDialog1.FileName);
                    string metin = sr.ReadToEnd();
                    richTextBox1.Text = metin;
                }
                else if (fi.Extension == ".rtf")
                {
                    richTextBox1.LoadFile(openFileDialog1.FileName);
                }
                else
                {
                    MessageBox.Show("secilen dosya formati uygun degil", "Hata");
                }
            }
            else
            {
                MessageBox.Show("Dosya Acma islemi iptal edildi");
            }
        }

        private void TSCB_Font_SelectedIndexChanged(object sender, EventArgs e)
        {
            FontFamily ff = new FontFamily(TSCB_Font.Text);
            float FontSize = 11;
            if (TSCB_Size.SelectedItem != null)
            {
                FontSize = Convert.ToSingle(TSCB_Size.SelectedItem.ToString());
            }
            Font seciliFont = new Font(ff, FontSize);
            richTextBox1.SelectionFont = seciliFont;
            if(richTextBox1.SelectedText.Length == 0)
            {
                richTextBox1.Font = seciliFont;
            }
            else
            {
                richTextBox1.SelectionFont = seciliFont;
            }
        }

        private void TSCB_Size_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TSCB_Font.SelectedItem != null)
            {
                FontFamily ff = new FontFamily(TSCB_Font.Text);
                Font seciliFont = new Font(ff, Convert.ToSingle(TSCB_Size.SelectedItem.ToString()));
                richTextBox1.Font = seciliFont;
            }
        }

        private void TSMI_Yazdir_Click(object sender, EventArgs e)
        {
            if(printDialog1.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Yazdirildi");
            }
            else
            {
                MessageBox.Show("iptal edildi");
            }
        }

        private void TSBTN_FontDegistir_Click(object sender, EventArgs e)
        {
            if(fontDialog1.ShowDialog()== DialogResult.OK)
            {
                richTextBox1.Font = fontDialog1.Font;
            }
        }

        private void TSBTN_Renk_Click(object sender, EventArgs e)
        {
            if(colorDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.ForeColor = colorDialog1.Color;
                TSBTN_Renk.ForeColor = colorDialog1.Color;
            }
        }
    }
}
