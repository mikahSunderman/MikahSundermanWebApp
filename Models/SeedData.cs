using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace MikahSundermanWebApp.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MikahSundermanWebAppContext(
                serviceProvider.GetRequiredService<DbContextOptions<MikahSundermanWebAppContext>>()))
            {
                // Populate Education table
                if (!context.Education.Any())
                {
					context.Education.AddRange(
                        new Education
	                    {
	                        University = "Purdue University",
                            Location = "Fort Wayne, IN",
                            GraduationDate = DateTime.Parse("May 10, 2017"),
                            Major = "Bachelor of Science in Computer Science",
                            Minor = "Mathematics"
	                    }
				    );
					context.SaveChanges();
                }

				// Populate WorkExperience table
				if (!context.WorkExperience.Any())
				{
					context.WorkExperience.AddRange(
                        new WorkExperience
	                    {
	                        Position = "Social Media Analyst",
	                        Employer = "Marketing Communications Department, Indiana University - Purdue University Fort Wayne",
	                        StartDate = DateTime.Parse("October 1, 2015"),
	                        EndDate = DateTime.Parse("August 1, 2016"),
	                        Description = "Developed an automated dashboard using Microsoft Excel and Word to generate analytical " +
	                            "charts from exported Facebook and Twitter data. " + "Analyzed and wrote assessment reports evaluating " +
	                            "IPFW digital advertising performance using Google Analytics and HubSpot."
	                    },
						new WorkExperience
						{
							Position = "Teaching Assistant",
							Employer = "Computer Science Department, Indiana University - Purdue University Fort Wayne",
							StartDate = DateTime.Parse("June 1, 2015"),
							EndDate = DateTime.Parse("January 1, 2017"),
							Description = "Graded student programming assignments for introductory computer graphics course. " +
                                "Performed assistive task, such as collection and organization of files. " +
                            "Developed a dashboard using Microsoft Excel to aid the department faculty in tabulating course assessments."
						}
					);
					context.SaveChanges();
				}

				// Populate ProgrammingLanguage table
				if (!context.ProgrammingLanguage.Any())
				{
					context.ProgrammingLanguage.AddRange(
						new ProgrammingLanguage { Language = "C / C++" },
						new ProgrammingLanguage { Language = "C#" },
						new ProgrammingLanguage { Language = "Java" },
						new ProgrammingLanguage { Language = "Python" },
						new ProgrammingLanguage { Language = "JavaScript" },
						new ProgrammingLanguage { Language = "HTML5" },
						new ProgrammingLanguage { Language = "CSS3" },
						new ProgrammingLanguage { Language = "SQL" }
					);
					context.SaveChanges();
				}

				// Populate FrameworkAPI table
				if (!context.FrameworkAPI.Any())
				{
					context.FrameworkAPI.AddRange(
                        new FrameworkAPI { Framework = ".NET (C#)" },
						new FrameworkAPI { Framework = "ASP.NET" },
						new FrameworkAPI { Framework = "Flask" },
						new FrameworkAPI { Framework = "Bootstrap" },
						new FrameworkAPI { Framework = "Angular" },
						new FrameworkAPI { Framework = "DirectX" },
						new FrameworkAPI { Framework = "OpenGL" }
					);
					context.SaveChanges();
				}
            }
        }
    }
}
