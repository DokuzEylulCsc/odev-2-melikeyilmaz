using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MelikeYilmazOdev2.Models
{
    public class MasterDegree : Student // Yüksek Lisans
    {
        public MasterDegree(string ad, string soyad, string bolum, int id) : base(ad, soyad, bolum, id)
        {

        }
    }
}
