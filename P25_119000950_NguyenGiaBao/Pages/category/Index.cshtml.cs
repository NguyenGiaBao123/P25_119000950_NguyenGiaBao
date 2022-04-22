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
    public class IndexModel : PageModel
    {
        private readonly RazorPagesMovieContext _context;

        public IndexModel(RazorPagesMovieContext context)
        {
            _context = context;
        }

        public IList<category> category { get;set; }

        public async Task OnGetAsync()
        {
            category = await _context.category.ToListAsync();
        }
    }
}
