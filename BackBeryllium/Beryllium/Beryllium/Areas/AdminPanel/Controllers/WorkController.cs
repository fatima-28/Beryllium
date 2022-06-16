using Beryllium.DAL;
using Beryllium.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Beryllium.Areas.AdminPanel.Controllers
{
    [Area("AdminPanel")]
    public class WorkController : Controller
    {
        private AppDbContext _context { get;  }
        public IEnumerable<Work> works { get; set; }

        public WorkController(AppDbContext context)
        {
            _context = context;
            works = _context.Works.Where(w =>!w.IsDeleted);


        }
        public IActionResult Index()
        {
            return View(works);
        }
        public IActionResult Create()
        {
            return View();
        }
    }
}
