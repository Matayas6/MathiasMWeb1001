using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MathiasMumbohWeb1001.Pages.Models;

namespace MathiasMumbohWeb1001.Context
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options)
            : base(options)
        {

        }
        public DbSet <AuthorClass> Authors { get; set; }

        public DbSet<BlogClass> Blogs { get; set; }
    }
}
