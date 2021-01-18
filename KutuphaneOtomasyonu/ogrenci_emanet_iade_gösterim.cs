using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entity;
using BL;


namespace KutuphaneOtomasyonu
{
    public partial class ogrenci_emanet_iade_gösterim : Form
    {
        public ogrenci_emanet_iade_gösterim()
        {
            InitializeComponent();
        }
        iade_emanet_islemleri iade_ve_alimlar = new iade_emanet_islemleri();
        private void yukleme_btn_Click(object sender, EventArgs e)
        {
            //öğrencilerin daha önce yaptığı kitap alım ve iadeleri datagridview üzerinde gösterilir.
            List<almaverme> ktp1 = iade_ve_alimlar.iade_alim_yukle();
            liste_d.DataSource = ktp1;
            
        }

        private void giris_t_Click(object sender, EventArgs e)
        {
            //textbox üzerine tıklanınca text'ler silinir.
            giris_t.Text = "";
        }

        private void arama_btn_Click(object sender, EventArgs e)
        {
            //BL'daki iade_alim_islemleri sınıfından ogrenci_emanet_iade_listele fanksiyonu çalıştırılıp arama textbox içindeki veri tablodan çağırılıp datagridview üzerinden
            //gösterilir.
            List<almaverme> arama = iade_ve_alimlar.ogrenci_emanet_iade_listele(giris_t.Text);
            liste_d.DataSource = arama;
           
        }

        private void anasayfa_Click(object sender, EventArgs e)
        {
            //anasayfaya dönüş butonu.
            anasayfa anasyf = new anasayfa();
            anasyf.Show();
            this.Hide();
        }
    }
}

