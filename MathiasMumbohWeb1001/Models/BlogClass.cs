using MathiasMumbohWeb1001.Pages.Models;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using System;
using System.ComponentModel.DataAnnotations;

namespace MathiasMumbohWeb1001.Pages.Models
{
    public class BlogClass
    {
        public string Title { get; set; }

        public string Content { get; set; }

        [Required]
        public string Author { get; set; }

        [DataType(DataType.Date)]
        public int PublishDate { get; set; }

        public AuthorClass AuthorClass { get; set; }
    }
}

