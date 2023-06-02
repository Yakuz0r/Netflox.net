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
    public class DetailsModel : PageModel
    {
        private readonly Netflox.Data.DataContext _context;

        public DetailsModel(Netflox.Data.DataContext context)
        {
            _context = context;
        }

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
    }
}
