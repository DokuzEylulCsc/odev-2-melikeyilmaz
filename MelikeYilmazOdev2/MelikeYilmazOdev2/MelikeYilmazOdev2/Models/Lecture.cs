using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MelikeYilmazOdev2.Models
{
    public class Lecture 
    {
        //public Lecture()
        //{

        //}
        //public string Name { get; set; }
        //public int DepartmentId { get; set; }

        private int ders_id;//field

        public int Ders_id //encapsulation
        {
            get { return ders_id; }
            set { ders_id = value; }
        }

        private string ders_ad;//field
        private string ders_adi;//field

        public string Ders_ad //encapsulation
        {
            get { return ders_ad; }
            set { ders_ad = value; }
        }


        public Lecture(int ders_Id,string ders_adi)//Sınıfımızla aynı adı taşıyan constructor(yapıcı) method.
        {
            Ders_id = ders_Id;
            Ders_ad = ders_adi;
        }

        public Lecture(string ders_adi)//Sınıfımızla aynı adı taşıyan constructor(yapıcı) method.
        {
            
        }
    }
}
