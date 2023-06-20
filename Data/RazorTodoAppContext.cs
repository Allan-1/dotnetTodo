using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RazorTodoApp.Models;

namespace RazorTodoApp.Data
{
    public class RazorTodoAppContext : DbContext
    {
        public RazorTodoAppContext (DbContextOptions<RazorTodoAppContext> options)
            : base(options)
        {
        }

        public DbSet<RazorTodoApp.Models.Todo> Todo { get; set; } = default!;
    }
}
