using MelikeYilmazOdev2.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MelikeYilmazOdev2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();  //Fakültemizin ismini atadık.
            deu.Name = "Dokuz Eylül Üniversitesi";
        }

        University deu = new University(); //Universite objemizi oluşturduk.

        private void btnFakulteKaydet_Click(object sender, EventArgs e) //Fakülte Kaydetme Butonu
        {
            listBoxFakulteler.DataSource = null;

            deu.FakulteEkle(textBoxFakulte.Text);
            
            listBoxFakulteler.DataSource = deu.Faculties;

            textBoxFakulte.Text = "";
        }

        private void btnBolumEkle_Click(object sender, EventArgs e) //Bölüm ekleme butonu.
        {
            listBoxBolumler.DataSource = null;

            if (listBoxFakulteler.SelectedItem != null)
            {
                var fac = listBoxFakulteler.SelectedItem as Faculty;
                fac.Bolum_Ekle(textBoxBolum.Text);

                //fac.Departments.Add(new Department()
                //{
                //    Id = count,
                //    Name = textBoxBolum.Text,
                //    FacultyId = fac.Id
                //});

                listBoxBolumler.DataSource = fac.Departments;
            }
            else
            {
                MessageBox.Show("Listeden Bir Fakülte Seçmeniz Gerekmektedir!");
            }

            textBoxBolum.Text = "";
        }

        private void listBoxFakulteler_DoubleClick(object sender, EventArgs e)
        {
            listBoxBolumler.DataSource = null;
            var fac = listBoxFakulteler.SelectedItem as Faculty;
            listBoxBolumler.DataSource = fac.Departments;
        }

        private void listBoxFakulteler_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBoxBolumler.DataSource = null;
            var fac = listBoxFakulteler.SelectedItem as Faculty;
            listBoxBolumler.DataSource = fac.Departments;
        }

        private void btnDersEkle_Click(object sender, EventArgs e) //Ders ekleme butonu
        {           
            listBoxDersler.DataSource = null;

            if ( listBoxBolumler.SelectedItem!=null)
            {                         
                var dep = listBoxBolumler.SelectedItem as Department;
                dep.Ders_Ekle(textBoxDers.Text);
                //dep.Lectures.Add(new Lecture()
                //{
                //    Id = count,
                //    Name = textBoxDers.Text,               
                //    DepartmentId = dep.Id
                //});

                listBoxDersler.DataSource = dep.Lectures;
            }
            else
            {
                MessageBox.Show("Listeden Bir Bölüm Seçmeniz Gerekmektedir!");
            }

            textBoxBolum.Text = "";

        }

        private void btnOgrenciEkle_Click(object sender, EventArgs e) //Öğrenci ekleme butonu.
        {

            listBoxOgrenciler.Items.Add(textBoxadi.Text);
            listBoxOgrenciler.Items.Add(textBoxsoyadi.Text);
            listBoxOgrenciler.Items.Add(textBoxno.Text);
        }
    }
}
//http://www.csharpnedir.com/articles/read/?id=766
//https://social.msdn.microsoft.com/Forums/vstudio/tr-TR/9b4b88a9-962e-4be9-a718-78ec49843a90/null-hatas-systemnullreferenceexception-nesne-bavurusu-bir-nesnenin-rneine-ayarlanmad?forum=csharptr
//https://www.kodlamamerkezi.com/c-net/csharp-try-catch-finally-bloklari-ile-hata-yakalama/
//https://www.tutorialsteacher.com/csharp/csharp-list
//https://docs.microsoft.com/tr-tr/dotnet/api/system.collections.generic.list-1?view=netframework-4.8
//Damla İpçi'den yardım aldım.
//http://194.27.66.201/moodle/pluginfile.php/15740/mod_resource/content/2/DesignPatterns.pdf
//

