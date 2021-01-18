using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KutuphaneOtomasyonu
{
    public partial class anasayfa : Form
    {
        public anasayfa()
        {
            InitializeComponent();
        }

        private void ogrenci_islem_Click(object sender, EventArgs e)
        {
            ogrenci_islemleri ogrislem = new ogrenci_islemleri();
            ogrislem.Show();
            this.Hide();
        }

        private void kitap_islemleri_Click(object sender, EventArgs e)
        {
            kitap_islemleri ktpislem = new kitap_islemleri();
            ktpislem.Show();
            this.Hide();
        }

        private void alım_iade_Click(object sender, EventArgs e)
        {
            iade_ve_emanet iadeEmanetislem = new iade_ve_emanet();
            iadeEmanetislem.Show();
            this.Hide();
        }

        private void kitap_iadeEmanet_listesi_Click(object sender, EventArgs e)
        {
            emanet_iade_gösterim ktplisteislem = new emanet_iade_gösterim();
            ktplisteislem.Show();
            this.Hide();
        }

        private void ögrenci_iadeEmanet_listesi_Click(object sender, EventArgs e)
        {
            ogrenci_emanet_iade_gösterim ogrlisteislem = new ogrenci_emanet_iade_gösterim();
            ogrlisteislem.Show();
            this.Hide();
        }

        private void grafik_b_Click(object sender, EventArgs e)
        {
            kitap_grafik grfkislem = new kitap_grafik();
            grfkislem.Show();
            this.Hide();
        }
    }

}
