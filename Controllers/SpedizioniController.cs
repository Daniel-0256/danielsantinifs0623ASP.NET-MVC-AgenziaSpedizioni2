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
    public class SpedizioniController : Controller
    {
        private readonly MyDbContext _context;

        public SpedizioniController(MyDbContext context)
        {
            _context = context;
        }

        // GET: Spedizioni
        public async Task<ActionResult> Index()
        {
            var spedizioni = await _context.Spedizioni.ToListAsync();
            return View(spedizioni);
        }

        // GET: Spedizioni/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var spedizione = await _context.Spedizioni
                .FirstOrDefaultAsync(m => m.IdSpedizione == id);
            if (spedizione == null)
            {
                return NotFound();
            }

            return View(spedizione);
        }

        private ActionResult NotFound()
        {
            throw new NotImplementedException();
        }

        // GET: Spedizioni/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Spedizioni/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind] Spedizione spedizione)
        {
            if (ModelState.IsValid)
            {
                _context.Add(spedizione);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(spedizione);
        }

        private bool SpedizioneExists(int id)
        {
            return _context.Spedizioni.Any(e => e.IdSpedizione == id);
        }
    }
}