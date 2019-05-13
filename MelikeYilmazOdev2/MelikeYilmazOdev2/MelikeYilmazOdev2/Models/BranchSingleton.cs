using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MelikeYilmazOdev2.Models
{
    class BranchSingleton
    {
        public string subeadi;
        public string Subeler { get { return subeadi; }set { subeadi = value; } }

        private BranchSingleton()
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
