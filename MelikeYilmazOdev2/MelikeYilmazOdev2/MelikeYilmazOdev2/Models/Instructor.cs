using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MelikeYilmazOdev2.Models
{
    class Instructor
    {
        public int ınstructor_id;//field
        public string ınstructor_name;//field
        public string ınstructor_lastname;//field
        private object ad;//field
        private object soyad;//field
        private object id;//field

        public List<Lecture> Lectures { get; set; } //Öğrenci listemiz.


        public int Instructor_id //encapsulation
        {
            get { return ınstructor_id; }
            set { ınstructor_id = value; }
        }

        public string Instructor_name //encapsulation
        {
            get { return ınstructor_name; }
            set { ınstructor_name = value; }
        }
        public string Instructor_lastname //encapsulation
        {
            get { return ınstructor_lastname; }
            set { ınstructor_lastname = value; }
        }

        public Instructor(int id,string ad,string soyad) //Sınıfımızla aynı adı taşıyan constructor(yapıcı) method.
        {
            Lectures = new List<Lecture>();
        }

        public Instructor(object ad, object soyad,object id) //Sınıfımızla aynı adı taşıyan constructor(yapıcı) method.
        {
            this.ad = ad;
            this.soyad = soyad;
            this.id = id;
        }

        public Instructor(int id) //Sınıfımızla aynı adı taşıyan constructor(yapıcı) method.
        {
            this.id = id;
        }

        public void Ogretim_Elemanına_Ders_Ekle(int instroctur_id, string instroctur_adi, string instroctur_soyad)
        {

            try
            {
                //Lecture ders = new Lecture(instroctur_id, instroctur_adi, instroctur_soyad);
                //Lectures.Add(ders);
            }
            catch (Exception)
            {
                MessageBox.Show("Eklemeye çalıştığınız ders zaten var.");
            }
        }

        public void Ogretim_Elemanına_Ders_Sil(int instroctur_id, string instroctur_adi, string instroctur_soyad)
        {

            try
            {
                //Lecture ders = new Lecture(instroctur_id, instroctur_adi, instroctur_soyad);
                //Lectures.Remove(ders);
            }
            catch (Exception)
            {
                MessageBox.Show("Silmeye çalıştığınız ders bulunmamaktadır.");
            }
        }
            
          void SubeSingleton()
          {
            BranchSingleton nesnesube = BranchSingleton.Yolla();
            nesnesube.subeadi = "20";

          }
    }
}
