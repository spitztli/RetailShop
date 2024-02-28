using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RetailShop.Data;
using RetailShop.Models;

namespace RetailShop.Pages.Mittagsliste
{
    public class DeleteModel : PageModel
    {
        private readonly RetailShop.Data.RetailShopContext _context;

        public DeleteModel(RetailShop.Data.RetailShopContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Mlist Mlist { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var mlist = await _context.Mlist.FirstOrDefaultAsync(m => m.Id == id);

            if (mlist == null)
            {
                return NotFound();
            }
            else
            {
                Mlist = mlist;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var mlist = await _context.Mlist.FindAsync(id);
            if (mlist != null)
            {
                Mlist = mlist;
                _context.Mlist.Remove(Mlist);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("/Index");
        }
    }
}
