using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace SmartExam
{
    public class Soru:IResim
    {
        public int SoruID { get; set; }
        public string SoruIcerik { get; set; }
        public string ACevabi { get; set; }
        public string BCevabi { get; set; }
        public string CCevabi { get; set; }
        public string DCevabi { get; set; }
        public string ECevabi { get; set; }
        public string Cevap { get; set; }
        public string Resim { get; set; }
        public string Ders { get; set; }
        public int Sinif { get; set; }
        public string Konu { get; set; }

        public List<Soru> Sorular = new List<Soru>();

        sqlBaglanti connect = new sqlBaglanti();

        // Tüm Kayıtlı Soruları Getir

        public void TumSorular() 
        {

        }
    }
}
