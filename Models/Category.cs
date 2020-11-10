using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogDuLich.Models
{
    public class Category
    {
        public int CategoryID { get; set; }
        public string NameCategory { get; set; }
        public string ImageUrl { get; set; }
        public string Description { get; set; }
        public string CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public string Status { get; set; }
    }
}
