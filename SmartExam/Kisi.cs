using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartExam
{
    public abstract class Kisi:IResim
    {
        public int ID { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string TC { get; set; }
        public bool Cinsiyet { get; set; }
        public DateTime DogumTarihi { get; set; }
        public string Resim { get; set; }
        public string KullanıcıID { get; set; }
        public string Sifre { get; set; }
        public abstract void KisiEkle();
        public abstract void KisiBilgiGetir(string kullaniciAdi);
        public abstract void KisiBilgiGuncelle(int DersID);
    }
}
