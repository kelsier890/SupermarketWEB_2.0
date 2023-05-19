using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SupermarketWEB.Data;
using SupermarketWEB.Models;

namespace SupermarketWEB.Pages.Categories
{
    [Authorize]
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
        private readonly SumpermarketContext _context;
        public IndexModel(SumpermarketContext context)
        {
            _context = context;
        }
        public  IList<Category> Categories { get; set; } = default!;

        public async Task OneGetAsync()
        {
            if (_context.Categories != null)
            {
                Categories=await _context.Categories.ToListAsync();
            }
        }
    }
}
