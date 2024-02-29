using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using RetailShop.Data;
using RetailShop.Models;

namespace RetailShop.Pages.Geburtstag
{
    public class EditModel : PageModel
    {
        private readonly RetailShop.Data.RetailShopContext _context;

        public EditModel(RetailShop.Data.RetailShopContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Glist Glist { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var glist =  await _context.Glist.FirstOrDefaultAsync(m => m.Id == id);
            if (glist == null)
            {
                return NotFound();
            }
            Glist = glist;
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Glist).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!GlistExists(Glist.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool GlistExists(int id)
        {
            return _context.Glist.Any(e => e.Id == id);
        }
    }
}
