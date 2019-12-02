using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace SmartExam
{
    public class Istatistik
    {
        public int Adet { get; set; }
        public string Konu { get; set; }

        public List<Istatistik> IstatistiklerDogru = new List<Istatistik>();
        public List<Istatistik> IstatistiklerYanlis = new List<Istatistik>();
    }
}
