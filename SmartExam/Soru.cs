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
        public string Cevap { get; set; }
        public string Resim { get; set; }
        public string Ders { get; set; }
        public string Konu { get; set; }

        public List<Soru> Sorular = new List<Soru>();

        sqlBaglanti connect = new sqlBaglanti();

        // Tüm Kayıtlı Soruları Getir

        public void TumSorular() 
        {
            SqlCommand soruGetir = new SqlCommand("exec tumSorular", connect.baglanti());
            SqlDataReader Dtr = soruGetir.ExecuteReader();
            while (Dtr.Read())
            {
                Soru soru = new Soru();
                soru.SoruID = Convert.ToInt32(Dtr[0]);
                soru.SoruIcerik = Dtr[1].ToString();
                soru.ACevabi = Dtr[2].ToString();
                soru.BCevabi = Dtr[3].ToString();
                soru.CCevabi = Dtr[4].ToString();
                soru.DCevabi = Dtr[5].ToString();
                soru.Cevap = Dtr[6].ToString();
                soru.Resim = Dtr[7].ToString();
                soru.Ders = Dtr[8].ToString();
                soru.Konu = Dtr[9].ToString();
                Sorular.Add(soru);
            }
            connect.baglanti().Close();
        }
    }
}
