using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MelikeYilmazOdev2.Models
{
    public class University
    {
        public University() //Sınıfımızla aynı adı taşıyan constructor(yapıcı) method.
        {
            Faculties = new List<Faculty>(); //Fakülte listemiz.
            student = new List<Student>();  //Öğrenci listemiz
        }
        public string Name { get; set; }
        public List<Faculty> Faculties { get; set; }
        public List<Student> student { get; set; }

        public void FakulteEkle(string FakulteAdi)// Fakülte Ekleme metodu.
        {
            try
            {
                Faculty fakulte = new Faculty(FakulteAdi);
                Faculties.Add(fakulte);
            }

            catch (Exception) //Hata yakalama.
            {
                MessageBox.Show("Fakülte Bulunmaktadır");
            }

        }

        
    }
}
