using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace SmartExam
{
    class GirisServisi
    {
        //
        // Bilgi Doğrulama İşlemleri
        //

        // Öğrenci Bilgi Doğrulama

        public static bool OgrenciDogrula(string kullaniciAdi, string sifre) 
        {
            sqlBaglanti connect = new sqlBaglanti();
            SqlCommand ogrenciSelect = new SqlCommand("Select * From Tbl_Ogrenci where KullaniciAdi =@p1 and Sifre = @p2", connect.baglanti());
            ogrenciSelect.Parameters.AddWithValue("@p1", kullaniciAdi);
            ogrenciSelect.Parameters.AddWithValue("@p2", sifre);
            SqlDataReader drOgrenci = ogrenciSelect.ExecuteReader();
            if (drOgrenci.Read())
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // Öğretmen Bilgi Doğrulama

        public static bool OgretmenDogrula(string kullaniciAdi, string sifre)
        {
            sqlBaglanti connect = new sqlBaglanti();
            SqlCommand ogretmenSelect = new SqlCommand("Select * From Tbl_Ogretmen where KullaniciAdi =@p1 and Sifre = @p2", connect.baglanti());
            ogretmenSelect.Parameters.AddWithValue("@p1", kullaniciAdi);
            ogretmenSelect.Parameters.AddWithValue("@p2", sifre);
            SqlDataReader drOgretmen = ogretmenSelect.ExecuteReader();
            if (drOgretmen.Read())
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //
        // Giriş Yapma İşlemleri
        //

        // Öğrenci Giriş Yapma

        public Kisi GirisYapOgrenci(string kullaniciAdi, string sifre) 
        {
            if (OgrenciDogrula(kullaniciAdi, sifre))
            {
                return new Ogrenci(kullaniciAdi);
            }
            else
            {
                return null;
            }
        }

        // Öğretmen Giriş Yapma

        public Kisi GirisYapOgretmen(string kullaniciAdi, string sifre) 
        {
            if (OgretmenDogrula(kullaniciAdi, sifre))
            {
                return new Ogretmen(kullaniciAdi);
            }
            else
            {
                return null;
            }
        }
    }
}
