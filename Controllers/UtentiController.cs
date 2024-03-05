using AziendaSpedizioni.Dati;
using AziendaSpedizioni.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace AziendaSpedizioni.Controllers
{
    public class UtentiController : Controller
    {
        private readonly  MyDbContext _context;

        public UtentiController(MyDbContext context)
        {
            _context = context;
        }

        // GET: Utenti
        public async Task<ActionResult> Index()
        {
            var utenti = await _context.Utenti.ToListAsync();
            return View(utenti);
        }

        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var utente = await _context.Utenti
                .FirstOrDefaultAsync(m => m.IdUtente == id);
            if (utente == null)
            {
                return NotFound();
            }

            return View(utente);
        }

        private ActionResult NotFound()
        {
            throw new NotImplementedException();
        }

        // GET: Utenti/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Utenti/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind] Utente utente)
        {
            if (ModelState.IsValid)
            {
                _context.Add(utente);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(utente);
        }

        private bool UtenteExists(int id)
        {
            return _context.Utenti.Any(e => e.IdUtente == id);
        }
    }
}