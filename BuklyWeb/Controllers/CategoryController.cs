using BuklyWeb.Data;
using BuklyWeb.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BuklyWeb.Controllers
{
    public class CategoryController : Controller
    {
        public readonly ApplicationDbContext _context;
        public CategoryController(ApplicationDbContext context)
        {
            _context = context;
        }


        public IActionResult Index()
        {
            return View();
        }


        // GET: /Category/Add
        public async Task<IActionResult> Add()
        {
            var categories = await _context.Categories
                              .ToListAsync();
            return View(categories);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Add(Category category)
        {
            if (ModelState.IsValid)
            {
                _context.Categories.Add(category);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Add));
            }

            var categories = await _context.Categories
                .OrderBy(c => c.DisplayOrder)
                .ToListAsync();
            return View(categories);
        }

                  // GET: /Category/Edit/5
        public async Task<IActionResult> Edit(int id)
        {
            var category = await _context.Categories.FindAsync(id);
            if (category == null)
                return NotFound();

            return View(category);
        }

        // POST: /Category/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Category category)
        {
            if (ModelState.IsValid)
            {
                _context.Categories.Update(category);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Add));
            }
            return View(category);
        }

        // GET: /Category/Delete/5 — tasdiqlash sahifasi
        public async Task<IActionResult> Delete(int id)
        {
            var category = await _context.Categories.FindAsync(id);
            if (category == null)
                return NotFound();

            return View(category);
        }

        // POST: /Category/Delete/5 — haqiqiy o'chirish
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var category = await _context.Categories.FindAsync(id);
            if (category != null)
            {
                _context.Categories.Remove(category);
                await _context.SaveChangesAsync();
            }

            return RedirectToAction(nameof(Add));
        }

    }
}
