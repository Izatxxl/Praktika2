using Microsoft.AspNetCore.Mvc;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

public class EquipmentController : Controller
{
    private readonly ApplicationDbContext _context;

    public EquipmentController(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<IActionResult> Index()
    {
        return View(await _context.Equipments.ToListAsync());
    }

    public IActionResult Create()
    {
        return View();
    }

    [HttpPost]
    public async Task<IActionResult> Create(Equipment equipment)
    {
        if (ModelState.IsValid)
        {
            _context.Add(equipment);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        return View(equipment);
    }
}
