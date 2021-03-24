using System;
using System.Collections.Generic;
using System.Linq;
using MathiasMumbohWeb1001.Pages.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace MathiasMumbohWeb1001.Page.Admin.Blog
{
    public class CreateBlogModel : PageModel
    {
        [FromForm]
        public BlogClass BlogClass { get; set; } = new BlogClass();

        private List<AuthorClass> Authors { get; set; } = new List<AuthorClass>();

        public IEnumerable<SelectListItem> AuthorList { get; private set; }

        public CreateBlogModel()
        {
            AuthorClass a = new AuthorClass()
            {
                First_Name = "Thomas",
                Last_Name = "Keigh",
                Email = "thomas.k@gmail.com",
            };

            AuthorClass b = new AuthorClass()
            {
                First_Name = "Boris",
                Last_Name = "Smart",
                Email = "boris.S@gmail.com",
            };

            AuthorClass c = new AuthorClass()
            {
                First_Name = "McGill",
                Last_Name = "Trent",
                Email = "mcgill.t@gmail.com",
            };

            Authors.Add(a);
            Authors.Add(b);
            Authors.Add(c);
        }

        public void OnGet()
        {

            AuthorList = Authors.Select(autho =>
            {
                return new SelectListItem
                (String.Format("{0} ({1}) ({2})", autho.First_Name, autho.Last_Name, autho.Email), autho.Email);
            });
        }

        public void OnPost()
        {

        }
    }
}
