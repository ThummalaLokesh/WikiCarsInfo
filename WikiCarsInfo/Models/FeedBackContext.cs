using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WikiCarsInfo.Models
{
    public class FeedBackContext : DbContext
    {
        public FeedBackContext() : base("name=FeedBackContext")
        {
        }
        public System.Data.Entity.DbSet<WikiCarsInfo.Models.FeedBack> FeedBacks { get; set; }
    }
}
    