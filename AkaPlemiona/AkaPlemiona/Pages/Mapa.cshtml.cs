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

    public class MapaModel : PageModel
    {
        private readonly SlavVVar.Models.SlavVVarContext _context;

        public MapaModel(SlavVVar.Models.SlavVVarContext context)
        {
            _context = context;
        }

        public List<Mapa> Mapa { get;set; }

        public async Task OnGetAsync()
        {
            Mapa = _context.Mapa.ToList();
        }
    }
}
