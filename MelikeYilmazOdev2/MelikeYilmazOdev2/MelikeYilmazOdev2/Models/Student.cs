using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MelikeYilmazOdev2.Models
{
    public abstract class Student 
    {
        //public int Id { get; set; }
        private int ogrenci_id;//field
        private string ogrenci_ad;//field
        private string ogrenci_soyad;//field
        private string ogrenci_bolum;//field
        private string ad; //field
        private string soyad; //field
        private string bolum;//field
        private int id;//field

        public string Ogrenci_bolum //encapsulation
        {
            get { return ogrenci_bolum; }
            set { ogrenci_bolum = value; }
        }


        public string Ogrenci_soyad //encapsulation
        {
            get { return ogrenci_soyad; }
            set { ogrenci_soyad = value; }
        }


        public string Ogrenci_ad //encapsulation
        {
            get { return ogrenci_ad; }
            set { ogrenci_ad = value; }
        }


        public int Ogrenci_id//encapsulation
        {
            get { return ogrenci_id; }
            set { ogrenci_id = value; }
        }

        //public Student(int ogr_id, string ogr_ad, string ogr_soyad, string ogr_bolum)
        //{
        //    ogrenci_id = ogr_id;
        //    ogrenci_ad = ogr_ad;
        //    ogrenci_soyad = ogr_soyad;
        //    ogrenci_bolum = ogr_bolum;
        //}

        protected Student(string ad, string soyad, string bolum, int id) //Sınıfımızla aynı adı taşıyan constructor(yapıcı) method.
        {
            this.ad = ad;
            this.soyad = soyad;
            this.bolum = bolum;
            this.id = id;
        }
    }


}
