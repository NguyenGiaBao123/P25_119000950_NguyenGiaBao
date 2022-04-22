#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using P25_119000950_NguyenGiaBao.Models;

namespace P25_119000950_NguyenGiaBao.Pages_category
{
    public class DetailsModel : PageModel
    {
        private readonly RazorPagesMovieContext _context;

        public DetailsModel(RazorPagesMovieContext context)
        {
            _context = context;
        }

        public category category { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            category = await _context.category.FirstOrDefaultAsync(m => m.Id == id);

            if (category == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
