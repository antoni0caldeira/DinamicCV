using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DinamicCV.Data;
using DinamicCV.Models;
using Microsoft.AspNetCore.Authorization;

namespace DinamicCV.Controllers
{
   
    public class WorkDatasController : Controller
    {
        
        private readonly ApplicationDbContext db;

        public WorkDatasController(ApplicationDbContext context)
        {
            db = context;
        }

        // GET: WorkDatas
        public async Task<IActionResult> Index(int pagina = 1)
        {

            Pagination paginacao = new Pagination
            {
                TotalItems = await db.WorkData.CountAsync(),
                PaginaAtual = pagina
            };

            List<WorkData> trabalhos = await db.WorkData
                .Skip(paginacao.ItemsPorPagina * (pagina - 1))
                .Take(paginacao.ItemsPorPagina)
                .ToListAsync();

            ListaWorkDataViewModel modelo = new ListaWorkDataViewModel
            {
                Paginacao = paginacao,
                WorkDatas = trabalhos
            };

            return base.View(modelo);

            //return View(await _context.WorkData.ToListAsync());
        }

        // GET: WorkDatas/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var workData = await db.WorkData
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
                db.Add(workData);
                await db.SaveChangesAsync();
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

            var workData = await db.WorkData.FindAsync(id);
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
                    db.Update(workData);
                    await db.SaveChangesAsync();
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

            var workData = await db.WorkData
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
            var workData = await db.WorkData.FindAsync(id);
            db.WorkData.Remove(workData);
            await db.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool WorkDataExists(int id)
        {
            return db.WorkData.Any(e => e.WorkDataId == id);
        }
    }
}
