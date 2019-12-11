using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace SmartExam
{
    public class Ogretmen : Kisi,ISoru
    {
        public string kullaniciAdi;
        public string Telefon { get; set; }
        public Ogretmen(string KullaniciAdi)
        {
            this.kullaniciAdi = KullaniciAdi;
        }

        public Ogretmen()
        {
        }

        sqlBaglanti connect = new sqlBaglanti();

        //
        // Öğretmen Bilgi İşlemleri
        //

        // Yeni Öğretmen Kaydı
        
        public override bool KisiEkle()
        {
            bool varYokDurum;
            try
            {
                SqlCommand ogrtEkle = new SqlCommand("insert into Tbl_Ogretmen (OgrtAD,OgrtSoyad,OgrtTC,OgrtCinsiyet,OgrtDogTarih,OgrtTelefon,KullaniciAdi,Sifre) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8)", connect.baglanti());
                ogrtEkle.Parameters.AddWithValue("@p1", Ad);
                ogrtEkle.Parameters.AddWithValue("@p2", Soyad);
                ogrtEkle.Parameters.AddWithValue("@p3", TC);
                ogrtEkle.Parameters.AddWithValue("@p4", Cinsiyet);
                ogrtEkle.Parameters.AddWithValue("@p5", DogumTarihi);
                ogrtEkle.Parameters.AddWithValue("@p6", Telefon);
                ogrtEkle.Parameters.AddWithValue("@p7", KullanıcıID);
                ogrtEkle.Parameters.AddWithValue("@p8", Sifre);
                ogrtEkle.ExecuteNonQuery();
                connect.baglanti().Close();
                varYokDurum = false;
            }
            catch (Exception)
            {
                varYokDurum = true;
            }
            return varYokDurum;
          
        }

        // Öğretmen Bilgilerini Getirme

        public override void KisiBilgiGetir(string kullaniciAdi)
        {
            SqlCommand OgretmenBilgiGetir = new SqlCommand("Select OgretmenID,OgrtAD,OgrtSoyad,OgrtTC,OgrtCinsiyet,OgrtDogTarih,OgrtTelefon,OgrtResim,KullaniciAdi,Sifre From Tbl_Ogretmen  where KullaniciAdi= @p1", connect.baglanti());
            OgretmenBilgiGetir.Parameters.AddWithValue("@p1", kullaniciAdi);
            SqlDataReader dr = OgretmenBilgiGetir.ExecuteReader();
            if (dr.Read())
            {
                ID = Convert.ToInt32(dr[0].ToString());
                Ad = dr[1].ToString();
                Soyad = dr[2].ToString();
                TC = dr[3].ToString();
                Cinsiyet = Convert.ToBoolean(dr[4]);
                DogumTarihi = Convert.ToDateTime(dr[5]);
                Telefon = dr[6].ToString();
                Resim = dr[7].ToString();
                KullanıcıID = dr[8].ToString();
                Sifre = dr[9].ToString();
            }
            connect.baglanti().Close();
        }

        // Öğretmen Bilgi Güncelleme

        public override void KisiBilgiGuncelle(int DersID)
        {
            SqlCommand OgrtBilgiGuncelle = new SqlCommand("update Tbl_Ogretmen set Sifre =@a2, OgrtResim = @a3, OgrtTelefon = @a4 where OgretmenID =@a1", connect.baglanti());
            OgrtBilgiGuncelle.Parameters.AddWithValue("@a1", ID);
            OgrtBilgiGuncelle.Parameters.AddWithValue("@a2", Sifre);
            OgrtBilgiGuncelle.Parameters.AddWithValue("@a3", Resim);
            OgrtBilgiGuncelle.Parameters.AddWithValue("@a4", Telefon);
            OgrtBilgiGuncelle.ExecuteNonQuery();
            connect.baglanti().Close();
        }

        //
        // Soru İşlemleri
        //

        // Soru Ekleme

        public void SoruEkle(Soru soru, int DersID, int KonuID, int OgretmenID)
        {
            SqlCommand soruEkle = new SqlCommand("insert into Tbl_Soru(Soru,Resim,DersID,KonuID,OgretmenID) values(@a1,@a8,@a9,@a10,@a11) DECLARE @SoruID int Set @SoruID =SCOPE_IDENTITY() insert into Tbl_Cevap(A,B,C,D,E,Cevap,SoruID) values (@a2, @a3, @a4, @a5, @a6,@a7,@SoruID)", connect.baglanti());
            soruEkle.Parameters.AddWithValue("@a1", soru.SoruIcerik);
            soruEkle.Parameters.AddWithValue("@a2", soru.ACevabi);
            soruEkle.Parameters.AddWithValue("@a3", soru.BCevabi);
            soruEkle.Parameters.AddWithValue("@a4", soru.CCevabi);
            soruEkle.Parameters.AddWithValue("@a5", soru.DCevabi);
            soruEkle.Parameters.AddWithValue("@a6", soru.ECevabi);
            soruEkle.Parameters.AddWithValue("@a7", soru.Cevap);
            soruEkle.Parameters.AddWithValue("@a8", soru.Resim);
            soruEkle.Parameters.AddWithValue("@a9", DersID);
            soruEkle.Parameters.AddWithValue("@a10", KonuID);
            soruEkle.Parameters.AddWithValue("@a11", OgretmenID);
            soruEkle.ExecuteNonQuery();
            connect.baglanti().Close();
        }

        // Soru Güncelleme

        public void SoruGuncelle(Soru soru, int DersID, int KonuID)
        {
            SqlCommand soruGuncelle = new SqlCommand("update Tbl_Soru set Soru = @a2, Resim =@a9,  DersID = @a11, KonuID = @a12 where SoruID=@a1 ", connect.baglanti());
            soruGuncelle.Parameters.AddWithValue("@a1", soru.SoruID);
            soruGuncelle.Parameters.AddWithValue("@a2", soru.SoruIcerik);
            soruGuncelle.Parameters.AddWithValue("@a9", soru.Resim);
            soruGuncelle.Parameters.AddWithValue("@a11", DersID);
            soruGuncelle.Parameters.AddWithValue("@a12", KonuID);
            soruGuncelle.ExecuteNonQuery();
            connect.baglanti().Close();
            SqlCommand cevapGuncelle = new SqlCommand("update Tbl_Cevap set  A = @a3, B = @a4, C = @a5, D = @a6, E = @a7, Cevap = @a8  where SoruID=@a1 ", connect.baglanti());
            cevapGuncelle.Parameters.AddWithValue("@a1", soru.SoruID);
            cevapGuncelle.Parameters.AddWithValue("@a3", soru.ACevabi);
            cevapGuncelle.Parameters.AddWithValue("@a4", soru.BCevabi);
            cevapGuncelle.Parameters.AddWithValue("@a5", soru.CCevabi);
            cevapGuncelle.Parameters.AddWithValue("@a6", soru.DCevabi);
            cevapGuncelle.Parameters.AddWithValue("@a7", soru.ECevabi);
            cevapGuncelle.Parameters.AddWithValue("@a8", soru.Cevap);
            cevapGuncelle.ExecuteNonQuery();
            connect.baglanti().Close();
        }

        // Soru Silme

        public void SoruSil(Soru soru)
        {
            SqlCommand soruSil = new SqlCommand("Delete Tbl_Soru  where SoruID=@a1 ", connect.baglanti());
            soruSil.Parameters.AddWithValue("@a1", soru.SoruID);
            soruSil.ExecuteNonQuery();
            connect.baglanti().Close();
            SqlCommand cevapSil = new SqlCommand("Delete Tbl_Cevap  where SoruID=@a1 ", connect.baglanti());
            cevapSil.Parameters.AddWithValue("@a1", soru.SoruID);
            cevapSil.ExecuteNonQuery();
            connect.baglanti().Close();
        }
    }
}
