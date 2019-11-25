﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartExam
{
    public abstract class Kisi:IResimEkle
    {
        public int ID { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string TC { get; set; }
        public string Cinsiyet { get; set; }
        public DateTime DogumTarihi { get; set; }
        public string Resim { get; set; }
        public string KullanıcıID { get; set; }
        public string Sifre { get; set; }

        public void ResimEkle()
        {
            throw new NotImplementedException();
        }

        public void ResimSil()
        {
            throw new NotImplementedException();
        }

        public void ResimUpdate()
        {
            throw new NotImplementedException();
        }
    }
}