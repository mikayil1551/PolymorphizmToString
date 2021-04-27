using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PolymorphizmToString
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Ogrenci ogr = new Ogrenci();
            ogr.Adi = txtAd.Text;
            ogr.Soyadi = txtSoyad.Text;
            ogr.TCKN = txtTCKN.Text;
            ogr.DogumTarihi = dtpDogumTarihi.Value;
            listView1.Items.Add(ogr.ToString());
        }
    }
}
