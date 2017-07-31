using System;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace MikahSundermanWebApp.Models
{
    public class IndexViewModel
    {
        public List<Education> educations { get; set; }
        public List<WorkExperience> workExperiences { get; set; }
        public List<ProgrammingLanguage> programmingLanguages { get; set; }
        public List<FrameworkAPI> frameworkAPIs { get; set; }
    }
}
