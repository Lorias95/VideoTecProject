using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebAppBD.Models;

namespace WebAppBD.Controllers
{
    public class ArchiPeliPrestadasController : Controller
    {
        private readonly VIDEOTECContext _context;

        public ArchiPeliPrestadasController(VIDEOTECContext context)
        {
            _context = context;
        }

        // GET: ArchiPeliPrestadas
        public async Task<IActionResult> Index()
        {
            return View(await _context.ArchiPeliPrestadas.ToListAsync());
        }

        // GET: ArchiPeliPrestadas/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var archiPeliPrestadas = await _context.ArchiPeliPrestadas
                .FirstOrDefaultAsync(m => m.IdPeliPrestada == id);
            if (archiPeliPrestadas == null)
            {
                return NotFound();
            }

            return View(archiPeliPrestadas);
        }

        // GET: ArchiPeliPrestadas/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ArchiPeliPrestadas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdPeliPrestada,FechaPrestamo,Titulo,Duracion,NumCintas,Genero,Actores,Directores")] ArchiPeliPrestadas archiPeliPrestadas)
        {
            if (ModelState.IsValid)
            {
                _context.Add(archiPeliPrestadas);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(archiPeliPrestadas);
        }

        // GET: ArchiPeliPrestadas/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var archiPeliPrestadas = await _context.ArchiPeliPrestadas.FindAsync(id);
            if (archiPeliPrestadas == null)
            {
                return NotFound();
            }
            return View(archiPeliPrestadas);
        }

        // POST: ArchiPeliPrestadas/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdPeliPrestada,FechaPrestamo,Titulo,Duracion,NumCintas,Genero,Actores,Directores")] ArchiPeliPrestadas archiPeliPrestadas)
        {
            if (id != archiPeliPrestadas.IdPeliPrestada)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(archiPeliPrestadas);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ArchiPeliPrestadasExists(archiPeliPrestadas.IdPeliPrestada))
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
            return View(archiPeliPrestadas);
        }

        // GET: ArchiPeliPrestadas/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var archiPeliPrestadas = await _context.ArchiPeliPrestadas
                .FirstOrDefaultAsync(m => m.IdPeliPrestada == id);
            if (archiPeliPrestadas == null)
            {
                return NotFound();
            }

            return View(archiPeliPrestadas);
        }

        // POST: ArchiPeliPrestadas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var archiPeliPrestadas = await _context.ArchiPeliPrestadas.FindAsync(id);
            _context.ArchiPeliPrestadas.Remove(archiPeliPrestadas);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ArchiPeliPrestadasExists(int id)
        {
            return _context.ArchiPeliPrestadas.Any(e => e.IdPeliPrestada == id);
        }
    }
}
