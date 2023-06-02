using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Netflox.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Netflox.Pages
{
    public class MoviesModel : PageModel
    {
        private readonly Netflox.Data.DataContext _context;

        public MoviesModel(Netflox.Data.DataContext context)
        {
            _context = context;
        }

        public IList<Movie> Movie { get; set; }

        public async Task OnGetAsync()
        {
            Movie = await _context.Movies.ToListAsync();
        }
    }
}

