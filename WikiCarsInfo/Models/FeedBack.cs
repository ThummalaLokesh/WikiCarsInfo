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
        // feedback id is primary ke
        
        [Key]
        public virtual int FeedbackId { get; set; }

        //declaring variable for your name
        [Required(ErrorMessage = "You must write your Name")]
        [DisplayName("Your Name")]
        public virtual String Name { get; set; }

        //declaring variable for email
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        [Required(ErrorMessage = "You must write your Email")]
        [DisplayName("Email")]
        public virtual String Email { get; set; }

        //declaring variable for writing feedback
        [Required(ErrorMessage = "You must write your Feedback")]
        [DisplayName("Your Feedback")]
        public virtual String Your_Feedback { get; set; }

        //declaring variable for answering
        [Required(ErrorMessage = "You must answer this question")]
        [DisplayName("How satisfied were you with our Website?")]
        public Answer Answer { get; set; }
    }

    //enum method
    public enum Answer
    {
        Excellent,
        Good,
        Neutral,
        Poor
    }
}
