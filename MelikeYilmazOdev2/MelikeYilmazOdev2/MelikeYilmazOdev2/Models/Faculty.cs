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
        public Faculty(string fakulteAdi) 
        {
            Departments = new List<Department>();
        }
        public string Name { get; set; }
        
        
        public List<Department> Departments { get; set; }


        public override string ToString()
        {
            return Name;
        }

        public void Bolum_Ekle(string bolum_ad)
        {

            try
            {
                Department bolum = new Department(bolum_ad);
                Departments.Add(bolum);
            }
            catch (Exception)
            {
                    MessageBox.Show("Eklemek istediğiniz bölüm zaten mevcut");
            }
        }
        public void Bolum_Sil(string bolum_ad)
        {

            try
            {
                Department bolum = new Department(bolum_ad);
                Departments.Remove(bolum);
            }
            catch (Exception)
            {
                MessageBox.Show("Sileceğiniz bölüm bulunmadı...");
            }
        }



    }
}
