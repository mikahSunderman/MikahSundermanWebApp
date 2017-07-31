using System;
using System.ComponentModel.DataAnnotations;

namespace MikahSundermanWebApp.Models
{
    public class Education
    {
        public int ID { get; set; }

        [Required]
        public string University { get; set; }

        public string Location { get; set; }

        [Display(Name = "Graduation Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:MMMM yyyy}")]
        public DateTime GraduationDate { get; set; }

        public string Major { get; set; }

        public string Minor { get; set; }
    }
}
