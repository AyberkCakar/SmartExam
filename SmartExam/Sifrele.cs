using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartExam
{
    public class Sifrele
    {
        private string sifre;
        public string SifreOlustur(string anaMetin)
        {
            byte[] veriDizim = ASCIIEncoding.ASCII.GetBytes(anaMetin);
            sifre = Convert.ToBase64String(veriDizim);
            return sifre;
        }
    }
}
