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
        public static bool KullaniciOgrDogrula(string kullaniciAdi, string sifre) //  Öğrenci adi şifre kontrolü
        {
            sqlBaglanti connect = new sqlBaglanti();
            SqlCommand komut = new SqlCommand("Select * From Tbl_Ogrenci where KullaniciAdi =@p1 and Sifre = @p2", connect.baglanti());
            komut.Parameters.AddWithValue("@p1", kullaniciAdi);
            komut.Parameters.AddWithValue("@p2", sifre);
            SqlDataReader dr1 = komut.ExecuteReader();
            if (dr1.Read())
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool KullaniciOgrtDogrula(string kullaniciAdi, string sifre)// Öğretmen  adi şifre kontrolü
        {
            sqlBaglanti connect = new sqlBaglanti();
            SqlCommand komut = new SqlCommand("Select * From Tbl_Ogretmen where KullaniciAdi =@p1 and Sifre = @p2", connect.baglanti());
            komut.Parameters.AddWithValue("@p1", kullaniciAdi);
            komut.Parameters.AddWithValue("@p2", sifre);
            SqlDataReader dr1 = komut.ExecuteReader();
            if (dr1.Read())
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public Kisi GirisYap(string kullaniciAdi, string sifre) //Öğrenci giriş yapma
        {
            if (KullaniciOgrDogrula(kullaniciAdi, sifre))
            {
                return new Ogrenci(kullaniciAdi);
            }
            else
            {
                return null;
            }
        }
        public Kisi GirisYapOgrt(string kullaniciAdi, string sifre) // Öğretmen Giriş Yapma
        {
            if (KullaniciOgrtDogrula(kullaniciAdi, sifre))
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
