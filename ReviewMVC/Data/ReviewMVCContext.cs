using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ReviewMVC.Models
{
    public class ReviewMVCContext : DbContext
    {
        public ReviewMVCContext (DbContextOptions<ReviewMVCContext> options)
            : base(options)
        {
        }

        public DbSet<ReviewMVC.Models.Department> Department { get; set; }
    }
}
