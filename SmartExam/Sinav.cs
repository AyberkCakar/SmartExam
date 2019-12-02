using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace SmartExam
{
    public class Sinav
    {
        public int SinavID { get; set; }
        public int Sinif { get; set; }
        public string DersAD { get; set; }
        public int DersID { get; set; }

        public List<Sinav> Sinavlar = new List<Sinav>();
        public SinavDetay sinavDet = new SinavDetay();
    }
}
