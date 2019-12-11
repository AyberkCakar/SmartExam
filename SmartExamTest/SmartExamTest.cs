using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SmartExam;

namespace SmartExamTest
{
    [TestClass]
    public class SmartExamTest
    {
        // Öğretmen Soru Eklerken Yasak Karakter Girememesi Testi

        public void ogretmenSoruEkleKontrolTest(string soru, string A, string B, string C,string D, string E,string donenDeger)
        {
            TFuncKontrol tfk = new TFuncKontrol();
            string sonuc;
            sonuc = tfk.formYasakKontrol(soru,A,B,C,D,E);
            Assert.AreEqual(donenDeger,sonuc);
        }

        [TestMethod]
        public void ogretmenSoruEkleKontrolYanlis()
        {
            ogretmenSoruEkleKontrolTest("smart", "'a' % 5 ", "b cevabı", "c cevabı", "d cevabı", "e cevabı", "A Şıkkı  Kısmındaki Girmiş Olduğunuz Yasak Karakterlere ( ', *, =, % ) Dikkat Ediniz...");
        }

        [TestMethod]
        public void ogretmenSoruEkleKontrolDogru()
        {
            ogretmenSoruEkleKontrolTest("smart", "a cevabı", "b cevabı", "c cevabı", "d cevabı", "e cevabı", "Başarılı");
        }

        // Kullanıcı Şifresini Şifreleme Testi

        void sifreOlusturTest(string girisDeger, string cikisDeger)
        {
            Sifrele sifrele = new Sifrele();
            string sifre;
            sifre = sifrele.SifreOlustur(girisDeger);
            Assert.AreEqual(cikisDeger, sifre);

        }

        [TestMethod]
        public void sifreOlustur()
        {
            sifreOlusturTest("1999", "MTk5OQ==");
        }

        // Öğrenci Giriş Testi

        void ogrenciGirisTest(string kullanıcıAdi, string sifre, string cikisDeger)
        {
            GirisServisi girisServisi = new GirisServisi();
            Ogrenci ogrenci;
            ogrenci = (girisServisi.GirisYapOgrenci(kullanıcıAdi, sifre) as Ogrenci);
            Assert.AreEqual(cikisDeger, ogrenci.kullaniciAdi);
        }

        [TestMethod]
        public void ogrenciGiris()
        {
            ogrenciGirisTest("ayberk", "MTk5OQ==", "ayberk");
        }
    }
}
