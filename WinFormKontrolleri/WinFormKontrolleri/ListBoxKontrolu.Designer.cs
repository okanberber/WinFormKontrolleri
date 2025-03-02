namespace WinFormKontrolleri
{
    partial class ListBoxKontrolu
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
            this.Lb_SehirListe = new System.Windows.Forms.ListBox();
            this.btn_getir = new System.Windows.Forms.Button();
            this.lbl_ekran = new System.Windows.Forms.Label();
            this.tb_sehir = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_aktar = new System.Windows.Forms.Button();
            this.Lb_SehirListe2 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Birden çok seçenek arasından bir veya birden \r\nçok seçeneği seçmemizi sağlayan ya" +
    "pıdır";
            // 
            // Lb_SehirListe
            // 
            this.Lb_SehirListe.FormattingEnabled = true;
            this.Lb_SehirListe.Items.AddRange(new object[] {
            "Ankara",
            "İstanbul",
            "İzmir",
            "Eskişehir"});
            this.Lb_SehirListe.Location = new System.Drawing.Point(15, 115);
            this.Lb_SehirListe.Name = "Lb_SehirListe";
            this.Lb_SehirListe.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.Lb_SehirListe.Size = new System.Drawing.Size(120, 95);
            this.Lb_SehirListe.TabIndex = 1;
            // 
            // btn_getir
            // 
            this.btn_getir.Location = new System.Drawing.Point(12, 216);
            this.btn_getir.Name = "btn_getir";
            this.btn_getir.Size = new System.Drawing.Size(123, 23);
            this.btn_getir.TabIndex = 2;
            this.btn_getir.Text = "Getir";
            this.btn_getir.UseVisualStyleBackColor = true;
            this.btn_getir.Click += new System.EventHandler(this.btn_getir_Click);
            // 
            // lbl_ekran
            // 
            this.lbl_ekran.AutoSize = true;
            this.lbl_ekran.Location = new System.Drawing.Point(12, 242);
            this.lbl_ekran.Name = "lbl_ekran";
            this.lbl_ekran.Size = new System.Drawing.Size(0, 13);
            this.lbl_ekran.TabIndex = 3;
            // 
            // tb_sehir
            // 
            this.tb_sehir.Location = new System.Drawing.Point(15, 89);
            this.tb_sehir.Name = "tb_sehir";
            this.tb_sehir.Size = new System.Drawing.Size(120, 20);
            this.tb_sehir.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(141, 87);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Ekle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Şehir Yazınız";
            // 
            // btn_aktar
            // 
            this.btn_aktar.Location = new System.Drawing.Point(141, 143);
            this.btn_aktar.Name = "btn_aktar";
            this.btn_aktar.Size = new System.Drawing.Size(75, 23);
            this.btn_aktar.TabIndex = 7;
            this.btn_aktar.Text = ">>";
            this.btn_aktar.UseVisualStyleBackColor = true;
            this.btn_aktar.Click += new System.EventHandler(this.btn_aktar_Click);
            // 
            // Lb_SehirListe2
            // 
            this.Lb_SehirListe2.FormattingEnabled = true;
            this.Lb_SehirListe2.Location = new System.Drawing.Point(222, 115);
            this.Lb_SehirListe2.Name = "Lb_SehirListe2";
            this.Lb_SehirListe2.Size = new System.Drawing.Size(120, 95);
            this.Lb_SehirListe2.TabIndex = 8;
            // 
            // ListBoxKontrolu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Lb_SehirListe2);
            this.Controls.Add(this.btn_aktar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tb_sehir);
            this.Controls.Add(this.lbl_ekran);
            this.Controls.Add(this.btn_getir);
            this.Controls.Add(this.Lb_SehirListe);
            this.Controls.Add(this.label1);
            this.Name = "ListBoxKontrolu";
            this.Text = "ListBoxKontrolu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox Lb_SehirListe;
        private System.Windows.Forms.Button btn_getir;
        private System.Windows.Forms.Label lbl_ekran;
        private System.Windows.Forms.TextBox tb_sehir;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_aktar;
        private System.Windows.Forms.ListBox Lb_SehirListe2;
    }
}