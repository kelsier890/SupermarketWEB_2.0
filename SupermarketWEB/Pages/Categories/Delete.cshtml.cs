using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SupermarketWEB.Data;
using SupermarketWEB.Models;

namespace SupermarketWEB.Pages.Categories
{
	public class DeleteModel : PageModel
	{
		private readonly SumpermarketContext _context;

		public DeleteModel(SumpermarketContext context)
		{
			_context = context;

		}

		[BindProperty]
		public Category Category { get; set; } = default!;

		public async Task<IActionResult> OnGetAsync(int? id)
		{
			if(id==null || _context.Categories == null)
			{
				return NotFound();
			}
			
			var category = await _context.Categories.FirstOrDefaultAsync(m => m.Id == id);
			if(category == null)
			{
				return NotFound();
			}
			else
			{
				category = category;
			}
			return Page();

		}


    }
}
