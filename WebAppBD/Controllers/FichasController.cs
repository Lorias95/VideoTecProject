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
    public class FichasController : Controller
    {
        private readonly VIDEOTECContext _context;

        public FichasController(VIDEOTECContext context)
        {
            _context = context;
        }

        // GET: Fichas
        public async Task<IActionResult> Index()
        {
            var vIDEOTECContext = _context.Ficha.Include(f => f.CodigoSocioNavigation).Include(f => f.IdFichaSocioNavigation).Include(f => f.IdPeliDevueltaNavigation).Include(f => f.IdPeliPorTituloNavigation).Include(f => f.IdPeliPrestadaNavigation);
            return View(await vIDEOTECContext.ToListAsync());
        }

        // GET: Fichas/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ficha = await _context.Ficha
                .Include(f => f.CodigoSocioNavigation)
                .Include(f => f.IdFichaSocioNavigation)
                .Include(f => f.IdPeliDevueltaNavigation)
                .Include(f => f.IdPeliPorTituloNavigation)
                .Include(f => f.IdPeliPrestadaNavigation)
                .FirstOrDefaultAsync(m => m.IdFicha == id);
            if (ficha == null)
            {
                return NotFound();
            }

            return View(ficha);
        }

        // GET: Fichas/Create
        public IActionResult Create()
        {
            ViewData["CodigoSocio"] = new SelectList(_context.Socio, "Codigo_Socio", "Nombre");
            ViewData["IdFichaSocio"] = new SelectList(_context.ArchiFichaSocio, "IdFichaSocio", "IdFichaSocio");
            ViewData["IdPeliDevuelta"] = new SelectList(_context.ArchiPeliDevueltas, "IdPeliDevuelta", "IdPeliDevuelta");
            ViewData["IdPeliPorTitulo"] = new SelectList(_context.ArchiPeliPorTitulo, "IdPeliPorTitulo", "IdPeliPorTitulo");
            ViewData["IdPeliPrestada"] = new SelectList(_context.ArchiPeliPrestadas, "IdPeliPrestada", "IdPeliPrestada");
            return View();
        }

        // POST: Fichas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdFicha,Fecha,NumCinta,Pelicula,CodigoSocio,IdPeliPrestada,IdPeliDevuelta,IdPeliPorTitulo,IdFichaSocio")] Ficha ficha)
        {
            if (ModelState.IsValid)
            {
                _context.Add(ficha);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CodigoSocio"] = new SelectList(_context.Socio, "Codigo_Socio", "Nombre", ficha.CodigoSocio);
            ViewData["IdFichaSocio"] = new SelectList(_context.ArchiFichaSocio, "IdFichaSocio", "IdFichaSocio", ficha.IdFichaSocio);
            ViewData["IdPeliDevuelta"] = new SelectList(_context.ArchiPeliDevueltas, "IdPeliDevuelta", "IdPeliDevuelta", ficha.IdPeliDevuelta);
            ViewData["IdPeliPorTitulo"] = new SelectList(_context.ArchiPeliPorTitulo, "IdPeliPorTitulo", "IdPeliPorTitulo", ficha.IdPeliPorTitulo);
            ViewData["IdPeliPrestada"] = new SelectList(_context.ArchiPeliPrestadas, "IdPeliPrestada", "IdPeliPrestada", ficha.IdPeliPrestada);
            return View(ficha);
        }

        // GET: Fichas/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ficha = await _context.Ficha.FindAsync(id);
            if (ficha == null)
            {
                return NotFound();
            }
            ViewData["CodigoSocio"] = new SelectList(_context.Socio, "Codigo_Socio", "Nombre", ficha.CodigoSocio);
            ViewData["IdFichaSocio"] = new SelectList(_context.ArchiFichaSocio, "IdFichaSocio", "IdFichaSocio", ficha.IdFichaSocio);
            ViewData["IdPeliDevuelta"] = new SelectList(_context.ArchiPeliDevueltas, "IdPeliDevuelta", "IdPeliDevuelta", ficha.IdPeliDevuelta);
            ViewData["IdPeliPorTitulo"] = new SelectList(_context.ArchiPeliPorTitulo, "IdPeliPorTitulo", "IdPeliPorTitulo", ficha.IdPeliPorTitulo);
            ViewData["IdPeliPrestada"] = new SelectList(_context.ArchiPeliPrestadas, "IdPeliPrestada", "IdPeliPrestada", ficha.IdPeliPrestada);
            return View(ficha);
        }

        // POST: Fichas/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdFicha,Fecha,NumCinta,Pelicula,CodigoSocio,IdPeliPrestada,IdPeliDevuelta,IdPeliPorTitulo,IdFichaSocio")] Ficha ficha)
        {
            if (id != ficha.IdFicha)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(ficha);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!FichaExists(ficha.IdFicha))
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
            ViewData["CodigoSocio"] = new SelectList(_context.Socio, "Codigo_Socio", "Nombre", ficha.CodigoSocio);
            ViewData["IdFichaSocio"] = new SelectList(_context.ArchiFichaSocio, "IdFichaSocio", "IdFichaSocio", ficha.IdFichaSocio);
            ViewData["IdPeliDevuelta"] = new SelectList(_context.ArchiPeliDevueltas, "IdPeliDevuelta", "IdPeliDevuelta", ficha.IdPeliDevuelta);
            ViewData["IdPeliPorTitulo"] = new SelectList(_context.ArchiPeliPorTitulo, "IdPeliPorTitulo", "IdPeliPorTitulo", ficha.IdPeliPorTitulo);
            ViewData["IdPeliPrestada"] = new SelectList(_context.ArchiPeliPrestadas, "IdPeliPrestada", "IdPeliPrestada", ficha.IdPeliPrestada);
            return View(ficha);
        }

        // GET: Fichas/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ficha = await _context.Ficha
                .Include(f => f.CodigoSocioNavigation)
                .Include(f => f.IdFichaSocioNavigation)
                .Include(f => f.IdPeliDevueltaNavigation)
                .Include(f => f.IdPeliPorTituloNavigation)
                .Include(f => f.IdPeliPrestadaNavigation)
                .FirstOrDefaultAsync(m => m.IdFicha == id);
            if (ficha == null)
            {
                return NotFound();
            }

            return View(ficha);
        }

        // POST: Fichas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var ficha = await _context.Ficha.FindAsync(id);
            _context.Ficha.Remove(ficha);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool FichaExists(int id)
        {
            return _context.Ficha.Any(e => e.IdFicha == id);
        }
    }
}
