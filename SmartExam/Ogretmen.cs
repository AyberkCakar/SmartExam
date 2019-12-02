using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace SmartExam
{
    public class Ogretmen : Kisi,ISoru,IDers,IKonu
    {
        public string kullaniciAdi;
        public string Telefon { get; set; }
        public string Brans { get; set; }
        public Ogretmen(string KullaniciAdi)
        {
            this.kullaniciAdi = KullaniciAdi;
        }

        public Ogretmen()
        {
        }

        sqlBaglanti connect = new sqlBaglanti();


        //
        // Öğretmen Bilgi İşlemleri
        //

        // Yeni Öğretmen Kaydı

        public override void KisiEkle()
        {
            throw new NotImplementedException();
        }

        // Öğretmen Bilgilerini Getirme

        public override void KisiBilgiGetir(string kullaniciAdi)
        {
            throw new NotImplementedException();
        }

        // Öğretmen Bilgi Güncelleme

        public override void KisiBilgiGuncelle(int DersID)
        {
            throw new NotImplementedException();
        }


        //
        // Soru İşlemleri
        //

        // Soru Ekleme

        public void SoruEkle(Soru soru, int DersID, int KonuID, int OgretmenID)
        {
            throw new NotImplementedException();
        }

        // Soru Güncelleme

        public void SoruGuncelle(Soru soru, int DersID, int KonuID)
        {
            throw new NotImplementedException();
        }

        // Soru Silme

        public void SoruSil(Soru soru)
        {
            throw new NotImplementedException();
        }


        //
        // Ders işlemleri
        //

        // Ders Ekleme

        public void DersEkle(Ders ders)
        {
            throw new NotImplementedException();
        }


        // Ders Güncelleme

        public void DersGuncelle(Ders ders)
        {
            throw new NotImplementedException();
        }

        // 
        // Konu İşlemleri
        //

        // Konu Ekleme

        public void KonuEkle(Konu konu, int DersID)
        {
            throw new NotImplementedException();
        }

        // Konu Güncelleme

        public void KonuGuncelle(Konu konu, int DersID)
        {
            throw new NotImplementedException();
        }

        // Derse Göre Konu Getirme

        public int DersKonuGetir(Konu konu, int DersID)
        {
            throw new NotImplementedException();
        }

    }
}
