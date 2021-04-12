using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MathiasMumbohWeb1001.Context;
using MathiasMumbohWeb1001.Pages.Models;

namespace MathiasMumbohWeb1001.Pages
{
    public class EditModel : PageModel
    {
        private readonly MathiasMumbohWeb1001.Context.DataContext _context;

        public EditModel(MathiasMumbohWeb1001.Context.DataContext context)
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

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(BlogClass).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BlogClassExists(BlogClass.Title))
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

        private bool BlogClassExists(string id)
        {
            return _context.Blogs.Any(e => e.Title == id);
        }
    }
}
