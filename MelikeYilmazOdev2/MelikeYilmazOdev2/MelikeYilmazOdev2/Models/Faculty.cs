using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace MelikeYilmazOdev2.Models
{
    public class Faculty 
    {
        public Faculty(string fakulteAdi) //Sınıfımızla aynı adı taşıyan constructor(yapıcı) method.
        {
            Departments = new List<Department>(); //Bölüm listemiz.
            Name = fakulteAdi;
        }

        public string Name { get; set; }
        
        
        public List<Department> Departments { get; set; }


        public override string ToString()
        {
            return Name;
        }

        public void Bolum_Ekle(string bolum_ad) //Fakülteye bölüm ekleme metodumuz.
        {
            try
            {
                Department bolum = new Department(bolum_ad);
                Departments.Add(bolum);
            }
            catch (Exception)//Hata yakalama.
            {
                    MessageBox.Show("Eklemek istediğiniz bölüm zaten mevcut");
            }
        }
        public void Bolum_Sil(string bolum_ad) //Fakülteden bölüm silme metodumuz.
        {
            try
            {
                Department bolum = new Department(bolum_ad);
                Departments.Remove(bolum);
            }
            catch (Exception)//Hata yakalama.
            {
                MessageBox.Show("Sileceğiniz bölüm bulunmadı...");
            }
        }
    }
}
