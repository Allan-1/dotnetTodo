using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorTodoApp.Data;
using RazorTodoApp.Models;

namespace RazorTodoApp.Pages.Todo
{
    public class IndexModel : PageModel
    {
        private readonly RazorTodoApp.Data.RazorTodoAppContext _context;

        public IndexModel(RazorTodoApp.Data.RazorTodoAppContext context)
        {
            _context = context;
        }

        public IList<Models.Todo> Todo { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Todo != null)
            {
                Todo = await _context.Todo.ToListAsync();
            }
        }
    }
}
