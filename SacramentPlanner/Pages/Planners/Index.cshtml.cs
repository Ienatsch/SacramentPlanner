using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MeetingPlanner.Models;
using SacramentPlanner.Data;

namespace SacramentPlanner
{
    public class IndexModel : PageModel
    {
        private readonly SacramentPlanner.Data.SacramentPlannerContext _context;

        public IndexModel(SacramentPlanner.Data.SacramentPlannerContext context)
        {
            _context = context;
        }

        public IList<Planner> Planner { get;set; }

        public async Task OnGetAsync()
        {
            Planner = await _context.Planner.ToListAsync();
        }
    }
}
