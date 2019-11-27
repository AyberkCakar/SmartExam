using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace SmartExam
{
    public class Ogrenci : Kisi,ISinavYap,ISinav
    {
        public string kullaniciAdi;
        public int Sınıf { get; set; }
        public char Sube { get; set; }
        public Ogrenci(string KullaniciAdi)
        {
            this.kullaniciAdi = KullaniciAdi;
        }

        public Ogrenci()
        {

        }

        sqlBaglanti connect = new sqlBaglanti();

        int sayac=0;
        public int SinavSoruBilgileriniGetir(SinavYap sinavYap,int Ders, int Sinif)
        {
            SqlCommand select = new SqlCommand("Select Top 10 * from Tbl_Soru  where Sınıf = @p2 and DersID = @p3  and SoruID not in  (Select SoruID from Tbl_CozulmusSoru where DogruYanlis = 1) ORDER BY NEWID()", connect.baglanti());
            select.Parameters.AddWithValue("@p2", Sinif);
            select.Parameters.AddWithValue("@p3", Ders);
            SqlDataReader Dtr = select.ExecuteReader();
            while (Dtr.Read())
            {
                sayac++;
                SinavYap sinav = new SinavYap();
                sinav.SoruID = Convert.ToInt32(Dtr[0]);
                sinav.SoruIcerik = Dtr[1].ToString();
                sinav.ACevabi = Dtr[2].ToString();
                sinav.BCevabi = Dtr[3].ToString();
                sinav.CCevabi = Dtr[4].ToString();
                sinav.DCevabi = Dtr[5].ToString();
                sinav.ECevabi = Dtr[6].ToString();
                sinav.Cevap = Dtr[7].ToString();
                sinav.Resim = Dtr[8].ToString();
                sinav.KonuID = Convert.ToInt32(Dtr[11]);
                sinavYap.sinavYaps.Add(sinav);
            }
            return sayac;
        }

        public void SinavCozulenSoruKaydet(SinavYap sinav)
        {
            foreach(SinavYap sinavYap in sinav.sinavKaydet)
            {
                SqlCommand insert = new SqlCommand("insert into Tbl_CozulmusSoru (DogruYanlis,KonuID,OgrenciID,SoruID ) values (@p1,@p2,@p3,@p4)", connect.baglanti());
                insert.Parameters.AddWithValue("@p1", sinavYap.dogruYanlıs);
                insert.Parameters.AddWithValue("@p2", sinavYap.KonuID);
                insert.Parameters.AddWithValue("@p3", 1);
                insert.Parameters.AddWithValue("@p4", sinavYap.SoruID);
                insert.ExecuteNonQuery();
                connect.baglanti().Close();
            }
        }
        public void SinavBilgileriniGetir(Sinav Sinavlar)
        {
            SqlCommand select = new SqlCommand("select S.SınavID,Sınıf,D.DersID,DersAD,S.Dogru,S.Yanlış,S.Bos,S.Tarih from Tbl_Sınav S inner join Tbl_Ders D on D.DersID = S.DersID", connect.baglanti());
            //select.Parameters.AddWithValue("@p1", OgrenciID); where sd.OgrenciID = @p1 int OgrenciID
            SqlDataReader Dtr = select.ExecuteReader();
            while (Dtr.Read())
            {
                Sinav sinav = new Sinav();
                sinav.SinavID = Convert.ToInt32(Dtr[0]);
                sinav.Sinif = Convert.ToInt32(Dtr[1]);
                sinav.DersID = Convert.ToInt32(Dtr[2]);
                sinav.DersAD = Dtr[3].ToString();
                sinav.sinavDet.Dogru = Convert.ToInt32(Dtr[4]);
                sinav.sinavDet.Yanliş = Convert.ToInt32(Dtr[5]);
                sinav.sinavDet.Bos = Convert.ToInt32(Dtr[6]);
                sinav.sinavDet.Tarih = Convert.ToDateTime(Dtr[7]);
                Sinavlar.Sinavlar.Add(sinav);
            }
        }
        public void SinavCozulenKaydet(Sinav sinav,int Dogru,int Yanlis,int Bos)
        {
            SqlCommand insertSinav = new SqlCommand("insert into Tbl_Sınav (Sınıf,DersID,Dogru,Yanlış,Bos,Tarih,OgrenciID) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7)", connect.baglanti());
            insertSinav.Parameters.AddWithValue("@p1", sinav.Sinif);
            insertSinav.Parameters.AddWithValue("@p2", sinav.DersID);
            insertSinav.Parameters.AddWithValue("@p3", Dogru);
            insertSinav.Parameters.AddWithValue("@p4", Yanlis);
            insertSinav.Parameters.AddWithValue("@p5", Bos);
            insertSinav.Parameters.AddWithValue("@p6", DateTime.Now);
            insertSinav.Parameters.AddWithValue("@p7", 1);
            insertSinav.ExecuteNonQuery();
            connect.baglanti().Close();
        }
    }
}
