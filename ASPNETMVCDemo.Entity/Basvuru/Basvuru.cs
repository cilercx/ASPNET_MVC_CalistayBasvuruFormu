using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASPNETMVCDemo.Entity.Basvuru
{
    public class Basvuru:Base
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Eposta { get; set; }
        public string TelNo { get; set; }
        public string Adres { get; set; }

    }
}
