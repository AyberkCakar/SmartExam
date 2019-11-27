using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartExam
{
    public class Ogretmen : Kisi,ISoru
    {
        public string kullaniciAdi;
        public string Telefon { get; set; }
        public string Brans { get; set; }
        public Ogretmen(string KullaniciAdi)
        {
            this.kullaniciAdi = KullaniciAdi;
        }
        //private ISoruIslemleri soruIslemleri;

        public Ogretmen()
        {
        }
        //void SorularıGetir()
        //{
        //    soruIslemleri.TumSorulariGetir();
        //}

        public void SoruEkle(Soru soru)
        {
            throw new NotImplementedException();
        }

        public void SoruGuncelle(Soru soru)
        {
            throw new NotImplementedException();
        }

        public void SoruSil(Soru soru)
        {
            throw new NotImplementedException();
        }
    }
}
