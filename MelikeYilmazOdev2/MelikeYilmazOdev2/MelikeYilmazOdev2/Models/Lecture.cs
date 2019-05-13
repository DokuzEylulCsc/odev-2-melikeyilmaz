using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MelikeYilmazOdev2.Models
{
    public class Lecture 
    {
        //public Lecture()...
        //{

        //}
        //public string Name { get; set; }
        //public int DepartmentId { get; set; }

        private int ders_id;

        public int Ders_id
        {
            get { return ders_id; }
            set { ders_id = value; }
        }

        private string ders_ad;
        private string ders_adi;

        public string Ders_ad
        {
            get { return ders_ad; }
            set { ders_ad = value; }
        }


        public Lecture(int ders_Id,string ders_adi, string instroctur_soyad)
        {
            ders_id = ders_Id;
            ders_ad = ders_adi;
        }

        public Lecture(string ders_adi)
        {
            this.ders_adi = ders_adi;
        }
    }
}
