using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartExam
{
    public interface ISoru
    {
        void SoruEkle(Soru soru);
        void SoruGuncelle(Soru soru);
        void SoruSil(Soru soru);
    }
}
