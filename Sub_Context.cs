using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EMART.Models
{
    public class Sub_Context:DbContext
    {
        public Sub_Context(DbContextOptions<Sub_Context> options) : base(options) { }
        public DbSet<SubCategory> subcat { get; set; }
    }
}
