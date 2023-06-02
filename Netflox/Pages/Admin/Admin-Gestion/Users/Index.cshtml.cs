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
    public class IndexModel : PageModel
    {
        private readonly Netflox.Data.DataContext _context;

        public IndexModel(Netflox.Data.DataContext context)
        {
            _context = context;
        }

        public IList<MainUsers> MainUsers { get;set; }

        public async Task OnGetAsync()
        {
            MainUsers = await _context.MainUsers.ToListAsync();
        }
    }
}
