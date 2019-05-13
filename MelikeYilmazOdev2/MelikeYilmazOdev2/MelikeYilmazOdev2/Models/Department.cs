using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace MelikeYilmazOdev2.Models
{
    public class Department 
    {
        public Department(string bolum_ad)
        {
            Lectures = new List<Lecture>();
            Students = new List<Student>();
        }
        public string Name { get; set; }
        public int FacultyId { get; set; }
        
        public List<Lecture> Lectures { get; set; }
        public List<Student> Students { get; }

        public override string ToString()
        {
            return Name;
        }

        public void Ders_Ekle(string ders_adi)
        {

            try
            {
                Lecture ders = new Lecture(ders_adi);
                Lectures.Add(ders);
            }
            catch (Exception)
            {
                MessageBox.Show("Eklemeye çalıştığınız ders zaten var.");
            }
        }

        public void Ders_Sil(string ders_adi)
        {

            try
            {
                Lecture ders = new Lecture(ders_adi);
                Lectures.Remove(ders);
            }
            catch (Exception)
            {
                MessageBox.Show("Sileceğiniz ders yok...");
            }
        }



    }
}
