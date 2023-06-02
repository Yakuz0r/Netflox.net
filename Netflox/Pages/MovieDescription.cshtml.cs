using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Netflox.Data;
using Netflox.Models;
using System.Threading.Tasks;

namespace Netflox.Pages
{
    public class MovieDescriptionModel : PageModel
    {
        private readonly Data.DataContext _dbContext;

        public Movie Movie { get; set; }

        public MovieDescriptionModel(DataContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IActionResult> OnGetAsync(int id)
        {
            Movie = await _dbContext.Movies.FindAsync(id);

            if (Movie == null)
            {
                return NotFound();
            }

            return Page();
        }
    }
}
