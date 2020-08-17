using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SlavVVar.Models;

namespace SlavVVar
{
    public class IndexModel : PageModel
    {
        private readonly SlavVVar.Models.SlavVVarContext _context;

        public IndexModel(SlavVVar.Models.SlavVVarContext context)
        {
            _context = context;
        }

        public IList<Users> Users { get;set; }

        public async Task OnGetAsync()
        {
            Users = await _context.Users.ToListAsync();
        }
    }
}
