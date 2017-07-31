using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MikahSundermanWebApp.Models;

namespace MikahSundermanWebApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly MikahSundermanWebAppContext _context;

        public HomeController(MikahSundermanWebAppContext context)
		{
			_context = context;
		}

        public async Task<IActionResult> Index()
        {
            var educations = from e in _context.Education
                             select e;
            var workExperiences = from we in _context.WorkExperience
                                  select we;
            var programmingLanguages = from pl in _context.ProgrammingLanguage
                                       select pl;
            var frameworkAPIs = from fAPIs in _context.FrameworkAPI
                                select fAPIs;

            var indexVM = new IndexViewModel();
			indexVM.educations = await educations.ToListAsync();
            indexVM.workExperiences = await workExperiences.ToListAsync();
            indexVM.programmingLanguages = await programmingLanguages.ToListAsync();
            indexVM.frameworkAPIs = await frameworkAPIs.ToListAsync();

            return View(indexVM);
        }
    }
}
