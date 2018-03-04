using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ContosoUniversity.Models
{
    public class Student : Person
    {
        //[DisplayFormat(NullDisplayText = "No Credits Earned")]
        public int CreditsEarned { get; set; }

        //[DisplayFormat(NullDisplayText = "No GPA")]
        [Range(0.7, 4.0)]
        public double GPA { get; set; }

        

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Enrollment Date")]
        public DateTime EnrollmentDate { get; set; }

        public virtual ICollection<Enrollment> Enrollments { get; set; }
    }
}