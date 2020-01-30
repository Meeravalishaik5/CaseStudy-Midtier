using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmartMvcCaseStudy.Models
{
    public class SubCategoryContext:DbContext
    {
        public SubCategoryContext(DbContextOptions<SubCategoryContext> options) : base(options)
        { }
        public DbSet<SubCategory> SubCategories { get; set; }
    }
}
