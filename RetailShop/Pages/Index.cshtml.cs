using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RetailShop.Models;

namespace RetailShop.Pages
{
    public class IndexModel : PageModel
    {

        private readonly RetailShop.Data.RetailShopContext _context;

        public IndexModel(RetailShop.Data.RetailShopContext context)
        {
            _context = context;
        }

        public IList<Mlist> Mlist { get; set; } = default!;
        
        public IList<Mitarbeiter> Mitarbeiter { get; set; } = default!;



        public async Task OnGetAsync()
        {
            Mlist = await _context.Mlist.ToListAsync();

            var heute = DateTime.Today;
            Mitarbeiter = await _context.Mitarbeiter
                .Where(p => p.Geburtstag.Month == heute.Month && p.Geburtstag.Day == heute.Day)
                .ToListAsync();


           
        }
    }
}
 