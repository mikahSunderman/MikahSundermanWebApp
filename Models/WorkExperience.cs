using System;
using System.ComponentModel.DataAnnotations;

namespace MikahSundermanWebApp.Models
{
    public class WorkExperience
    {
        public int ID { get; set; }

        [StringLength(100, MinimumLength = 1)]
        [Required]
        public string Position { get; set; }

        public string Employer { get; set; }

        [Display(Name = "Start Date")]
		[DataType(DataType.Date)]
		[DisplayFormat(DataFormatString = "{0:MMMM yyyy}")]
        public DateTime StartDate { get; set; }

		[Display(Name = "Start Date")]
		[DataType(DataType.Date)]
		[DisplayFormat(DataFormatString = "{0:MMMM yyyy}")]
        public DateTime EndDate { get; set; }

        public string Description { get; set; }
    }
}
