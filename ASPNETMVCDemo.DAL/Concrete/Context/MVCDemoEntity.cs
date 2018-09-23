
using ASPNETMVCDemo.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASPNETMVCDemo.DAL.Concrete.Context
{
    public class MVCDemoEntity : DbContext
    {
        public MVCDemoEntity()
            : base("name=MVCDemoEntity") //bu web.config'teki connectionstring'in(name="...") adıdır.
        {

        }

        public virtual DbSet<Contact> Contacts { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Login> Logins { get; set; }

    }
}
