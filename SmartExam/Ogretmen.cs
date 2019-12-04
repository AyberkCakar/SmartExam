using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace SmartExam
{
    public class Ogretmen : Kisi, ISoru, IDers, IKonu
    {
        public string kullaniciAdi;
        public string Telefon { get; set; }
        public string Brans { get; set; }
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

        public override void KisiEkle()
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
        }

        // Öğretmen Bilgilerini Getirme

        public override void KisiBilgiGetir(string kullaniciAdi)
        {
            SqlCommand OgretmenBilgiGetir = new SqlCommand("Select OgretmenID,OgrtAD,OgrtSoyad,OgrtTC,OgrtCinsiyet,OgrtDogTarih,OgrtTelefon,OgrtResim,d.DersAD,KullaniciAdi,Sifre From Tbl_Ogretmen O Inner Join Tbl_Ders D on d.DersID = O.DersID where KullaniciAdi= @p1", connect.baglanti());
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
                Brans = dr[8].ToString();
                KullanıcıID = dr[9].ToString();
                Sifre = dr[10].ToString();
            }
            connect.baglanti().Close();
        }

        // Öğretmen Bilgi Güncelleme

        public override void KisiBilgiGuncelle(int DersID)
        {
            SqlCommand OgrtBilgiGuncelle = new SqlCommand("update Tbl_Ogretmen set Sifre =@a2, OgrtResim = @a3, DersID = @a4, OgrtTelefon = @a5 where OgretmenID =@a1", connect.baglanti());
            OgrtBilgiGuncelle.Parameters.AddWithValue("@a1", ID);
            OgrtBilgiGuncelle.Parameters.AddWithValue("@a2", Sifre);
            OgrtBilgiGuncelle.Parameters.AddWithValue("@a3", Resim);
            OgrtBilgiGuncelle.Parameters.AddWithValue("@a4", DersID);
            OgrtBilgiGuncelle.Parameters.AddWithValue("@a5", Telefon);
            OgrtBilgiGuncelle.ExecuteNonQuery();
            connect.baglanti().Close();
        }

        //
        // Soru İşlemleri
        //

        // Soru Ekleme

        public void SoruEkle(Soru soru, int DersID, int KonuID, int OgretmenID)
        {
            SqlCommand soruEkle = new SqlCommand("insert into Tbl_Soru(Soru,A,B,C,D,E,Cevap,Resim,Sınıf,DersID,KonuID,OgretmenID) values(@a1, @a2, @a3, @a4, @a5, @a6,@a7,@a8,@a9,@a10,@a11,@a12)", connect.baglanti());
            soruEkle.Parameters.AddWithValue("@a1", soru.SoruIcerik);
            soruEkle.Parameters.AddWithValue("@a2", soru.ACevabi);
            soruEkle.Parameters.AddWithValue("@a3", soru.BCevabi);
            soruEkle.Parameters.AddWithValue("@a4", soru.CCevabi);
            soruEkle.Parameters.AddWithValue("@a5", soru.DCevabi);
            soruEkle.Parameters.AddWithValue("@a6", soru.ECevabi);
            soruEkle.Parameters.AddWithValue("@a7", soru.Cevap);
            soruEkle.Parameters.AddWithValue("@a8", soru.Resim);
            soruEkle.Parameters.AddWithValue("@a9", soru.Sinif);
            soruEkle.Parameters.AddWithValue("@a10", DersID);
            soruEkle.Parameters.AddWithValue("@a11", KonuID);
            soruEkle.Parameters.AddWithValue("@a12", OgretmenID);
            soruEkle.ExecuteNonQuery();
            connect.baglanti().Close();
        }

        // Soru Güncelleme

        public void SoruGuncelle(Soru soru, int DersID, int KonuID)
        {
            SqlCommand soruGuncelle = new SqlCommand("update Tbl_Soru set Soru = @a2, A = @3, B = @a4, C = @a5, D = @a6, E = @7, Cevap = @8, Resim =@a9, Sınıf =@a10, DersID = @a11, KonuID = @12 where SoruID=@a1 ", connect.baglanti());
            soruGuncelle.Parameters.AddWithValue("@a1", soru.SoruID);
            soruGuncelle.Parameters.AddWithValue("@a2", soru.SoruIcerik);
            soruGuncelle.Parameters.AddWithValue("@a3", soru.ACevabi);
            soruGuncelle.Parameters.AddWithValue("@a4", soru.BCevabi);
            soruGuncelle.Parameters.AddWithValue("@a5", soru.CCevabi);
            soruGuncelle.Parameters.AddWithValue("@a6", soru.DCevabi);
            soruGuncelle.Parameters.AddWithValue("@a7", soru.ECevabi);
            soruGuncelle.Parameters.AddWithValue("@a8", soru.Cevap);
            soruGuncelle.Parameters.AddWithValue("@a9", soru.Resim);
            soruGuncelle.Parameters.AddWithValue("@a10", soru.Sinif);
            soruGuncelle.Parameters.AddWithValue("@a11", DersID);
            soruGuncelle.Parameters.AddWithValue("@a12", KonuID);
            soruGuncelle.ExecuteNonQuery();
            connect.baglanti().Close();
        }

        // Soru Silme

        public void SoruSil(Soru soru)
        {
            SqlCommand soruSil = new SqlCommand("Delete Tbl_Soru  where SoruID=@a1 ", connect.baglanti());
            soruSil.Parameters.AddWithValue("@a1", soru.SoruID);
            soruSil.ExecuteNonQuery();
            connect.baglanti().Close();
        }


        //
        // Ders işlemleri
        //

        // Ders Ekleme
        public void DersEkle(Ders ders)
        {
            SqlCommand dersEkle = new SqlCommand("insert into Tbl_Ders(DersAD) values(@a1)", connect.baglanti());
            dersEkle.Parameters.AddWithValue("@a1", ders.DersAD);
            dersEkle.ExecuteNonQuery();
            connect.baglanti().Close();
        }

        // Ders Güncelleme

        public void DersGuncelle(Ders ders)
        {
            SqlCommand dersGuncelle = new SqlCommand("update Tbl_Ders set DersAD =@a2 where DersID =@a1", connect.baglanti());
            dersGuncelle.Parameters.AddWithValue("@a1", ders.DersID);
            dersGuncelle.Parameters.AddWithValue("@a2", ders.DersAD);
            dersGuncelle.ExecuteNonQuery();
            connect.baglanti().Close();
        }

        // 
        // Konu İşlemleri
        //

        // Konu Ekleme

        public void KonuEkle(Konu konu, int DersID)
        {
            SqlCommand konuEkle = new SqlCommand("insert into Tbl_Konu(KonuAD,DersID) values(@a1, @a2)", connect.baglanti());
            konuEkle.Parameters.AddWithValue("@a1", konu.KonuAD);
            konuEkle.Parameters.AddWithValue("@a2", DersID);
            konuEkle.ExecuteNonQuery();
            connect.baglanti().Close();
        }

        // Konu Güncelleme

        public void KonuGuncelle(Konu konu, int DersID)
        {
            SqlCommand konuGuncelle = new SqlCommand("update Tbl_Konu set KonuAD = @2, DersID = @3  where KonuID =@a1", connect.baglanti());
            konuGuncelle.Parameters.AddWithValue("@a1", konu.KonuID);
            konuGuncelle.Parameters.AddWithValue("@a2", konu.KonuAD);
            konuGuncelle.Parameters.AddWithValue("@a3", DersID);
            konuGuncelle.ExecuteNonQuery();
            connect.baglanti().Close();
        }

        // Derse Göre Konu Getirme

        int konuSayisi = 0;
        public int DersKonuGetir(Konu konu, int DersID)
        {
            SqlCommand dersKonuGetir = new SqlCommand("select KonuID,KonuAD from Tbl_Konu where DersID = @p1", connect.baglanti());
            dersKonuGetir.Parameters.AddWithValue("@p1", DersID);
            SqlDataReader dataReaderKonuDers = dersKonuGetir.ExecuteReader();
            while (dataReaderKonuDers.Read())
            {
                konuSayisi++;
                Konu dersKonu = new Konu();
                dersKonu.KonuID = Convert.ToInt32(dataReaderKonuDers[0]);
                dersKonu.KonuAD = dataReaderKonuDers[1].ToString();
                konu.DersKonusu.Add(dersKonu);
            }
            connect.baglanti().Close();
            return konuSayisi;

        }
    }
}
