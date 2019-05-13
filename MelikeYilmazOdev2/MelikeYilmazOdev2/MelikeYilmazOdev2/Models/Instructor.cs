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
        public int ınstructor_id;
        public string ınstructor_name;
        public string ınstructor_lastname;
        public List<Lecture> Lectures { get; set; }

        public int Instructor_id
        {
            get { return ınstructor_id; }
            set { ınstructor_id = value; }
        }

        public string Instructor_name
        {
            get { return ınstructor_name; }
            set { ınstructor_name = value; }
        }
        public string Instructor_lastname
        {
            get { return ınstructor_lastname; }
            set { ınstructor_lastname = value; }
        }

        public Instructor(int id,string ad,string soyad)
        {
            Lectures = new List<Lecture>();
        }

        public void Ogretim_Elemanına_Ders_Ekle(int instroctur_id, string instroctur_adi, string instroctur_soyad)
        {

            try
            {
                Lecture ders = new Lecture(instroctur_id, instroctur_adi, instroctur_soyad);
                Lectures.Add(ders);
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
                Lecture ders = new Lecture(instroctur_id, instroctur_adi, instroctur_soyad);
                Lectures.Remove(ders);
            }
            catch (Exception)
            {
                MessageBox.Show("Silmeye çalıştığınız yok.");
            }
        }
    }
}
