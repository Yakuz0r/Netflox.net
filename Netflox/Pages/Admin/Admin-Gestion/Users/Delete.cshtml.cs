using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Netflox.Data;
using Netflox.Models;

namespace Netflox.Pages.Admin.Users
{
    public class DeleteModel : PageModel
    {
        private readonly Netflox.Data.DataContext _context;

        public DeleteModel(Netflox.Data.DataContext context)
        {
            _context = context;
        }

        [BindProperty]
        public MainUsers MainUsers { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            MainUsers = await _context.MainUsers.FirstOrDefaultAsync(m => m.MainUsersID == id);

            if (MainUsers == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            MainUsers = await _context.MainUsers.FindAsync(id);

            if (MainUsers != null)
            {
                _context.MainUsers.Remove(MainUsers);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
