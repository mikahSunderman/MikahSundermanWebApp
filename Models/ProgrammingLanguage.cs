using System;
using System.ComponentModel.DataAnnotations;

namespace MikahSundermanWebApp.Models
{
    public class ProgrammingLanguage
    {
        public int ID { get; set; }

        [Required]
        public string Language { get; set; }
    }
}
