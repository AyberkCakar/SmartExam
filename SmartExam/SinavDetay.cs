using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartExam
{
    public class SinavDetay
    {
        public int SinavDetayID { get; set; }
        public DateTime Tarih { get; set; }
        public int Dogru { get; set; }
        public int Yanliş { get; set; }
        public int Bos { get; set; }
    }
}
