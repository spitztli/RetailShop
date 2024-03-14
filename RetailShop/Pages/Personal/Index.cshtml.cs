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
    public class IndexModel : PageModel
    {
        private readonly RetailShop.Data.RetailShopContext _context;

        public IndexModel(RetailShop.Data.RetailShopContext context)
        {
            _context = context;
        }

        public IList<Mitarbeiter> Mitarbeiter { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Mitarbeiter = await _context.Mitarbeiter.ToListAsync();
        }
    }
}
