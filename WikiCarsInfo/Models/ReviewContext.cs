using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WikiCarsInfo.Models
{
    public class ReviewContext : DbContext
    {
        public ReviewContext() : base("name=ReviewContext")
        {
        }
        public System.Data.Entity.DbSet<WikiCarsInfo.Models.Review> Reviews { get; set; }
    }
}