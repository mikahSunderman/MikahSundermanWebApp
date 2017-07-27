using System;
using System.ComponentModel.DataAnnotations;

namespace MikahSundermanWebApp.Models
{
    public class FrameworkAPI
    {
        public int ID { get; set; }

        [Required]
        public string Framework { get; set; }
    }
}
