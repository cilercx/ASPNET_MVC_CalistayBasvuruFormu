using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASPNETMVCDemo.Entity
{
    public class Base
    {
        public int Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdateDate { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }

    }
}