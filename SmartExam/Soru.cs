using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartExam
{
    public class Soru:IResimEkle,ISoruIslemleri
    {
        public int SoruID { get; set; }
        public string SoruIcerik { get; set; }
        public string ACevabi { get; set; }
        public string BCevabi { get; set; }
        public string CCevabi { get; set; }
        public string DCevabi { get; set; }
        public string ECevabi { get; set; }
        public char Cevap { get; set; }
        public string Resim { get; set; }

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

        public void TumSorulariGetir()
        {
            throw new NotImplementedException();
        }
    }
}
