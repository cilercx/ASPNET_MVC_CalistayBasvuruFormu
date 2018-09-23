using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASPNETMVCDemo.DAL.Abstract
{
    public interface IRepository<T> where T : class
    {
        List<T> ListeGetir();

        T NesneGetir();

        bool Guncelle(int id);

        bool Sil(int id);

        bool Ekle(T nesne);



    }
}
