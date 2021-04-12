using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MathiasMumbohWeb1001.Context;
using MathiasMumbohWeb1001.Pages.Models;

namespace MathiasMumbohWeb1001.Pages
{
    public class DeleteModel : PageModel
    {
        private readonly MathiasMumbohWeb1001.Context.DataContext _context;

        public DeleteModel(MathiasMumbohWeb1001.Context.DataContext context)
        {
            _context = context;
        }

        [BindProperty]
        public BlogClass BlogClass { get; set; }

        public async Task<IActionResult> OnGetAsync(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            BlogClass = await _context.Blogs.FirstOrDefaultAsync(m => m.Title == id);

            if (BlogClass == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            BlogClass = await _context.Blogs.FindAsync(id);

            if (BlogClass != null)
            {
                _context.Blogs.Remove(BlogClass);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
