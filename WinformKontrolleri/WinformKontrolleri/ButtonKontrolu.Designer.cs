namespace WinformKontrolleri
{
    partial class ButtonKontrolu
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btn_tikla = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 22);
            this.button1.TabIndex = 0;
            this.button1.Text = "Standart Buton";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Location = new System.Drawing.Point(123, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(105, 54);
            this.button2.TabIndex = 0;
            this.button2.Text = "Şişman Buton";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.button3.Location = new System.Drawing.Point(234, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(86, 54);
            this.button3.TabIndex = 1;
            this.button3.Text = "Renkli Buton";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // btn_tikla
            // 
            this.btn_tikla.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_tikla.Location = new System.Drawing.Point(33, 128);
            this.btn_tikla.Name = "btn_tikla";
            this.btn_tikla.Size = new System.Drawing.Size(84, 42);
            this.btn_tikla.TabIndex = 3;
            this.btn_tikla.Text = "Tıkla";
            this.btn_tikla.UseVisualStyleBackColor = true;
            this.btn_tikla.Click += new System.EventHandler(this.btn_tikla_Click);
            // 
            // button4
            // 
            this.button4.BackgroundImage = global::WinformKontrolleri.Properties.Resources.angry_black_cat_meme;
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button4.Location = new System.Drawing.Point(326, 12);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(47, 54);
            this.button4.TabIndex = 2;
            this.button4.UseVisualStyleBackColor = true;
            // 
            // ButtonKontrolu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_tikla);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "ButtonKontrolu";
            this.Text = "ButtonKontrolu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btn_tikla;
    }
}