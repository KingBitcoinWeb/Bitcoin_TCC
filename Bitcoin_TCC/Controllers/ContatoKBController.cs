using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Bitcoin_TCC.Models;

namespace Bitcoin_TCC.Controllers
{
    public class ContatoKBController : Controller
    {
        private readonly Bitcoin_TCCContext _context;

        public ContatoKBController(Bitcoin_TCCContext context)
        {
            _context = context;
        }

        // GET: ContatoKB
        public async Task<IActionResult> Index2()
        {
            return View(await _context.ContatoKB.ToListAsync());
        }

        // GET: ContatoKB/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var contatoKB = await _context.ContatoKB
                .FirstOrDefaultAsync(m => m.ID == id);
            if (contatoKB == null)
            {
                return NotFound();
            }

            return View(contatoKB);
        }

        // GET: ContatoKB/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ContatoKB/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,Nome,Email,Mensagem")] ContatoKB contatoKB)
        {
            if (ModelState.IsValid)
            {
                _context.Add(contatoKB);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Create));
            }
            return View(contatoKB);
        }

        // GET: ContatoKB/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var contatoKB = await _context.ContatoKB.FindAsync(id);
            if (contatoKB == null)
            {
                return NotFound();
            }
            return View(contatoKB);
        }

        // POST: ContatoKB/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,Nome,Email,Mensagem")] ContatoKB contatoKB)
        {
            if (id != contatoKB.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(contatoKB);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ContatoKBExists(contatoKB.ID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index2));
            }
            return View(contatoKB);
        }

        // GET: ContatoKB/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var contatoKB = await _context.ContatoKB
                .FirstOrDefaultAsync(m => m.ID == id);
            if (contatoKB == null)
            {
                return NotFound();
            }

            return View(contatoKB);
        }

        // POST: ContatoKB/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var contatoKB = await _context.ContatoKB.FindAsync(id);
            _context.ContatoKB.Remove(contatoKB);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index2));
        }

        private bool ContatoKBExists(int id)
        {
            return _context.ContatoKB.Any(e => e.ID == id);
        }
    }
}
