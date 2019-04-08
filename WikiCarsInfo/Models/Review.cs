using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WikiCarsInfo.Models
{
    public class Review
    {
      
        [Key]
        public virtual int ReviewId { get; set; }

        
        public virtual String Review_Name { get; set; }

       
        public virtual String Review_Subject { get; set; }

       
        public virtual String Your_Review { get; set; }

       

        public virtual int Rating { get; set; }
    }
}