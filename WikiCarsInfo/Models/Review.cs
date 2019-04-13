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
        // review id is primary key
        [Key]
        public virtual int ReviewId { get; set; }

        //declaring variable for review
        [Required(ErrorMessage = "You must specify a Car Name")]
        [DisplayName("Car Name")]
        public virtual String Review_Name { get; set; }

        //declaring variable for review subject
        [Required(ErrorMessage = "You must specify a Subject")]
        [DisplayName("Review Subject")]
        public virtual String Review_Subject { get; set; }

        //declaring variable for writing review
        [Required(ErrorMessage = "You must write your review")]
        [DisplayName("Your Review")]
        public virtual String Your_Review { get; set; }

        //declaring variable for review rating
        [Required(ErrorMessage = "You must give Rating")]
        [DisplayName("Rating")]
        [Range(1, 5, ErrorMessage = "Rating must be 1 to 5")]
<<<<<<< HEAD
        
=======

>>>>>>> master
        public virtual int Rating { get; set; }
    }
}