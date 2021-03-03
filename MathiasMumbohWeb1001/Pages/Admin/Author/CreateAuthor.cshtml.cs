using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MathiasMumbohWeb1001.Pages.Models;

namespace MathiasMumbohWeb1001.Pages.AdminFolder.Author
{
    public class CreateAuthorModel : PageModel
    {
        public void OnGet()
        {
          
        }

        public void OnPost()
        {

        }

        [FromForm]
        public AuthorClass AuthorClass { get; set; }
    }
}
