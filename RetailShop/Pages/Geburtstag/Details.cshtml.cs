using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RetailShop.Data;
using RetailShop.Models;

namespace RetailShop.Pages.Geburtstag
{
    public class DetailsModel : PageModel
    {
        private readonly RetailShop.Data.RetailShopContext _context;

        public DetailsModel(RetailShop.Data.RetailShopContext context)
        {
            _context = context;
        }

        public Glist Glist { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var glist = await _context.Glist.FirstOrDefaultAsync(m => m.Id == id);
            if (glist == null)
            {
                return NotFound();
            }
            else
            {
                Glist = glist;
            }
            return Page();
        }
    }
}
