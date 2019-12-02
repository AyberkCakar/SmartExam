using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace SmartExam
{
    public class Ogrenci : Kisi,ISinavYap,ISinav,IIstatistik
    {
        public string kullaniciAdi;
        public Ogrenci(string KullaniciAdi)
        {
            this.kullaniciAdi = KullaniciAdi;
        }

        public Ogrenci()
        {

        }

        sqlBaglanti connect = new sqlBaglanti();

        //
        // Sınavın Soru İşlemleri
        //

        // Sorulari Getirme İşlemleri

        int soruSayisi = 0; // Yeterli Soru Var mı Yok mu Kontrolü İçin
        public int SinavinSorulariniGetir(SinavYap sinavYap, int Ders, int Sinif, int ogrenciID)
        {
            SqlCommand soruGetir = new SqlCommand("Select Top 10 * from Tbl_Soru  where Sınıf = @p2 and DersID = @p3  and SoruID not in  (Select SoruID from Tbl_CozulmusSoru where DogruYanlis = 1 and OgrenciID = @p1 ) ORDER BY NEWID()", connect.baglanti());
            soruGetir.Parameters.AddWithValue("@p1", ogrenciID);
            soruGetir.Parameters.AddWithValue("@p2", Sinif);
            soruGetir.Parameters.AddWithValue("@p3", Ders);
            SqlDataReader dtSoru = soruGetir.ExecuteReader();
            while (dtSoru.Read())
            {
                soruSayisi++;
                SinavYap sinav = new SinavYap();
                sinav.SoruID = Convert.ToInt32(dtSoru[0]);
                sinav.SoruIcerik = dtSoru[1].ToString();
                sinav.ACevabi = dtSoru[2].ToString();
                sinav.BCevabi = dtSoru[3].ToString();
                sinav.CCevabi = dtSoru[4].ToString();
                sinav.DCevabi = dtSoru[5].ToString();
                sinav.ECevabi = dtSoru[6].ToString();
                sinav.Cevap = dtSoru[7].ToString();
                sinav.Resim = dtSoru[8].ToString();
                sinav.KonuID = Convert.ToInt32(dtSoru[11]);
                sinavYap.sinavYaps.Add(sinav);
            }
            return soruSayisi;
        }

        // Çözülen Soru Bilgilerini Kaydetme İşlemleri

        public void SinavCozulenSoruKaydet(SinavYap sinav, int ogrenciID)
        {
            foreach (SinavYap sinavYap in sinav.sinavKaydet)
            {
                SqlCommand cozulenSoruKaydet = new SqlCommand("insert into Tbl_CozulmusSoru (DogruYanlis,KonuID,OgrenciID,SoruID ) values (@p1,@p2,@p3,@p4)", connect.baglanti());
                cozulenSoruKaydet.Parameters.AddWithValue("@p1", sinavYap.dogruYanlıs);
                cozulenSoruKaydet.Parameters.AddWithValue("@p2", sinavYap.KonuID);
                cozulenSoruKaydet.Parameters.AddWithValue("@p3", ogrenciID);
                cozulenSoruKaydet.Parameters.AddWithValue("@p4", sinavYap.SoruID);
                cozulenSoruKaydet.ExecuteNonQuery();
                connect.baglanti().Close();
            }
        }


        //
        // Sınav İşlemleri
        //

        // Sımav Bilgilerini Getir

        public void SinavBilgileriniGetir(Sinav Sinavlar, int ogrID)
        {
            SqlCommand select = new SqlCommand("select S.SınavID,Sınıf,D.DersID,DersAD,S.Dogru,S.Yanlış,S.Bos,S.Tarih from Tbl_Sınav S inner join Tbl_Ders D on D.DersID = S.DersID where s.OgrenciID = @p1", connect.baglanti());
            select.Parameters.AddWithValue("@p1", ogrID);
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
        
        // Sınav Bittiğinde Sınav Bilgilerini Kaydet

        public void CozulenSinavKaydet(Sinav sinav, int Dogru, int Yanlis, int Bos, int OgrenciID)
        {
            SqlCommand insertSinav = new SqlCommand("insert into Tbl_Sınav (Sınıf,DersID,Dogru,Yanlış,Bos,Tarih,OgrenciID) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7)", connect.baglanti());
            insertSinav.Parameters.AddWithValue("@p1", sinav.Sinif);
            insertSinav.Parameters.AddWithValue("@p2", sinav.DersID);
            insertSinav.Parameters.AddWithValue("@p3", Dogru);
            insertSinav.Parameters.AddWithValue("@p4", Yanlis);
            insertSinav.Parameters.AddWithValue("@p5", Bos);
            insertSinav.Parameters.AddWithValue("@p6", DateTime.Now);
            insertSinav.Parameters.AddWithValue("@p7", OgrenciID);
            insertSinav.ExecuteNonQuery();
            connect.baglanti().Close();
        }

        //
        // Öğrenci Bilgi İşlemleri
        //

        // Yeni Öğrenci Ekle

        public override void KisiEkle()
        {
            throw new NotImplementedException();
        }

        // Öğrenci Bilgilerini Getir

        public override void KisiBilgiGetir(string kullaniciAdi)
        {
            throw new NotImplementedException();
        }

        // Öğrenci Bilgileri Güncelle

        public override void KisiBilgiGuncelle(int DersID)
        {
            throw new NotImplementedException();
        }


        //
        // İstatistik İşlemleri
        //


        public void IstatistikGetir(Istatistik Istatistik, int DersID, int OgrenciID)
        {
            // Doğru Cevapların İstatistiği

            SqlCommand istatistikGetirDogru = new SqlCommand("select (select Count(*)from Tbl_CozulmusSoru where Tbl_CozulmusSoru.KonuID = Tbl_Konu.KonuID and OgrenciID = @p2 and DogruYanlis=1),KonuAD from Tbl_Konu  where  DersID =  @p1 ", connect.baglanti());
            istatistikGetirDogru.Parameters.AddWithValue("@p1", DersID);
            istatistikGetirDogru.Parameters.AddWithValue("@p2", OgrenciID);
            SqlDataReader dtIstatistikDogru = istatistikGetirDogru.ExecuteReader();
            while (dtIstatistikDogru.Read())
            {
                Istatistik istatistiks = new Istatistik();
                istatistiks.Adet = Convert.ToInt32(dtIstatistikDogru[0]);
                istatistiks.Konu = dtIstatistikDogru[1].ToString();
                Istatistik.IstatistiklerDogru.Add(istatistiks);
            }

            // Yanlış Cevapların İstatistiği

            SqlCommand istatistikGetirYanlis = new SqlCommand("select (select Count(*)from Tbl_CozulmusSoru where Tbl_CozulmusSoru.KonuID = Tbl_Konu.KonuID and OgrenciID = @p2 and DogruYanlis=0),KonuAD from Tbl_Konu  where  DersID =  @p1 ", connect.baglanti());
            istatistikGetirYanlis.Parameters.AddWithValue("@p1", DersID);
            istatistikGetirYanlis.Parameters.AddWithValue("@p2", OgrenciID);
            SqlDataReader dtIstatistikYanlis = istatistikGetirYanlis.ExecuteReader();
            while (dtIstatistikYanlis.Read())
            {
                Istatistik istatistiks = new Istatistik();
                istatistiks.Adet = Convert.ToInt32(dtIstatistikYanlis[0]);
                istatistiks.Konu = dtIstatistikYanlis[1].ToString();
                Istatistik.IstatistiklerYanlis.Add(istatistiks);
            }
        }

    }
}
