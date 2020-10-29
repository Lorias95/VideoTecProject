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
    public class ListaEsperasController : Controller
    {
        private readonly VIDEOTECContext _context;

        public ListaEsperasController(VIDEOTECContext context)
        {
            _context = context;
        }

        // GET: ListaEsperas
        public async Task<IActionResult> Index()
        {
            var vIDEOTECContext = _context.ListaEspera.Include(l => l.IdFichaNavigation);
            return View(await vIDEOTECContext.ToListAsync());
        }

        // GET: ListaEsperas/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var listaEspera = await _context.ListaEspera
                .Include(l => l.IdFichaNavigation)
                .FirstOrDefaultAsync(m => m.IdListaEspera == id);
            if (listaEspera == null)
            {
                return NotFound();
            }

            return View(listaEspera);
        }

        // GET: ListaEsperas/Create
        public IActionResult Create()
        {
            ViewData["IdFicha"] = new SelectList(_context.Ficha, "IdFicha", "Pelicula");
            return View();
        }

        // POST: ListaEsperas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdListaEspera,CantidadSocios,TiempoEspera,IdFicha")] ListaEspera listaEspera)
        {
            if (ModelState.IsValid)
            {
                _context.Add(listaEspera);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["IdFicha"] = new SelectList(_context.Ficha, "IdFicha", "Pelicula", listaEspera.IdFicha);
            return View(listaEspera);
        }

        // GET: ListaEsperas/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var listaEspera = await _context.ListaEspera.FindAsync(id);
            if (listaEspera == null)
            {
                return NotFound();
            }
            ViewData["IdFicha"] = new SelectList(_context.Ficha, "IdFicha", "Pelicula", listaEspera.IdFicha);
            return View(listaEspera);
        }

        // POST: ListaEsperas/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdListaEspera,CantidadSocios,TiempoEspera,IdFicha")] ListaEspera listaEspera)
        {
            if (id != listaEspera.IdListaEspera)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(listaEspera);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ListaEsperaExists(listaEspera.IdListaEspera))
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
            ViewData["IdFicha"] = new SelectList(_context.Ficha, "IdFicha", "Pelicula", listaEspera.IdFicha);
            return View(listaEspera);
        }

        // GET: ListaEsperas/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var listaEspera = await _context.ListaEspera
                .Include(l => l.IdFichaNavigation)
                .FirstOrDefaultAsync(m => m.IdListaEspera == id);
            if (listaEspera == null)
            {
                return NotFound();
            }

            return View(listaEspera);
        }

        // POST: ListaEsperas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var listaEspera = await _context.ListaEspera.FindAsync(id);
            _context.ListaEspera.Remove(listaEspera);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ListaEsperaExists(int id)
        {
            return _context.ListaEspera.Any(e => e.IdListaEspera == id);
        }
    }
}
