using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WikiCarsInfo.Models
{
    public class ReviewContextInitializer : DropCreateDatabaseAlways<ReviewContext>
    {
        protected override void Seed(ReviewContext context)
        {
            //populating database with data
            context.Reviews.Add(new Review
            {
                 Review_Name = "Bmw 520", Review_Subject = "A review for bmw 520", Your_Review = "Good", Rating = 4 
            });
            base.Seed(context);
        }
    }
}