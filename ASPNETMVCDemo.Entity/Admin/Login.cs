using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASPNETMVCDemo.Entity
{
    public class Login:Base
    {
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}