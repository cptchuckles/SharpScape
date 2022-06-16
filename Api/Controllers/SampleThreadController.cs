using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SharpScape.Api.Data;
using SharpScape.Api.Models;

namespace SharpScape.Api.Controllers
{
    public class Something: Controller
    {
        private readonly SqliteDbContext _context;

        public Something(SqliteDbContext context)
        {
            _context = context;
        }

        // GET: Thread
        public async Task<IActionResult> Index()
        {
            var sqliteDbContext = _context.ThreadModels.Include(t => t.User);
            return View(await sqliteDbContext.ToListAsync());
        }

        // GET: Thread/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null || _context.ThreadModels == null)
            {
                return NotFound();
            }

            var threadModel = await _context.ThreadModels
                .Include(t => t.User)
                .FirstOrDefaultAsync(m => m.UserId == id);
            if (threadModel == null)
            {
                return NotFound();
            }

            return View(threadModel);
        }

        // GET: Thread/Create
        public IActionResult Create()
        {
            ViewData["UserId"] = new SelectList(_context.Users, "Id", "Id");
            return View();
        }

        // POST: Thread/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("UserId,Title,Body,Votes,Relies,Views,Created")] ThreadModel threadModel)
        {
            if (ModelState.IsValid)
            {
                threadModel.UserId = Guid.NewGuid();
                _context.Add(threadModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["UserId"] = new SelectList(_context.Users, "Id", "Id", threadModel.UserId);
            return View(threadModel);
        }

        // GET: Thread/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null || _context.ThreadModels == null)
            {
                return NotFound();
            }

            var threadModel = await _context.ThreadModels.FindAsync(id);
            if (threadModel == null)
            {
                return NotFound();
            }
            ViewData["UserId"] = new SelectList(_context.Users, "Id", "Id", threadModel.UserId);
            return View(threadModel);
        }

        // POST: Thread/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("UserId,Title,Body,Votes,Relies,Views,Created")] ThreadModel threadModel)
        {
            if (id != threadModel.UserId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(threadModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ThreadModelExists(threadModel.UserId))
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
            ViewData["UserId"] = new SelectList(_context.Users, "Id", "Id", threadModel.UserId);
            return View(threadModel);
        }

        // GET: Thread/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null || _context.ThreadModels == null)
            {
                return NotFound();
            }

            var threadModel = await _context.ThreadModels
                .Include(t => t.User)
                .FirstOrDefaultAsync(m => m.UserId == id);
            if (threadModel == null)
            {
                return NotFound();
            }

            return View(threadModel);
        }

        // POST: Thread/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            if (_context.ThreadModels == null)
            {
                return Problem("Entity set 'SqliteDbContext.ThreadModels'  is null.");
            }
            var threadModel = await _context.ThreadModels.FindAsync(id);
            if (threadModel != null)
            {
                _context.ThreadModels.Remove(threadModel);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ThreadModelExists(Guid id)
        {
            return (_context.ThreadModels?.Any(e => e.UserId == id)).GetValueOrDefault();
        }
    }
}
