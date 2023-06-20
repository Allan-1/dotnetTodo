using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using RazorTodoApp.Data;
using RazorTodoApp.Models;

namespace RazorTodoApp.Pages.Todo
{
    public class CreateModel : PageModel
    {
        private readonly RazorTodoApp.Data.RazorTodoAppContext _context;

        public CreateModel(RazorTodoApp.Data.RazorTodoAppContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Models.Todo Todo { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.Todo == null || Todo == null)
            {
                return Page();
            }

            _context.Todo.Add(Todo);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
