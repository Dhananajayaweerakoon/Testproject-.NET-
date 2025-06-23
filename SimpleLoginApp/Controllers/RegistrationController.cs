using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SimpleLoginApp.Data;
using SimpleLoginApp.Models;

namespace SimpleLoginApp.Controllers
{
    public class RegistrationController : Controller
    {
        private readonly ApplicationDbContext _context;

        public RegistrationController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Registration
        public async Task<IActionResult> Index()
        {
            return View(await _context.Registrations.ToListAsync());
        }

        // GET: Registration/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Registration/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("PersonId,Name,Age")] RegistrationModel registration)
        {
            if (ModelState.IsValid)
            {
                registration.RegistrationDate = DateTime.Now;
                _context.Add(registration);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Details), new { id = registration.Id });
            }
            return View(registration);
        }

        // GET: Registration/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var registration = await _context.Registrations
                .FirstOrDefaultAsync(m => m.Id == id);
            if (registration == null)
            {
                return NotFound();
            }

            return View(registration);
        }
    }
} 