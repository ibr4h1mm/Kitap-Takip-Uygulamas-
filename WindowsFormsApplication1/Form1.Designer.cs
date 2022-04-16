namespace WindowsFormsApplication1
{
    partial class frmKitaplık
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKitaplık));
            this.txtKitapTuru = new System.Windows.Forms.TextBox();
            this.txtKitapYazari = new System.Windows.Forms.TextBox();
            this.txtKitapAdi = new System.Windows.Forms.TextBox();
            this.btKitapEkle = new System.Windows.Forms.Button();
            this.btListele = new System.Windows.Forms.Button();
            this.lbVeri = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btCikis = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtKitapTuru
            // 
            this.txtKitapTuru.BackColor = System.Drawing.Color.Yellow;
            this.txtKitapTuru.Location = new System.Drawing.Point(280, 84);
            this.txtKitapTuru.Multiline = true;
            this.txtKitapTuru.Name = "txtKitapTuru";
            this.txtKitapTuru.Size = new System.Drawing.Size(275, 21);
            this.txtKitapTuru.TabIndex = 17;
            // 
            // txtKitapYazari
            // 
            this.txtKitapYazari.BackColor = System.Drawing.Color.Yellow;
            this.txtKitapYazari.Location = new System.Drawing.Point(280, 58);
            this.txtKitapYazari.Multiline = true;
            this.txtKitapYazari.Name = "txtKitapYazari";
            this.txtKitapYazari.Size = new System.Drawing.Size(275, 21);
            this.txtKitapYazari.TabIndex = 16;
            // 
            // txtKitapAdi
            // 
            this.txtKitapAdi.BackColor = System.Drawing.Color.Yellow;
            this.txtKitapAdi.Location = new System.Drawing.Point(280, 32);
            this.txtKitapAdi.Multiline = true;
            this.txtKitapAdi.Name = "txtKitapAdi";
            this.txtKitapAdi.Size = new System.Drawing.Size(275, 21);
            this.txtKitapAdi.TabIndex = 15;
            // 
            // btKitapEkle
            // 
            this.btKitapEkle.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btKitapEkle.Location = new System.Drawing.Point(158, 344);
            this.btKitapEkle.Name = "btKitapEkle";
            this.btKitapEkle.Size = new System.Drawing.Size(112, 48);
            this.btKitapEkle.TabIndex = 14;
            this.btKitapEkle.Text = "Kitap Ekle";
            this.btKitapEkle.UseVisualStyleBackColor = false;
            this.btKitapEkle.Click += new System.EventHandler(this.btKitapEkle_Click);
            // 
            // btListele
            // 
            this.btListele.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btListele.Location = new System.Drawing.Point(386, 432);
            this.btListele.Name = "btListele";
            this.btListele.Size = new System.Drawing.Size(179, 50);
            this.btListele.TabIndex = 13;
            this.btListele.Text = "Listele";
            this.btListele.UseVisualStyleBackColor = false;
            this.btListele.Click += new System.EventHandler(this.btListele_Click);
            // 
            // lbVeri
            // 
            this.lbVeri.BackColor = System.Drawing.SystemColors.Desktop;
            this.lbVeri.FormattingEnabled = true;
            this.lbVeri.Location = new System.Drawing.Point(386, 168);
            this.lbVeri.Name = "lbVeri";
            this.lbVeri.Size = new System.Drawing.Size(179, 225);
            this.lbVeri.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(195, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Kitap Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(195, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Kitap Yazarı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(195, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Kitap Türü";
            // 
            // btCikis
            // 
            this.btCikis.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btCikis.Location = new System.Drawing.Point(158, 398);
            this.btCikis.Name = "btCikis";
            this.btCikis.Size = new System.Drawing.Size(112, 44);
            this.btCikis.TabIndex = 21;
            this.btCikis.Text = "Çıkış";
            this.btCikis.UseVisualStyleBackColor = false;
            this.btCikis.Click += new System.EventHandler(this.btIptal_Click);
            // 
            // frmKitaplık
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(777, 515);
            this.Controls.Add(this.btCikis);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtKitapTuru);
            this.Controls.Add(this.txtKitapYazari);
            this.Controls.Add(this.txtKitapAdi);
            this.Controls.Add(this.btKitapEkle);
            this.Controls.Add(this.btListele);
            this.Controls.Add(this.lbVeri);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmKitaplık";
            this.Text = "Kitap Takip Uygulaması";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtKitapTuru;
        private System.Windows.Forms.TextBox txtKitapYazari;
        private System.Windows.Forms.TextBox txtKitapAdi;
        private System.Windows.Forms.Button btKitapEkle;
        private System.Windows.Forms.Button btListele;
        private System.Windows.Forms.ListBox lbVeri;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btCikis;
    }
}

