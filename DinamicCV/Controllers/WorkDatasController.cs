using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DinamicCV.Data;
using DinamicCV.Models;

namespace DinamicCV.Controllers
{
    public class WorkDatasController : Controller
    {
        private readonly ApplicationDbContext _context;

        public WorkDatasController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: WorkDatas
        public async Task<IActionResult> Index()
        {
            return View(await _context.WorkData.ToListAsync());
        }

        // GET: WorkDatas/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var workData = await _context.WorkData
                .FirstOrDefaultAsync(m => m.WorkDataId == id);
            if (workData == null)
            {
                return NotFound();
            }

            return View(workData);
        }

        // GET: WorkDatas/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: WorkDatas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("WorkDataId,Employer,InitialDate,FinalDate,JobTitle,JobDescription")] WorkData workData)
        {
            if (ModelState.IsValid)
            {
                _context.Add(workData);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(workData);
        }

        // GET: WorkDatas/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var workData = await _context.WorkData.FindAsync(id);
            if (workData == null)
            {
                return NotFound();
            }
            return View(workData);
        }

        // POST: WorkDatas/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("WorkDataId,Employer,InitialDate,FinalDate,JobTitle,JobDescription")] WorkData workData)
        {
            if (id != workData.WorkDataId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(workData);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!WorkDataExists(workData.WorkDataId))
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
            return View(workData);
        }

        // GET: WorkDatas/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var workData = await _context.WorkData
                .FirstOrDefaultAsync(m => m.WorkDataId == id);
            if (workData == null)
            {
                return NotFound();
            }

            return View(workData);
        }

        // POST: WorkDatas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var workData = await _context.WorkData.FindAsync(id);
            _context.WorkData.Remove(workData);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool WorkDataExists(int id)
        {
            return _context.WorkData.Any(e => e.WorkDataId == id);
        }
    }
}
