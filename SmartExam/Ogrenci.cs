using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartExam
{
    public class Ogrenci : Kisi,ISinav
    {
        public string kullaniciAdi;
        public int Sınıf { get; set; }
        public char Sube { get; set; }

        public Ogrenci(string KullaniciAdi)
        {
            this.kullaniciAdi = kullaniciAdi;
        }
        public Ogrenci()
        {

        }
        private ISinavIslemleri sinavIslemleri;
        public void SinavlariGetir()
        {
            sinavIslemleri.SinavlariGetir();
        }

        public void SinavaGir(Sinav sinav)
        {
            throw new NotImplementedException();
        }

        public void SinavOluştur(Sinav sinav, Soru soru)
        {
            throw new NotImplementedException();
        }
    }
}
