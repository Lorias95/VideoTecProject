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
    public class ArchiPeliPorTituloesController : Controller
    {
        private readonly VIDEOTECContext _context;

        public ArchiPeliPorTituloesController(VIDEOTECContext context)
        {
            _context = context;
        }

        // GET: ArchiPeliPorTituloes
        public async Task<IActionResult> Index()
        {
            return View(await _context.ArchiPeliPorTitulo.ToListAsync());
        }

        // GET: ArchiPeliPorTituloes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var archiPeliPorTitulo = await _context.ArchiPeliPorTitulo
                .FirstOrDefaultAsync(m => m.IdPeliPorTitulo == id);
            if (archiPeliPorTitulo == null)
            {
                return NotFound();
            }

            return View(archiPeliPorTitulo);
        }

        // GET: ArchiPeliPorTituloes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ArchiPeliPorTituloes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdPeliPorTitulo,Titulo,Duracion,NumCintas,Genero,Actores,Directores")] ArchiPeliPorTitulo archiPeliPorTitulo)
        {
            if (ModelState.IsValid)
            {
                _context.Add(archiPeliPorTitulo);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(archiPeliPorTitulo);
        }

        // GET: ArchiPeliPorTituloes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var archiPeliPorTitulo = await _context.ArchiPeliPorTitulo.FindAsync(id);
            if (archiPeliPorTitulo == null)
            {
                return NotFound();
            }
            return View(archiPeliPorTitulo);
        }

        // POST: ArchiPeliPorTituloes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdPeliPorTitulo,Titulo,Duracion,NumCintas,Genero,Actores,Directores")] ArchiPeliPorTitulo archiPeliPorTitulo)
        {
            if (id != archiPeliPorTitulo.IdPeliPorTitulo)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(archiPeliPorTitulo);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ArchiPeliPorTituloExists(archiPeliPorTitulo.IdPeliPorTitulo))
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
            return View(archiPeliPorTitulo);
        }

        // GET: ArchiPeliPorTituloes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var archiPeliPorTitulo = await _context.ArchiPeliPorTitulo
                .FirstOrDefaultAsync(m => m.IdPeliPorTitulo == id);
            if (archiPeliPorTitulo == null)
            {
                return NotFound();
            }

            return View(archiPeliPorTitulo);
        }

        // POST: ArchiPeliPorTituloes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var archiPeliPorTitulo = await _context.ArchiPeliPorTitulo.FindAsync(id);
            _context.ArchiPeliPorTitulo.Remove(archiPeliPorTitulo);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ArchiPeliPorTituloExists(int id)
        {
            return _context.ArchiPeliPorTitulo.Any(e => e.IdPeliPorTitulo == id);
        }
    }
}
