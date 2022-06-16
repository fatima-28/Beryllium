using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Beryllium.Models
{
    public class Testimonials
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public string Writer { get; set; }
        public bool  IsDeleted { get; set; }
    }
}
