using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WikiCarsInfo.Models
{
    public class FeedBack
    {
        
        [Key]
        public virtual int FeedbackId { get; set; }

        
        public virtual String Name { get; set; }

      
        public virtual String Email { get; set; }
        
        public virtual String Your_Feedback { get; set; }

     
        public Answer Answer { get; set; }
    }

  
    public enum Answer
    {
        Excellent,
        Good,
        Neutral,
        Poor
    }
}
