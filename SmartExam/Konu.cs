using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartExam
{
    public class Konu
    {
        public int KonuID { get; set; }
        public string DersAD { get; set; }
        public string KonuAD { get; set; }

        public List<Konu> IkinciSinavKonu = new List<Konu>();
        public List<Konu> IlkSinavKonu = new List<Konu>();
    }
}
