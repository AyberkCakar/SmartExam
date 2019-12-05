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
            SqlCommand konuGetir = new SqlCommand("select KonuID,KonuAD,De.DersAD from Tbl_Konu Ko inner join Tbl_Ders De on De.DersID = Ko.DersID", connect.baglanti());
            SqlDataReader Dtr = konuGetir.ExecuteReader();
            while (Dtr.Read())
            {
                Konu konu = new Konu();
                konu.KonuID = Convert.ToInt32(Dtr[0]);
                konu.KonuAD = Dtr[1].ToString();
                konu.DersAD = Dtr[2].ToString();
                Konular.Add(konu);
            }
            connect.baglanti().Close();
        }

    }
}
