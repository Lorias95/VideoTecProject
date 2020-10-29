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
    public class ArchiPeliDevueltasController : Controller
    {
        private readonly VIDEOTECContext _context;

        public ArchiPeliDevueltasController(VIDEOTECContext context)
        {
            _context = context;
        }

        // GET: ArchiPeliDevueltas
        public async Task<IActionResult> Index()
        {
            return View(await _context.ArchiPeliDevueltas.ToListAsync());
        }

        // GET: ArchiPeliDevueltas/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var archiPeliDevueltas = await _context.ArchiPeliDevueltas
                .FirstOrDefaultAsync(m => m.IdPeliDevuelta == id);
            if (archiPeliDevueltas == null)
            {
                return NotFound();
            }

            return View(archiPeliDevueltas);
        }

        // GET: ArchiPeliDevueltas/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ArchiPeliDevueltas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdPeliDevuelta,FechaDevolucion,Titulo,Duracion,NumCintas,Genero,Actores,Directores")] ArchiPeliDevueltas archiPeliDevueltas)
        {
            if (ModelState.IsValid)
            {
                _context.Add(archiPeliDevueltas);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(archiPeliDevueltas);
        }

        // GET: ArchiPeliDevueltas/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var archiPeliDevueltas = await _context.ArchiPeliDevueltas.FindAsync(id);
            if (archiPeliDevueltas == null)
            {
                return NotFound();
            }
            return View(archiPeliDevueltas);
        }

        // POST: ArchiPeliDevueltas/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdPeliDevuelta,FechaDevolucion,Titulo,Duracion,NumCintas,Genero,Actores,Directores")] ArchiPeliDevueltas archiPeliDevueltas)
        {
            if (id != archiPeliDevueltas.IdPeliDevuelta)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(archiPeliDevueltas);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ArchiPeliDevueltasExists(archiPeliDevueltas.IdPeliDevuelta))
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
            return View(archiPeliDevueltas);
        }

        // GET: ArchiPeliDevueltas/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var archiPeliDevueltas = await _context.ArchiPeliDevueltas
                .FirstOrDefaultAsync(m => m.IdPeliDevuelta == id);
            if (archiPeliDevueltas == null)
            {
                return NotFound();
            }

            return View(archiPeliDevueltas);
        }

        // POST: ArchiPeliDevueltas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var archiPeliDevueltas = await _context.ArchiPeliDevueltas.FindAsync(id);
            _context.ArchiPeliDevueltas.Remove(archiPeliDevueltas);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ArchiPeliDevueltasExists(int id)
        {
            return _context.ArchiPeliDevueltas.Any(e => e.IdPeliDevuelta == id);
        }
    }
}
