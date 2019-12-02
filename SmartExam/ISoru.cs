using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartExam
{
    public interface ISoru
    {
        void SoruEkle(Soru soru, int DersID, int KonuID, int OgretmenID);
        void SoruGuncelle(Soru soru, int DersID, int KonuID);
        void SoruSil(Soru soru);
    }
}
