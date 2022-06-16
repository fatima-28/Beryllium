using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Beryllium.Models
{
    public class News
    {
        public int Id { get; set; }
        public string Date { get; set; }
        public string Title { get; set; }
        public string  Description { get; set; }
        public bool IsDeleted { get; set; }
    }
}
