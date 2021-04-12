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
    public class IndexModel : PageModel
    {
        private readonly MathiasMumbohWeb1001.Context.DataContext _context;

        public IndexModel(MathiasMumbohWeb1001.Context.DataContext context)
        {
            _context = context;
        }

        public IList<BlogClass> BlogClass { get;set; }

        public async Task OnGetAsync()
        {

            BlogClass = await _context.Blogs.ToListAsync();
        }
    }
}
