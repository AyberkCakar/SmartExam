using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartExam
{
    public interface ISinavYap
    {
        int SinavSoruBilgileriniGetir(SinavYap sinav,int ders,int sorusay);
        void SinavCozulenSoruKaydet(SinavYap sinavYap);

    }
}
