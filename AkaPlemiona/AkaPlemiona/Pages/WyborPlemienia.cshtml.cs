﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SlavVVar.Models;

namespace SlavVVar
{
    public class WyborPlemienia : PageModel
    {
        private readonly SlavVVar.Models.SlavVVarContext _context;

        public WyborPlemienia(SlavVVar.Models.SlavVVarContext context)
        {
            _context = context;
        }

        public Wojska Wojska { get;set; }
        public UserData UserData { get; set; }
        public PoziomyBudynkow PoziomyBudynkow { get; set; }
        public int idUser = 0;

        public async Task OnGetAsync()
        {
            Wojska = _context.Wojska.Where(o => o.Id == idUser).FirstOrDefault();
            UserData = _context.UserData.Where(o => o.Id == idUser).FirstOrDefault();
            PoziomyBudynkow = _context.PoziomyBudynkow.Where(o => o.Id == idUser).FirstOrDefault();
        }
    }
}
