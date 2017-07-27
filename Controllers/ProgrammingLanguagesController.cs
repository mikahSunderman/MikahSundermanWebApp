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
    public class ProgrammingLanguagesController : Controller
    {
        private readonly MikahSundermanWebAppContext _context;

        public ProgrammingLanguagesController(MikahSundermanWebAppContext context)
        {
            _context = context;    
        }

        // GET: ProgrammingLanguages
        public async Task<IActionResult> Index()
        {
            return View(await _context.ProgrammingLanguage.ToListAsync());
        }

        // GET: ProgrammingLanguages/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var programmingLanguage = await _context.ProgrammingLanguage
                .SingleOrDefaultAsync(m => m.ID == id);
            if (programmingLanguage == null)
            {
                return NotFound();
            }

            return View(programmingLanguage);
        }

        // GET: ProgrammingLanguages/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ProgrammingLanguages/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,Language")] ProgrammingLanguage programmingLanguage)
        {
            if (ModelState.IsValid)
            {
                _context.Add(programmingLanguage);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(programmingLanguage);
        }

        // GET: ProgrammingLanguages/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var programmingLanguage = await _context.ProgrammingLanguage.SingleOrDefaultAsync(m => m.ID == id);
            if (programmingLanguage == null)
            {
                return NotFound();
            }
            return View(programmingLanguage);
        }

        // POST: ProgrammingLanguages/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,Language")] ProgrammingLanguage programmingLanguage)
        {
            if (id != programmingLanguage.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(programmingLanguage);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProgrammingLanguageExists(programmingLanguage.ID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction("Index");
            }
            return View(programmingLanguage);
        }

        // GET: ProgrammingLanguages/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var programmingLanguage = await _context.ProgrammingLanguage
                .SingleOrDefaultAsync(m => m.ID == id);
            if (programmingLanguage == null)
            {
                return NotFound();
            }

            return View(programmingLanguage);
        }

        // POST: ProgrammingLanguages/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var programmingLanguage = await _context.ProgrammingLanguage.SingleOrDefaultAsync(m => m.ID == id);
            _context.ProgrammingLanguage.Remove(programmingLanguage);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        private bool ProgrammingLanguageExists(int id)
        {
            return _context.ProgrammingLanguage.Any(e => e.ID == id);
        }
    }
}
