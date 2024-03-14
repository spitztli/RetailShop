using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RetailShop.Data;
using RetailShop.Models;

namespace RetailShop.Pages.Personal
{
    public class DetailsModel : PageModel
    {
        private readonly RetailShop.Data.RetailShopContext _context;

        public DetailsModel(RetailShop.Data.RetailShopContext context)
        {
            _context = context;
        }

        public Mitarbeiter Mitarbeiter { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var mitarbeiter = await _context.Mitarbeiter.FirstOrDefaultAsync(m => m.Id == id);
            if (mitarbeiter == null)
            {
                return NotFound();
            }
            else
            {
                Mitarbeiter = mitarbeiter;
            }
            return Page();
        }
    }
}
