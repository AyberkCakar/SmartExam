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

        Konu konu = new Konu();
        sqlBaglanti connect = new sqlBaglanti();

        //
        // Sınavın Soru İşlemleri
        //

        // İlk Var Olan Konuları Getirme

        void IlkKonulariGetir (int Ders)
        {
            SqlCommand konuGetir = new SqlCommand("select *from Tbl_Konu where DersID = 1 order by KonuID asc", connect.baglanti());
            konuGetir.Parameters.AddWithValue("@p1", Ders);
            SqlDataReader dtKonu = konuGetir.ExecuteReader();
            while (dtKonu.Read())
            {
                Konu konular = new Konu();
                konular.KonuID = Convert.ToInt32(dtKonu[0]);
                konu.IlkSinavKonu.Add(konular);
            }
        }
        
        // Bilemediği Konuları Sıralı Bir Şekilde Bulma

        void IkinciKonulariGetir(int Ders,int ogrID)
        {
            SqlCommand konuIkinciGetir = new SqlCommand("select Top 4 (select Count(*)from Tbl_CozulmusSoru where Tbl_CozulmusSoru.KonuID = Tbl_Konu.KonuID and OgrenciID = @p2 and DogruYanlis=0) as 'Yanlış',KonuID from Tbl_Konu  where  DersID =  @p1  order by Yanlış desc ", connect.baglanti());
            konuIkinciGetir.Parameters.AddWithValue("@p1", Ders);
            konuIkinciGetir.Parameters.AddWithValue("@p2", ogrID);
            SqlDataReader dtKonu = konuIkinciGetir.ExecuteReader();
            while (dtKonu.Read())
            {
                Konu konular = new Konu();
                konular.KonuID = Convert.ToInt32(dtKonu[1]);
                konu.IkinciSinavKonu.Add(konular);
            }
        }

        // Her Sınav İçin Gelen Standart Konu Soruları

        int soruIlKisim(SinavYap sinavYap,int Ders,int TopSayisi)
        {
            IlkKonulariGetir(Ders);

            foreach (Konu sub in konu.IlkSinavKonu)
            {
                SqlCommand soruGetir = new SqlCommand("Select Top(@p3) So.SoruID,So.Soru,Ce.A,Ce.B,Ce.C,Ce.D,Ce.E,Ce.Cevap,So.Resim,So.KonuID from Tbl_Soru So inner join Tbl_Cevap Ce on so.SoruID = Ce.SoruID  where  DersID = @p1 and KonuID=@p2  ORDER BY NEWID()", connect.baglanti());
                soruGetir.Parameters.AddWithValue("@p1", Ders);
                soruGetir.Parameters.AddWithValue("@p2", sub.KonuID);
                soruGetir.Parameters.AddWithValue("@p3", TopSayisi);
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
                    sinav.KonuID = Convert.ToInt32(dtSoru[9]);
                    sinavYap.sinavYaps.Add(sinav);
                }
            }
            return soruSayisi;
        }

        // Bilemediği Konulardan Soru Getirme

        int soruIkinciKisim(SinavYap sinavYap, int Ders,int ogrenciID)
        {
            int TopSayisi =4;
            IkinciKonulariGetir(Ders, ogrenciID);
            foreach (Konu sub in konu.IkinciSinavKonu)
            {
                SqlCommand soruGetir = new SqlCommand("Select Top(@p3) So.SoruID,So.Soru,Ce.A,Ce.B,Ce.C,Ce.D,Ce.E,Ce.Cevap,So.Resim,So.KonuID from Tbl_Soru So inner join Tbl_Cevap Ce on so.SoruID = Ce.SoruID    where DersID = @p1  and KonuID= @p2 and So.SoruID not in  (Select SoruID from Tbl_CozulmusSoru where DogruYanlis = 1 and OgrenciID =@p4) ORDER BY NEWID() ", connect.baglanti());
                soruGetir.Parameters.AddWithValue("@p1", Ders);
                soruGetir.Parameters.AddWithValue("@p2", sub.KonuID);
                soruGetir.Parameters.AddWithValue("@p3",TopSayisi);
                soruGetir.Parameters.AddWithValue("@p4", ogrenciID);
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
                    sinav.KonuID = Convert.ToInt32(dtSoru[9]);
                    sinavYap.sinavYaps.Add(sinav);
                }
                TopSayisi--;
            }
            return soruSayisi;
        }

        int soruSayisi = 0; // Yeterli Soru Var mı Yok mu Kontrolü İçin
        public int SinavinSorulariniGetir(SinavYap sinavYap, int Ders, int ogrenciID, bool ogrenciDurum)
        {
            if (ogrenciDurum == false)
            {
                soruSayisi += soruIlKisim(sinavYap, Ders, 4);
                return soruSayisi;
            }
            else
            {
                // Standart Her Konudan Gelen Sorular
                soruSayisi += soruIlKisim(sinavYap, Ders, 2);
                // Gereken Diğer Kısmı Bilemediği Konular
                soruSayisi = soruIkinciKisim(sinavYap, Ders,ogrenciID);
                return soruSayisi;
            }
        }

        // Çözülen Soru Bilgilerini Kaydetme İşlemleri

        public void SinavCozulenSoruKaydet(SinavYap sinav, int ogrenciID,int sinavID)
        {
            foreach (SinavYap sinavYap in sinav.sinavKaydet)
            {
                SqlCommand cozulenSoruKaydet = new SqlCommand("insert into Tbl_CozulmusSoru (DogruYanlis,KonuID,OgrenciID,SoruID,SınavID ) values (@p1,@p2,@p3,@p4,@p5)", connect.baglanti());
                cozulenSoruKaydet.Parameters.AddWithValue("@p1", sinavYap.dogruYanlıs);
                cozulenSoruKaydet.Parameters.AddWithValue("@p2", sinavYap.KonuID);
                cozulenSoruKaydet.Parameters.AddWithValue("@p3", ogrenciID);
                cozulenSoruKaydet.Parameters.AddWithValue("@p4", sinavYap.SoruID);
                cozulenSoruKaydet.Parameters.AddWithValue("@p5", sinavID);
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

        // Son Sınav ID'sini Bulma
        int sonID;
        public int sonSinavID(int ogrID)
        {
            SqlCommand select = new SqlCommand("select SınavID from Tbl_Sınav where OgrenciID = @p1", connect.baglanti());
            select.Parameters.AddWithValue("@p1", ogrID);
            SqlDataReader Dtr = select.ExecuteReader();
            if (Dtr.Read())
            {
                sonID = Convert.ToInt32(Dtr[0]);
            }
            return sonID;
        }

        //
        // Öğrenci Bilgi İşlemleri
        //

        // Yeni Öğrenci Ekle

        public override bool KisiEkle()
        {
            bool varYokDurum;
            try
            {
                SqlCommand ogrEkle = new SqlCommand("insert into Tbl_Ogrenci (OgrAD,OgrSoyad,OgrTC,OgrCinsiyet,OgrDogumTarihi,KullaniciAdi,Sifre) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7)", connect.baglanti());
                ogrEkle.Parameters.AddWithValue("@p1", Ad);
                ogrEkle.Parameters.AddWithValue("@p2", Soyad);
                ogrEkle.Parameters.AddWithValue("@p3", TC);
                ogrEkle.Parameters.AddWithValue("@p4", Cinsiyet);
                ogrEkle.Parameters.AddWithValue("@p5", DogumTarihi);
                ogrEkle.Parameters.AddWithValue("@p6", KullanıcıID);
                ogrEkle.Parameters.AddWithValue("@p7", Sifre);
                ogrEkle.ExecuteNonQuery();
                connect.baglanti().Close();
                varYokDurum = false;
            }
            catch (Exception)
            {
                varYokDurum = true;
            }
            return varYokDurum;
        }

        // Öğrenci Bilgilerini Getir

        public override void KisiBilgiGetir(string kullaniciAdi)
        {
            SqlCommand OgrenciBilgiGetir = new SqlCommand("Select * From Tbl_Ogrenci where KullaniciAdi=@p1", connect.baglanti());
            OgrenciBilgiGetir.Parameters.AddWithValue("@p1", kullaniciAdi);
            SqlDataReader dr = OgrenciBilgiGetir.ExecuteReader();
            if (dr.Read())
            {
                ID = Convert.ToInt32(dr[0]);
                Ad = dr[1].ToString();
                Soyad = dr[2].ToString();
                TC = dr[3].ToString();
                Cinsiyet = Convert.ToBoolean(dr[4]);
                DogumTarihi = Convert.ToDateTime(dr[5]);
                Resim = dr[6].ToString();
                KullanıcıID = dr[7].ToString();
                Sifre = dr[8].ToString();
            }
            connect.baglanti().Close();
        }

        // Öğrenci Bilgileri Güncelle

        public override void KisiBilgiGuncelle(int DersID)
        {
            SqlCommand OgrBilgiGuncelle = new SqlCommand("update Tbl_Ogrenci set Sifre =@a2, OgrResim = @a3 where OgrenciID = @a1", connect.baglanti());
            OgrBilgiGuncelle.Parameters.AddWithValue("@a1", ID);
            OgrBilgiGuncelle.Parameters.AddWithValue("@a2", Sifre);
            OgrBilgiGuncelle.Parameters.AddWithValue("a3", Resim);
            OgrBilgiGuncelle.ExecuteNonQuery();
            connect.baglanti().Close();
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
