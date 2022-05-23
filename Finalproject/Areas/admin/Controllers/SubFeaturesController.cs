using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Finalproject.Data;
using Finalproject.Models;

namespace Finalproject.Areas.admin.Controllers
{
    [Area("admin")]
    public class SubFeaturesController : Controller
    {
        private readonly AppDbContext _context;

        public SubFeaturesController(AppDbContext context)
        {
            _context = context;
        }

        // GET: admin/SubFeatures
        public async Task<IActionResult> Index()
        {
            var appDbContext = _context.SubFeatures.Include(s => s.Category);
            return View(await appDbContext.ToListAsync());
        }

        // GET: admin/SubFeatures/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var subFeature = await _context.SubFeatures
                .Include(s => s.Category)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (subFeature == null)
            {
                return NotFound();
            }

            return View(subFeature);
        }

        // GET: admin/SubFeatures/Create
        public IActionResult Create()
        {
            ViewData["CategoryId"] = new SelectList(_context.Categories, "Id", "Id");
            return View();
        }

        // POST: admin/SubFeatures/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Feature,CategoryId")] SubFeature subFeature)
        {
            if (ModelState.IsValid)
            {
                _context.Add(subFeature);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CategoryId"] = new SelectList(_context.Categories, "Id", "Id", subFeature.CategoryId);
            return View(subFeature);
        }

        // GET: admin/SubFeatures/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var subFeature = await _context.SubFeatures.FindAsync(id);
            if (subFeature == null)
            {
                return NotFound();
            }
            ViewData["CategoryId"] = new SelectList(_context.Categories, "Id", "Id", subFeature.CategoryId);
            return View(subFeature);
        }

        // POST: admin/SubFeatures/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Feature,CategoryId")] SubFeature subFeature)
        {
            if (id != subFeature.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(subFeature);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SubFeatureExists(subFeature.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["CategoryId"] = new SelectList(_context.Categories, "Id", "Id", subFeature.CategoryId);
            return View(subFeature);
        }

        // GET: admin/SubFeatures/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var subFeature = await _context.SubFeatures
                .Include(s => s.Category)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (subFeature == null)
            {
                return NotFound();
            }

            return View(subFeature);
        }

        // POST: admin/SubFeatures/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var subFeature = await _context.SubFeatures.FindAsync(id);
            _context.SubFeatures.Remove(subFeature);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SubFeatureExists(int id)
        {
            return _context.SubFeatures.Any(e => e.Id == id);
        }
    }
}
