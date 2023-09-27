using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using GarageManagement.Data;
using GarageManagement.Models;

namespace GarageManagement.Controllers
{
    public class MaintenanceRecordController : Controller
    {
        private readonly ApplicationDbContext _context;

        public MaintenanceRecordController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: MaintenanceRecord
        public async Task<IActionResult> Index()
        {
              return _context.MaintenanceRecords != null ? 
                          View(await _context.MaintenanceRecords.ToListAsync()) :
                          Problem("Entity set 'ApplicationDbContext.MaintenanceRecords'  is null.");
        }

        // GET: MaintenanceRecord/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.MaintenanceRecords == null)
            {
                return NotFound();
            }

            var maintenanceRecord = await _context.MaintenanceRecords
                .FirstOrDefaultAsync(m => m.Id == id);
            if (maintenanceRecord == null)
            {
                return NotFound();
            }

            return View(maintenanceRecord);
        }

        // GET: MaintenanceRecord/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: MaintenanceRecord/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Date,Cost,Workdone")] MaintenanceRecord maintenanceRecord)
        {
            if (ModelState.IsValid)
            {
                _context.Add(maintenanceRecord);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(maintenanceRecord);
        }

        // GET: MaintenanceRecord/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.MaintenanceRecords == null)
            {
                return NotFound();
            }

            var maintenanceRecord = await _context.MaintenanceRecords.FindAsync(id);
            if (maintenanceRecord == null)
            {
                return NotFound();
            }
            return View(maintenanceRecord);
        }

        // POST: MaintenanceRecord/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Date,Cost,Workdone")] MaintenanceRecord maintenanceRecord)
        {
            if (id != maintenanceRecord.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(maintenanceRecord);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MaintenanceRecordExists(maintenanceRecord.Id))
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
            return View(maintenanceRecord);
        }

        // GET: MaintenanceRecord/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.MaintenanceRecords == null)
            {
                return NotFound();
            }

            var maintenanceRecord = await _context.MaintenanceRecords
                .FirstOrDefaultAsync(m => m.Id == id);
            if (maintenanceRecord == null)
            {
                return NotFound();
            }

            return View(maintenanceRecord);
        }

        // POST: MaintenanceRecord/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.MaintenanceRecords == null)
            {
                return Problem("Entity set 'ApplicationDbContext.MaintenanceRecords'  is null.");
            }
            var maintenanceRecord = await _context.MaintenanceRecords.FindAsync(id);
            if (maintenanceRecord != null)
            {
                _context.MaintenanceRecords.Remove(maintenanceRecord);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MaintenanceRecordExists(int id)
        {
          return (_context.MaintenanceRecords?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
