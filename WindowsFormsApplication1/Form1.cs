using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class frmKitaplık : Form
    {
        public frmKitaplık()
        {
            InitializeComponent();
        }
        class Kitaplar
        {
            public string KitapAdi { get; set; }
            public string KitapYazari { get; set; }
            public string KitapTuru { get; set; }
        }
            ArrayList kaynakVeri = new ArrayList();

            private void btKitapEkle_Click(object sender, EventArgs e)
            {
                Kitaplar kitap = new Kitaplar();
                kitap.KitapAdi =txtKitapAdi.Text;
                kitap.KitapYazari = txtKitapYazari.Text;
                kitap.KitapTuru = txtKitapTuru.Text;
                kaynakVeri.Add(kitap);
            }

            private void btListele_Click(object sender, EventArgs e)
            {
                lbVeri.DataSource=null;
                lbVeri.DataSource = kaynakVeri;
                lbVeri.DisplayMember = "KitapAdi";
            }

            private void btIptal_Click(object sender, EventArgs e)
            {
                this.Close();
            }

    }
}
