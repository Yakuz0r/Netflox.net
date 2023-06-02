using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Netflox.Data;
using Netflox.Models;

namespace Netflox.Pages.Admin.Users
{
    public class CreateModel : PageModel
    {
        private readonly Netflox.Data.DataContext _context;

        public CreateModel(Netflox.Data.DataContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public MainUsers MainUsers { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.MainUsers.Add(MainUsers);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
