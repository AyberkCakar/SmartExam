using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartExam
{
    public interface ISinavYap
    {
        int SinavinSorulariniGetir(SinavYap sinav,int ders,int sorusay,int ogrenciID);
        void SinavCozulenSoruKaydet(SinavYap sinavYap , int ogrenciID);
    }
}
