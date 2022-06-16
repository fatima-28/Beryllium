using Beryllium.DAL;
using Beryllium.Helpers;
using Beryllium.Models;
using Microsoft.AspNetCore.Hosting;
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
        private IWebHostEnvironment _env { get; }
        private int counter { get; }
        public WorkController(AppDbContext context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
            counter = _context.Works.Count();
            works = _context.Works.Where(w =>!w.IsDeleted);


        }
        public IActionResult Index()
        {
            ViewBag.count = counter;
            return View(works);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public  async Task<IActionResult> Create(Work work)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            if (work.Photo.CheckFileType("image/"))
            {
                ModelState.AddModelError("Photo", "Image type error exist");
                return View();
            }
            if (work.Photo.CheckFileSize(200))
            {
                ModelState.AddModelError("Photo", "Image size error exist!");
                return View();

            }
            work.Image = await work.Photo.SaveFileAsync(_env.WebRootPath, "img");

           

            bool isExist = _context.Works.Where(w => !w.IsDeleted).Any(w => w.Title.ToLower() == work.Title.ToLower());

            if (isExist)
            {
                ModelState.AddModelError("Title", $"{work.Title} is already exist");
                return View();
            }
            if (work.Title==null)
            {
                ModelState.AddModelError("Title", $"Add Title!");
                return View();

            }
            if (work.Location==null)
            {
                ModelState.AddModelError("Location", $"Add Location!");
                return View();
            }

            Work newWorkTitle = new Work {

                Title = work.Title


            };
            
          
            Work newWorkLocation = new Work { 
            Location=work.Location
            };

            await _context.Works.AddAsync(work);
            await _context.Works.AddAsync(newWorkTitle);
            await _context.Works.AddAsync(newWorkLocation);
            await _context.SaveChangesAsync();

    

            return RedirectToAction(nameof(Index));


        }
        public IActionResult Update(int? id)
        {
            if (id == null)
            {
                return BadRequest();

            }

            Work work = _context.Works.Where(w => !w.IsDeleted).FirstOrDefault(w => w.Id == id);
            if (work == null)
            {
                return NotFound();

            }
            return View(work);

        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(int? id, Work work)
        {
            if (id == null)
                return BadRequest();


            Work workDb = _context.Works.Where(w => !w.IsDeleted).FirstOrDefault(w => w.Id == id);
            if (workDb == null)
                return NotFound();


            if (work.Title.ToLower() == workDb.Title.ToLower())
            { 
            return RedirectToAction(nameof(Index));
            }
            //if (work.Location.ToLower()==workDb.Location.ToLower())
            //{
            //    return RedirectToAction(nameof(Index));

            //}
            bool IsExistTitle = works.Any(w => w.Title.ToLower() == work.Title.ToLower());
            //bool IsExistLocation = works.Any(w => w.Location.ToLower() == work.Location.ToLower());

            //if (IsExistLocation)
            //{
            //    ModelState.AddModelError("Name", $"{work.Location} is exist");
            //    return View();
            //}

            if (IsExistTitle)
            {
                ModelState.AddModelError("Name", $"{work.Title} is exist");
                return View();
            }

            //workDb.Location = work.Location;
            workDb.Title = work.Title;
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return BadRequest();
            }
            Work workDb = _context.Works.Where(c => !c.IsDeleted).FirstOrDefault(w => w.Id == id);
            if (workDb == null)
                return NotFound();

            workDb.IsDeleted = true;
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }


    }
}
