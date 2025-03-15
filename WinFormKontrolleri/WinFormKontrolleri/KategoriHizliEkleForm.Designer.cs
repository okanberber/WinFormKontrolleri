namespace WinFormKontrolleri
{
    partial class KategoriHizliEkleForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.tb_kategoriAdi = new System.Windows.Forms.TextBox();
            this.btn_kategoriEkle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kategori Adi";
            // 
            // tb_kategoriAdi
            // 
            this.tb_kategoriAdi.Location = new System.Drawing.Point(93, 27);
            this.tb_kategoriAdi.Name = "tb_kategoriAdi";
            this.tb_kategoriAdi.Size = new System.Drawing.Size(171, 20);
            this.tb_kategoriAdi.TabIndex = 1;
            // 
            // btn_kategoriEkle
            // 
            this.btn_kategoriEkle.Location = new System.Drawing.Point(289, 25);
            this.btn_kategoriEkle.Name = "btn_kategoriEkle";
            this.btn_kategoriEkle.Size = new System.Drawing.Size(122, 23);
            this.btn_kategoriEkle.TabIndex = 2;
            this.btn_kategoriEkle.Text = "Kategori Ekle";
            this.btn_kategoriEkle.UseVisualStyleBackColor = true;
            this.btn_kategoriEkle.Click += new System.EventHandler(this.btn_kategoriEkle_Click);
            // 
            // KategoriHizliEkleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 74);
            this.Controls.Add(this.btn_kategoriEkle);
            this.Controls.Add(this.tb_kategoriAdi);
            this.Controls.Add(this.label1);
            this.Name = "KategoriHizliEkleForm";
            this.Text = "KategoriHizliEkleForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_kategoriAdi;
        private System.Windows.Forms.Button btn_kategoriEkle;
    }
}