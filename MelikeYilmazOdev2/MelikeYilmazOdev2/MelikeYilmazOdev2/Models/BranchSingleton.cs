using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MelikeYilmazOdev2.Models
{
    class BranchSingleton
    {
        public string subeadi;//field 
        public string Subeler { get { return subeadi; }set { subeadi = value; } } //encapsulation

        private BranchSingleton()//Sınıfımızla aynı adı taşıyan constructor(yapıcı) method.
        {

        }
        private static BranchSingleton  subenesne;

        public static BranchSingleton Yolla()
        {
            if (subenesne == null)
            {
                 subenesne = new BranchSingleton();

            }
            return subenesne;
        }
    }
}

//http://www.csharpnedir.com/articles/read/?id=134
//https://www.gencayyildiz.com/blog/cta-singleton-design-patternsingleton-tasarim-deseni/
