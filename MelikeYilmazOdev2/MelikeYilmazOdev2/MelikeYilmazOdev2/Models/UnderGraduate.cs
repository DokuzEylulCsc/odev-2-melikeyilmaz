using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MelikeYilmazOdev2.Models
{
    public class UnderGraduate : Student // Lisans
    {
        public UnderGraduate(string ad,string soyad,string bolum,int id) : base(ad, soyad, bolum, id)
        {
            /*Abstract class olduğu için ögrencinin constructor methodunu kullanir.Eğer constructor metod parametre aldıysa
            kalıtım alan  sınıfta kullanabilmek için base anahtar sözcüğünü kullanırız.
            Temel sınıfın yapıcı metoduna türetilmiş sınıf üzerinden parametre gönderebilmek için base anahtar sözcüğünü kullanırız.*/
        }
    }
}
