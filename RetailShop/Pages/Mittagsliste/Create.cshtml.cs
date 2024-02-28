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

namespace RetailShop.Pages.Mittagsliste
{
    public class CreateModel : PageModel
    {
        private readonly RetailShop.Data.RetailShopContext _context;

        public CreateModel(RetailShop.Data.RetailShopContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Mlist Mlist { get; set; } = default!;

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Mlist.Add(Mlist);
            await _context.SaveChangesAsync();

            ModulMlist = await _context.Mlist.ToListAsync();

            return Page(); // Bleibe auf derselben Seite

            //return RedirectToPage("/Index");
        }
        public IList<Mlist> ModulMlist { get; set; }

    }
}
