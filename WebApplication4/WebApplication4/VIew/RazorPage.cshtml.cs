using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WebApplication4.Model;
using WebApplication4.Models;

namespace WebApplication4.VIew
{
    public class RazorPageModel : PageModel
    {
        private readonly WebApplication4.Models.WebApplication4Context _context;

        public RazorPageModel(WebApplication4.Models.WebApplication4Context context)
        {
            _context = context;
        }

        public IList<Student> Student { get;set; }

        public async Task OnGetAsync()
        {
            Student = await _context.Student.ToListAsync();
        }
    }
}
