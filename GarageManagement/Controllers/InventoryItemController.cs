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
    public class InventoryItemController : Controller
    {
        private readonly ApplicationDbContext _context;

        public InventoryItemController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: InventoryItem
        public async Task<IActionResult> Index()
        {
              return _context.InventoryItems != null ? 
                          View(await _context.InventoryItems.ToListAsync()) :
                          Problem("Entity set 'ApplicationDbContext.InventoryItems'  is null.");
        }

        // GET: InventoryItem/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.InventoryItems == null)
            {
                return NotFound();
            }

            var inventoryItem = await _context.InventoryItems
                .FirstOrDefaultAsync(m => m.Id == id);
            if (inventoryItem == null)
            {
                return NotFound();
            }

            return View(inventoryItem);
        }

        // GET: InventoryItem/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: InventoryItem/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Description,Quantity,Price")] InventoryItem inventoryItem)
        {
            if (ModelState.IsValid)
            {
                _context.Add(inventoryItem);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(inventoryItem);
        }

        // GET: InventoryItem/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.InventoryItems == null)
            {
                return NotFound();
            }

            var inventoryItem = await _context.InventoryItems.FindAsync(id);
            if (inventoryItem == null)
            {
                return NotFound();
            }
            return View(inventoryItem);
        }

        // POST: InventoryItem/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Description,Quantity,Price")] InventoryItem inventoryItem)
        {
            if (id != inventoryItem.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(inventoryItem);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!InventoryItemExists(inventoryItem.Id))
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
            return View(inventoryItem);
        }

        // GET: InventoryItem/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.InventoryItems == null)
            {
                return NotFound();
            }

            var inventoryItem = await _context.InventoryItems
                .FirstOrDefaultAsync(m => m.Id == id);
            if (inventoryItem == null)
            {
                return NotFound();
            }

            return View(inventoryItem);
        }

        // POST: InventoryItem/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.InventoryItems == null)
            {
                return Problem("Entity set 'ApplicationDbContext.InventoryItems'  is null.");
            }
            var inventoryItem = await _context.InventoryItems.FindAsync(id);
            if (inventoryItem != null)
            {
                _context.InventoryItems.Remove(inventoryItem);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool InventoryItemExists(int id)
        {
          return (_context.InventoryItems?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
