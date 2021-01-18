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
    public partial class emanet_iade_gösterim : Form
    {
        public emanet_iade_gösterim()
        {
            InitializeComponent();
        }
        private void arama_btn_Click(object sender, EventArgs e)
        {
            //arama fonksiyonunda sorgu yapıp dönen liste değerlerini datagridview'e ekliyoruz.
            try
            {
                string konum = " ";
                konum = ozellik_c.SelectedItem.ToString();
                List<almaverme> kayit_cekme = iade_ve_alim.kayit_listeleme2(giris_t.Text, konum);
                liste_d.DataSource = kayit_cekme;
                MessageBox.Show("Arama başarılı!");
            }
            //eğer arama bölümü boş veya geçersiz ise hata mesajı veriyoruz.
            catch (Exception)
            {
                MessageBox.Show("Giriş değerlerini kontrol ediniz!");
            }
        }
      
        iade_emanet_islemleri iade_ve_alim = new iade_emanet_islemleri();
        private void cagirma_btn_Click(object sender, EventArgs e)
        {
            //veritabanından almaverme'deki tüm verileri çekip datagridview'e yazıyoruz.
            List<almaverme> kitap = iade_ve_alim.iade_alim_yukle();
            
            liste_d.DataSource = kitap;
           
          
            MessageBox.Show("Kayıt gösterme Başarılı!");
        }

        private void anasayfa_Click(object sender, EventArgs e)
        {
            //anasayfaya dönüş butonu.
            anasayfa anasyf = new anasayfa();
            anasyf.Show();
            this.Hide();
        }
        string konum = "";
        kitap_islem ktp_islem = new kitap_islem();

        private void kategori_cmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            konum = kategori_cmb.SelectedItem.ToString();
        }

        private void ktp_ara_t_Click(object sender, EventArgs e)

        {
            ktp_ara_t.Text = "";
        }

        private void ktp_ara_b_Click(object sender, EventArgs e)
        {
            //BL'daki kitap_islem sınıfından kitap_goster fonksiyonu çalıştırılarak kitap bilgileri
            //datagridview'e aktarılır.
            try
            {
                List<kitaplar> ktp2 = ktp_islem.kitap_goster(ktp_ara_t.Text, konum);
                liste_2.DataSource = ktp2;
                MessageBox.Show("Arama tamamlandı listeden kontrol ediniz.");
            }
            catch (Exception)
            {
                MessageBox.Show("Lütfen Alanları Doldurunuz!");
            }
        }
    }
}

