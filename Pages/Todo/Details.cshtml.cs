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
    public class DetailsModel : PageModel
    {
        private readonly RazorTodoApp.Data.RazorTodoAppContext _context;

        public DetailsModel(RazorTodoApp.Data.RazorTodoAppContext context)
        {
            _context = context;
        }

      public Models.Todo Todo { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Todo == null)
            {
                return NotFound();
            }

            var todo = await _context.Todo.FirstOrDefaultAsync(m => m.Id == id);
            if (todo == null)
            {
                return NotFound();
            }
            else 
            {
                Todo = todo;
            }
            return Page();
        }
    }
}
