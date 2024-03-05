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
    public class StatoSpedizioniController : Controller
    {
        private readonly MyDbContext _context;

        public StatoSpedizioniController(MyDbContext context)
        {
            _context = context;
        }
        // GET: AggiornamentiSpedizione
        public async Task<ActionResult> Index()
        {
            var aggiornamenti = await _context.StatoSpedizioni.ToListAsync();
            return View(aggiornamenti);
        }

        // GET: AggiornamentiSpedizione/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var aggiornamento = await _context.StatoSpedizioni
                .FirstOrDefaultAsync(m => m.IdSpedizione == id);
            if (aggiornamento == null)
            {
                return NotFound();
            }

            return View(aggiornamento);
        }

        private ActionResult NotFound()
        {
            throw new NotImplementedException();
        }

        // GET: AggiornamentiSpedizione/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AggiornamentiSpedizione/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind] StatoSpedizione StatoSpedizioni)
        {
            if (ModelState.IsValid)
            {
                _context.Add(StatoSpedizioni);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(StatoSpedizioni);
        }

        // altre azioni per le operazioni CRUD

        private bool AggiornamentoSpedizioneExists(int id)
        {
            return _context.StatoSpedizioni.Any(e => e.IdSpedizione == id);
        }
    }
}