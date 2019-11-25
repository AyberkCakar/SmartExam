using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace SmartExam
{
    public class Sinav:ISinavIslemleri
    {
        public int SinavID { get; set; }
        public int SoruSayisi { get; set; }
        public int Sinif { get; set; }
        public string Ders { get; set; }
        public List<Soru> Sorular { get; set; }
        public List<Sinav> Sinavlar = new List<Sinav>();
        public SinavDetay sinavDet = new SinavDetay();
        sqlBaglanti connect = new sqlBaglanti();
        public void SinavlariGetir()
        {
            SqlCommand select = new SqlCommand("select S.SınavID,SınavSoru,Sınıf,DersAD,Durum,Dogru,Yanlış,Bos from Tbl_Sınav S inner join Tbl_SınavDetay SD on S.SınavID = SD.SınavID inner join Tbl_Ders D on D.DersID = S.DersID", connect.baglanti());
            //select.Parameters.AddWithValue("@p1", OgrenciID); where sd.OgrenciID = @p1 int OgrenciID
            SqlDataReader Dtr = select.ExecuteReader();
            while (Dtr.Read())
            {
                Sinav sinav = new Sinav();
                sinav.SinavID = Convert.ToInt32(Dtr[0]);
                sinav.SoruSayisi = Convert.ToInt32(Dtr[1]);
                sinav.Sinif = Convert.ToInt32(Dtr[2]);
                sinav.Ders = Dtr[3].ToString();
                if(Dtr[4].ToString()=="False")
                {
                    sinav.sinavDet.Durum = "Çözülmedi";
                }
                else
                {
                    sinav.sinavDet.Durum = "Çözüldü";
                }
                sinav.sinavDet.Dogru = Convert.ToInt32(Dtr[5]);
                sinav.sinavDet.Yanliş = Convert.ToInt32(Dtr[6]);
                sinav.sinavDet.Bos = Convert.ToInt32(Dtr[7]);
                Sinavlar.Add(sinav);
            }
        }
    }
}
