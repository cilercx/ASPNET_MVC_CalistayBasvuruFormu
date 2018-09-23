
using ASPNETMVCDemo.DAL.Abstract;
using ASPNETMVCDemo.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASPNETMVCDemo.DAL.Concrete
{
    public class UserRepository : IRepository<User>
    {
        public bool Ekle(User nesne)
        {
            throw new NotImplementedException();
        }

        public bool Guncelle(int id)
        {
            throw new NotImplementedException();
        }

        public List<User> ListeGetir()
        {
            throw new NotImplementedException();
        }

        public User NesneGetir()
        {
            throw new NotImplementedException();
        }

        public bool Sil(int id)
        {
            throw new NotImplementedException();
        }
    }
}
