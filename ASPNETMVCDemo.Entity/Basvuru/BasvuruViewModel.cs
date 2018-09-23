using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASPNETMVCDemo.Entity.Basvuru
{
    public class BasvuruViewModel
    {
        public int Id { get; set; }
        public List<Basvuru> Basvurular { get; set; }// bu list sunun için oluşturuldu: veritabanındaki herbir nesne nin toplamı yani tüm basvuruların toplamı bu nesnenin içine atılacak.


    }
}
