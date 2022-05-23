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
    public class FeatureTitlesController : Controller
    {
        private readonly AppDbContext _context;

        public FeatureTitlesController(AppDbContext context)
        {
            _context = context;
        }

        // GET: admin/FeatureTitles
        public async Task<IActionResult> Index()
        {
            var appDbContext = _context.FeatureTitles.Include(f => f.Product).Include(f => f.SubFeature);
            return View(await appDbContext.ToListAsync());
        }

        // GET: admin/FeatureTitles/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var featureTitle = await _context.FeatureTitles
                .Include(f => f.Product)
                .Include(f => f.SubFeature)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (featureTitle == null)
            {
                return NotFound();
            }

            return View(featureTitle);
        }

        // GET: admin/FeatureTitles/Create
        public IActionResult Create()
        {
            ViewData["ProductId"] = new SelectList(_context.Products, "Id", "Id");
            ViewData["SubFeatureId"] = new SelectList(_context.SubFeatures, "Id", "Id");
            return View();
        }

        // POST: admin/FeatureTitles/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Title,SubFeatureId,ProductId")] FeatureTitle featureTitle)
        {
            if (ModelState.IsValid)
            {
                _context.Add(featureTitle);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["ProductId"] = new SelectList(_context.Products, "Id", "Id", featureTitle.ProductId);
            ViewData["SubFeatureId"] = new SelectList(_context.SubFeatures, "Id", "Id", featureTitle.SubFeatureId);
            return View(featureTitle);
        }

        // GET: admin/FeatureTitles/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var featureTitle = await _context.FeatureTitles.FindAsync(id);
            if (featureTitle == null)
            {
                return NotFound();
            }
            ViewData["ProductId"] = new SelectList(_context.Products, "Id", "Id", featureTitle.ProductId);
            ViewData["SubFeatureId"] = new SelectList(_context.SubFeatures, "Id", "Id", featureTitle.SubFeatureId);
            return View(featureTitle);
        }

        // POST: admin/FeatureTitles/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Title,SubFeatureId,ProductId")] FeatureTitle featureTitle)
        {
            if (id != featureTitle.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(featureTitle);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!FeatureTitleExists(featureTitle.Id))
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
            ViewData["ProductId"] = new SelectList(_context.Products, "Id", "Id", featureTitle.ProductId);
            ViewData["SubFeatureId"] = new SelectList(_context.SubFeatures, "Id", "Id", featureTitle.SubFeatureId);
            return View(featureTitle);
        }

        // GET: admin/FeatureTitles/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var featureTitle = await _context.FeatureTitles
                .Include(f => f.Product)
                .Include(f => f.SubFeature)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (featureTitle == null)
            {
                return NotFound();
            }

            return View(featureTitle);
        }

        // POST: admin/FeatureTitles/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var featureTitle = await _context.FeatureTitles.FindAsync(id);
            _context.FeatureTitles.Remove(featureTitle);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool FeatureTitleExists(int id)
        {
            return _context.FeatureTitles.Any(e => e.Id == id);
        }
    }
}
