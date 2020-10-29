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
    public class ArchiFichaSociosController : Controller
    {
        private readonly VIDEOTECContext _context;

        public ArchiFichaSociosController(VIDEOTECContext context)
        {
            _context = context;
        }

        // GET: ArchiFichaSocios
        public async Task<IActionResult> Index()
        {
            var vIDEOTECContext = _context.ArchiFichaSocio.Include(a => a.CodigoSocioNavigation);
            return View(await vIDEOTECContext.ToListAsync());
        }

        // GET: ArchiFichaSocios/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var archiFichaSocio = await _context.ArchiFichaSocio
                .Include(a => a.CodigoSocioNavigation)
                .FirstOrDefaultAsync(m => m.IdFichaSocio == id);
            if (archiFichaSocio == null)
            {
                return NotFound();
            }

            return View(archiFichaSocio);
        }

        // GET: ArchiFichaSocios/Create
        public IActionResult Create()
        {
            ViewData["CodigoSocio"] = new SelectList(_context.Socio, "Codigo_Socio", "Apellido_1");
            return View();
        }

        // POST: ArchiFichaSocios/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdFichaSocio,GeneroFavorito,ActoresFavorito,DirectoresFavorito,CodigoSocio")] ArchiFichaSocio archiFichaSocio)
        {
            if (ModelState.IsValid)
            {
                _context.Add(archiFichaSocio);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CodigoSocio"] = new SelectList(_context.Socio, "Codigo_Socio", "Apellido_1", archiFichaSocio.CodigoSocio);
            return View(archiFichaSocio);
        }

        // GET: ArchiFichaSocios/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var archiFichaSocio = await _context.ArchiFichaSocio.FindAsync(id);
            if (archiFichaSocio == null)
            {
                return NotFound();
            }
            ViewData["CodigoSocio"] = new SelectList(_context.Socio, "Codigo_Socio", "Apellido_1", archiFichaSocio.CodigoSocio);
            return View(archiFichaSocio);
        }

        // POST: ArchiFichaSocios/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdFichaSocio,GeneroFavorito,ActoresFavorito,DirectoresFavorito,CodigoSocio")] ArchiFichaSocio archiFichaSocio)
        {
            if (id != archiFichaSocio.IdFichaSocio)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(archiFichaSocio);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ArchiFichaSocioExists(archiFichaSocio.IdFichaSocio))
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
            ViewData["CodigoSocio"] = new SelectList(_context.Socio, "Codigo_Socio", "Apellido_1", archiFichaSocio.CodigoSocio);
            return View(archiFichaSocio);
        }

        // GET: ArchiFichaSocios/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var archiFichaSocio = await _context.ArchiFichaSocio
                .Include(a => a.CodigoSocioNavigation)
                .FirstOrDefaultAsync(m => m.IdFichaSocio == id);
            if (archiFichaSocio == null)
            {
                return NotFound();
            }

            return View(archiFichaSocio);
        }

        // POST: ArchiFichaSocios/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var archiFichaSocio = await _context.ArchiFichaSocio.FindAsync(id);
            _context.ArchiFichaSocio.Remove(archiFichaSocio);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ArchiFichaSocioExists(int id)
        {
            return _context.ArchiFichaSocio.Any(e => e.IdFichaSocio == id);
        }
    }
}
