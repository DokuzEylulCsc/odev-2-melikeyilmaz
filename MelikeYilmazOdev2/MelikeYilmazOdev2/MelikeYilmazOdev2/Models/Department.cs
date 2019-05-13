using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace MelikeYilmazOdev2.Models
{
    public class Department //Bölüm Classı.
    {
        private string ogrenci_turleri;

        public Department(string bolum_ad)
        {
            Lectures = new List<Lecture>(); //Ders Listemiz.
            Students = new List<Student>();//Öğrenci Listemiz.
            Instructors =new List<Instructor>();//Öğretim Elemanı Listemiz.
            Name = bolum_ad;
        }
        public string Name { get; set; }
        public int FacultyId { get; set; }
        
        public List<Lecture> Lectures { get; set; }
        public List<Student> Students { get; }
        public List<Instructor>Instructors{ get; }

        public override string ToString()
        {
            return Name;
        }

        public void Ders_Ekle(string ders_adi) //Bölüme ders ekleme metodumuz.
        {
            try
            {
                Lecture ders = new Lecture(ders_adi);
                Lectures.Add(ders);
            }
            catch (Exception) //Hata yakalama.
            {
                MessageBox.Show("Eklemeye çalıştığınız ders zaten var.");
            }
        }

        public void Ders_Sil(string ders_adi) //Bölümden ders silme metodumuz.
        {
            try
            {
                Lecture ders = new Lecture(ders_adi);
                Lectures.Remove(ders);
            }
            catch (Exception) //Hata yakalama.
            {
                MessageBox.Show("Sileceğiniz ders yok...");
            }
        }

        public void Ogrenci_Ekle(string ad,string soyad,string bolum,int id) //Öğrenci ekleme metodumuz.
        {
            try
            {
                Student ogrenci = new UnderGraduate("Buse","Atabey","Matematik",3);
                switch (ogrenci_turleri) //öğrenci türünü seçebilmek amacıyla kullandığımız switch-case yapısı.
                {
                    case "Lisans":
                        ogrenci = new UnderGraduate(ad, soyad, bolum, id);
                        break;
                    case "YuksekLisans":
                        ogrenci = new MasterDegree(ad, soyad, bolum, id);
                        break;
                    case "Doktora":
                        ogrenci = new PostGraduate(ad, soyad, bolum, id);
                        break;
                    default:
                        Console.WriteLine("Bir öğrenci türü seçmeniz gerekmektedir.");
                        break;
                   
                }
                //Student ogrenci = new Student(ad,soyad,bolum,id);
                //Students.Add(ogrenci);
            }
            catch (Exception)  //Hata yakalama.
            {
                MessageBox.Show("Eklemeye çalıştığınız ders zaten var.");
            }
        }


        public void Ogrenci_Sil(string ad, string soyad, string bolum, int id)
        {






        }

        public void Ogretim_Elemani_Ekle(string ad,string soyad,int id)
        {
            try
            {
                Instructor ogr_elemani = new Instructor (ad, soyad,id);
                Instructors.Add(ogr_elemani);//Listeye öğretim elemanı ekler.
            }

            catch (Exception)//Hata yakalama.
            {
                MessageBox.Show("Ogretim Elemani Bulunmakta!!");
            }
        }

        public void Ogretim_Elemani_Sil(int id)//Öğretim elemanı silme metodumuz.
        {
            try
            {
                Instructor ınst_id = new Instructor(id);
                Instructors.Remove(ınst_id); //Ögretim elemani listesinden id ye bağlı olarak siliyor.
            }
            catch (FormatException) //Hata yakalama
            {

                throw new FormatException("Lütfen bu alana sadece istenen türde değer giriniz.");
            }
            catch (Exception)//Hata yakalama.
            {
                throw new Exception("Ogretim Elemani Bulunmamaktadir!");
            }
        }
    }
}
