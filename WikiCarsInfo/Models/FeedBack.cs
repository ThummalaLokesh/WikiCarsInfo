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

        //declaring variable for review
        [Required(ErrorMessage = "You must write your Name")]
        [DisplayName("Your Name")]
        public virtual String Name { get; set; }

        //declaring variable for review subject
        [Required(ErrorMessage = "You must write your Email")]
        [DisplayName("Email")]
        public virtual String Email { get; set; }

        //declaring variable for writing review
        [Required(ErrorMessage = "You must write your Feedback")]
        [DisplayName("Your Feedback")]
        public virtual String Your_Feedback { get; set; }

        [Required(ErrorMessage = "You must answer this question")]
        [DisplayName("How satisfied were you with our Website?")]
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
