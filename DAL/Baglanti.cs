using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Baglanti
    {
        //veritabanı bağlantımızı kontrol açmak için bu yapıyı kullanıyoruz.
        OleDbConnection baglanti;
        public OleDbConnection BaglantiKablosu
        {
            get
            {
                if (baglanti != null)
                {
                    if (baglanti.State == ConnectionState.Closed)
                    {
                        baglanti.Open();
                    }
                    return baglanti;
                }
                else
                {
                    baglanti = new OleDbConnection("Provider = Microsoft.Jet.OLEDB.4.0; Data Source = C:Kütüphane_Oto.mdb");
                    if (baglanti.State == ConnectionState.Closed)
                    {
                        baglanti.Open();
                    }
                    return baglanti;
                }

            }

        }
    }
}
