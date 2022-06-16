﻿using Beryllium.DAL;
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
                Slides = _context.Slides.ToList()
            };
            return View(home);
        }
    }
}
