using Beryllium.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Beryllium.ViewModels
{
    public class HomeViewModel
    {
        public List<Slide> Slides { get; set; }
        public List<Work> Works { get; set; }
        public List<News> News { get; set; }
        public List<Testimonials> Testimonials { get; set; }

    }
}
