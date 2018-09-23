using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASPNETMVCDemo.Entity
{
    public class Contact:Base
    {       
        public string Name { get; set; }
        public string Surname { get; set; }       
        public string Email { get; set; }
        public string Phone { get; set; }

    }
}