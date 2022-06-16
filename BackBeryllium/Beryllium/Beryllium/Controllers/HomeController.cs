using Beryllium.DAL;
using Beryllium.Models;
using Beryllium.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Beryllium.Controllers
{
    public class HomeController : Controller
    {

        private AppDbContext _context { get; }

        public HomeController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
       {
            HomeViewModel home = new HomeViewModel()
            {
                Slides = _context.Slides.ToList(),
                Works = _context.Works.Where(w => !w.IsDeleted).ToList(),
                News = _context.News.Where(n => !n.IsDeleted).ToList(),
                Testimonials=_context.Testimonials.Where(t=>!t.IsDeleted).ToList()
            };
            return View(home);
        }
    }
}
