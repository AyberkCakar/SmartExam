using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartExam
{
    public interface ISinav
    {
        void SinavaGir(Sinav sinav);
        void SinavOluştur(Sinav sinav,Soru soru);
    }
}
