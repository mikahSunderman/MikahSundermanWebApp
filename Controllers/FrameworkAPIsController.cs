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
    public class FrameworkAPIsController : Controller
    {
        private readonly MikahSundermanWebAppContext _context;

        public FrameworkAPIsController(MikahSundermanWebAppContext context)
        {
            _context = context;    
        }

        // GET: FrameworkAPIs
        public async Task<IActionResult> Index()
        {
            return View(await _context.FrameworkAPI.ToListAsync());
        }

        // GET: FrameworkAPIs/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var frameworkAPI = await _context.FrameworkAPI
                .SingleOrDefaultAsync(m => m.ID == id);
            if (frameworkAPI == null)
            {
                return NotFound();
            }

            return View(frameworkAPI);
        }

        // GET: FrameworkAPIs/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: FrameworkAPIs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,Framework")] FrameworkAPI frameworkAPI)
        {
            if (ModelState.IsValid)
            {
                _context.Add(frameworkAPI);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(frameworkAPI);
        }

        // GET: FrameworkAPIs/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var frameworkAPI = await _context.FrameworkAPI.SingleOrDefaultAsync(m => m.ID == id);
            if (frameworkAPI == null)
            {
                return NotFound();
            }
            return View(frameworkAPI);
        }

        // POST: FrameworkAPIs/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,Framework")] FrameworkAPI frameworkAPI)
        {
            if (id != frameworkAPI.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(frameworkAPI);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!FrameworkAPIExists(frameworkAPI.ID))
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
            return View(frameworkAPI);
        }

        // GET: FrameworkAPIs/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var frameworkAPI = await _context.FrameworkAPI
                .SingleOrDefaultAsync(m => m.ID == id);
            if (frameworkAPI == null)
            {
                return NotFound();
            }

            return View(frameworkAPI);
        }

        // POST: FrameworkAPIs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var frameworkAPI = await _context.FrameworkAPI.SingleOrDefaultAsync(m => m.ID == id);
            _context.FrameworkAPI.Remove(frameworkAPI);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        private bool FrameworkAPIExists(int id)
        {
            return _context.FrameworkAPI.Any(e => e.ID == id);
        }
    }
}
