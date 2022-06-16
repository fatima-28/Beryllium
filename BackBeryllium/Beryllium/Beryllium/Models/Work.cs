using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Beryllium.Models
{
    public class Work
    {
        public int Id { get; set; }
        public string Image { get; set; }
        public string Title { get; set; }
        public string Location { get; set; }
        public bool IsDeleted { get; set; }
        [NotMapped,Required]
        public IFormFile Photo { get; set; }
    }
}
