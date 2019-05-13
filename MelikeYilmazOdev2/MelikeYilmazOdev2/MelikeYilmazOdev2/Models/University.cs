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
        public University()
        {
            Faculties = new List<Faculty>();
            student = new List<Student>();
        }
        public string Name { get; set; }
        public List<Faculty> Faculties { get; set; }
        public List<Student> student { get; set; }

        public void FakulteEkle(string FakulteAdi)// Fakulte Ekleme metodu.
        {
            try
            {
                Faculty fakulte = new Faculty(FakulteAdi);
                Faculties.Add(fakulte);
            }

            catch (Exception)
            {
                MessageBox.Show("Fakulte Bulunmaktadır");
            }

        }

        
    }
}
