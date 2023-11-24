using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TreSorelle.Data;
using TreSorelle.Models;

namespace TreSorelle.Controllers
{
    public class ProdutoAvaliacaoController : Controller
    {
        private readonly AppDbContext _context;

        public ProdutoAvaliacaoController(AppDbContext context)
        {
            _context = context;
        }

        // GET: ProdutoAvaliacao
        public async Task<IActionResult> Index()
        {
            var appDbContext = _context.ProdutoAvaliacoes.Include(p => p.Produto).Include(p => p.Usuario);
            return View(await appDbContext.ToListAsync());
        }

        // GET: ProdutoAvaliacao/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.ProdutoAvaliacoes == null)
            {
                return NotFound();
            }

            var produtoAvaliacao = await _context.ProdutoAvaliacoes
                .Include(p => p.Produto)
                .Include(p => p.Usuario)
                .FirstOrDefaultAsync(m => m.ProdutoId == id);
            if (produtoAvaliacao == null)
            {
                return NotFound();
            }

            return View(produtoAvaliacao);
        }

        // GET: ProdutoAvaliacao/Create
        public IActionResult Create()
        {
            ViewData["ProdutoId"] = new SelectList(_context.Produtos, "Id", "Nome");
            ViewData["UsuarioId"] = new SelectList(_context.Usuarios, "UsuarioId", "UsuarioId");
            return View();
        }

        // POST: ProdutoAvaliacao/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ProdutoId,UsuarioId,AvaliacaoData,ProdutoNota")] ProdutoAvaliacao produtoAvaliacao)
        {
            if (ModelState.IsValid)
            {
                _context.Add(produtoAvaliacao);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["ProdutoId"] = new SelectList(_context.Produtos, "Id", "Nome", produtoAvaliacao.ProdutoId);
            ViewData["UsuarioId"] = new SelectList(_context.Usuarios, "UsuarioId", "UsuarioId", produtoAvaliacao.UsuarioId);
            return View(produtoAvaliacao);
        }

        // GET: ProdutoAvaliacao/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.ProdutoAvaliacoes == null)
            {
                return NotFound();
            }

            var produtoAvaliacao = await _context.ProdutoAvaliacoes.FindAsync(id);
            if (produtoAvaliacao == null)
            {
                return NotFound();
            }
            ViewData["ProdutoId"] = new SelectList(_context.Produtos, "Id", "Nome", produtoAvaliacao.ProdutoId);
            ViewData["UsuarioId"] = new SelectList(_context.Usuarios, "UsuarioId", "UsuarioId", produtoAvaliacao.UsuarioId);
            return View(produtoAvaliacao);
        }

        // POST: ProdutoAvaliacao/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ProdutoId,UsuarioId,AvaliacaoData,ProdutoNota")] ProdutoAvaliacao produtoAvaliacao)
        {
            if (id != produtoAvaliacao.ProdutoId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(produtoAvaliacao);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProdutoAvaliacaoExists(produtoAvaliacao.ProdutoId))
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
            ViewData["ProdutoId"] = new SelectList(_context.Produtos, "Id", "Nome", produtoAvaliacao.ProdutoId);
            ViewData["UsuarioId"] = new SelectList(_context.Usuarios, "UsuarioId", "UsuarioId", produtoAvaliacao.UsuarioId);
            return View(produtoAvaliacao);
        }

        // GET: ProdutoAvaliacao/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.ProdutoAvaliacoes == null)
            {
                return NotFound();
            }

            var produtoAvaliacao = await _context.ProdutoAvaliacoes
                .Include(p => p.Produto)
                .Include(p => p.Usuario)
                .FirstOrDefaultAsync(m => m.ProdutoId == id);
            if (produtoAvaliacao == null)
            {
                return NotFound();
            }

            return View(produtoAvaliacao);
        }

        // POST: ProdutoAvaliacao/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.ProdutoAvaliacoes == null)
            {
                return Problem("Entity set 'AppDbContext.ProdutoAvaliacoes'  is null.");
            }
            var produtoAvaliacao = await _context.ProdutoAvaliacoes.FindAsync(id);
            if (produtoAvaliacao != null)
            {
                _context.ProdutoAvaliacoes.Remove(produtoAvaliacao);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProdutoAvaliacaoExists(int id)
        {
          return _context.ProdutoAvaliacoes.Any(e => e.ProdutoId == id);
        }
    }
}
