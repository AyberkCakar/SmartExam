using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace SmartExam
{
    public class Konu
    {
        public int KonuID { get; set; }
        public string DersAD { get; set; }
        public string KonuAD { get; set; }

        public List<Konu> Konular = new List<Konu>();
        public List<Konu> DersKonusu = new List<Konu>();

        sqlBaglanti connect = new sqlBaglanti();

        // Tüm Kayıtlı Konuları Getir 

        public void TumKonular()
        {

        }

    }
}
