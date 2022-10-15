using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ELearnerApi.Models;

namespace ElearnerWebApp.Pages.Topics
{
    public class IndexModel : PageModel
    {
        private readonly ELearnerApi.Models.ElearnnerDBContext _context;

        public IndexModel(ELearnerApi.Models.ElearnnerDBContext context)
        {
            _context = context;
        }

        public IList<Topic> Topic { get;set; }

        public async Task OnGetAsync()
        {
            Topic = await _context.Topics.ToListAsync();
        }
    }
}
