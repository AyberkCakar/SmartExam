using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartExam
{
    public interface IKonu
    {
        void KonuEkle(Konu konu ,int DersID);
        void KonuGuncelle(Konu konu, int DersID);
        int DersKonuGetir(Konu konu, int DersID);
    }
}
