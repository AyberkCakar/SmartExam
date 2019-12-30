using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartExam
{
    public class TFuncKontrol
    {
        //
        // Öğretmen Kontrolleri
        //
        
        // T Func Soru Ekleme Yasak Karakter Kullanımı Kontrolü

        private static string durumYasak;
        public Func<string, string, string, string, string, string> formYasakKontrol = (Soru, A, B, C, D) =>
        {
            if (Soru.IndexOf("'") > 0 || Soru.IndexOf("*") > 0 || Soru.IndexOf(" = ") > 0 || Soru.IndexOf(" % ") > 0)
            {
                durumYasak = "Soru Bilgileri Kısmındaki Girmiş Olduğunuz Yasak Karakterlere ( ', *, =, % ) Dikkat Ediniz...";
            }
            else if (A.IndexOf("'") > 0 || A.IndexOf("*") > 0 || A.IndexOf("=") > 0 || A.IndexOf(" % ") > 0)
            {
                durumYasak = "A Şıkkı  Kısmındaki Girmiş Olduğunuz Yasak Karakterlere ( ', *, =, % ) Dikkat Ediniz...";
            }
            else if (B.IndexOf("'") > 0 || B.IndexOf("*") > 0 || B.IndexOf("=") > 0 || B.IndexOf(" % ") > 0)
            {
                durumYasak = "B Şıkkı Kısmındaki Girmiş Olduğunuz Yasak Karakterlere( ', *, =, % ) Dikkat Ediniz...";
            }
            else if (C.IndexOf("'") > 0 || C.IndexOf("*") > 0 || C.IndexOf("=") > 0 || C.IndexOf(" % ") > 0)
            {
                durumYasak = "C Şıkkı Kısmındaki Girmiş Olduğunuz Yasak Karakterlere ( ', *, =, % ) Dikkat Ediniz...";
            }
            else if (D.IndexOf("'") > 0 || D.IndexOf("*") > 0 || D.IndexOf("=") > 0 || D.IndexOf(" % ") > 0)
            {
                durumYasak = "D Şıkkı Kısmındaki Girmiş Olduğunuz Yasak Karakterlere ( ', *, =, % ) Dikkat Ediniz...";
            }
            else
                durumYasak = "Başarılı";

            return durumYasak;
        };


        
        // T Func Soru Ekleme  NULL Değer Kontrolü
        

        private static string durumNull;
        public Func<string, string, string, string, string, string, string, string, string> formNullKontrol = (Soru, A, B, C, D, Cevap, Ders, Konu) =>
        {
            if (Soru.Length <= 0)
            {
                durumNull = "Soru Boş Geçilemez...";
            }
            else if (A.Length <= 0 || A.Length > 50)
            {
                durumNull = "A Şıkkı Bilgilerinizi Kontrol Ediniz...";
            }
            else if (B.Length <= 0 || B.Length > 50)
            {
                durumNull = "B Şıkkı Bilgilerinizi Kontrol Ediniz...";
            }
            else if (C.Length <= 0 || C.Length > 50)
            {
                durumNull = "C Şıkkı Bilgilerinizi Kontrol Ediniz...";
            }
            else if (D.Length <= 0 || D.Length > 50)
            {
                durumNull = "D Şıkkı Bilgilerinizi Kontrol Ediniz...";
            }
            else if (Cevap.Length <= 0)
            {
                durumNull = "Cevap Bilgilerinizi Kontrol Ediniz...";
            }
            else if (Ders.Length <= 0)
            {
                durumNull = "Ders Bilgilerinizi Kontrol Ediniz...";
            }
            else if (Konu.Length <= 0)
            {
                durumNull = "Konu Bilgilerinizi Kontrol Ediniz...";
            }
            else
                durumNull = "Başarılı";

            return durumNull;
        };


        //
        // Kayıt Kontrolleri
        // 

        
        // Boş , Aşırı Uzunluk , Gerekli Kısıtlamalar(Tırnak, Parantez) 

        private static string durumKayit;
        public Func<string, string, string, string, string, string, string> formKontrol = (Ad, Soyad, TC, KullaniciID, Sifre, Tarih) =>
        {
            if (Ad.Length <= 0 || Ad.Length > 25)
            {
                durumKayit = "İsim Bilgilerinizi Kontrol Ediniz...";
            }
            else if (Soyad.Length <= 0 || Soyad.Length > 15)
            {
                durumKayit = "Soyisim Bilgilerinizi Kontrol Ediniz...";
            }
            else if (TC.Length < 11)
            {
                durumKayit = "TC Kimlik Bilgilerinizi Kontrol Ediniz...";
            }
            else if (KullaniciID.Length <= 0 || KullaniciID.Length > 10)
            {
                durumKayit = "Kullanıcı ID Bilgilerini Kontrol Ediniz...";
            }
            else if (Sifre.Length <= 0 || Sifre.Length > 10)
            {
                durumKayit = "Şifre Bilgilerinizi Kontrol Ediniz...";
            }
            else if (Tarih.Length <= 0)
            {
                durumKayit = "Doğum Tarihi Bilgilerinizi Kontrol Ediniz...";
            }
            else
                durumKayit = "Başarılı";

            return durumKayit;
        };


        //
        // Sınav Cevaplarının Kontrolü
        //

        // Soru Cevap Kontrolleri İçin TFunc

        private static bool cevapDurum;
        public Func<string, string, Boolean> funcSoruCevap = (Cevap, DogruCevap) =>
        {
            if (Cevap == DogruCevap)
            {
                cevapDurum = true;
            }
            else
                cevapDurum = false;
            return cevapDurum;

        };
    }
}
