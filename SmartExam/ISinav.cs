using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartExam
{
    public interface ISinav
    {
        void SinavBilgileriniGetir(Sinav sinav, int ogrID);
        void CozulenSinavKaydet(Sinav sinav, int Dogru, int Yanlis, int Bos, int OgrenciID);
    }
}
