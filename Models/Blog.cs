using System;
using System.Threading;

namespace BlogDuLich.Models
{
    public class Blog
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ImageUrl { get; set; }
        public string Description { get; set; }
        public DateTime Time { get; set; }

        public DateTime Year { get; set; }
        public string CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public string Status { get; set; }

        public int CategoryId { get; set; }
        public Category Category { get; set; }

        public int RegionId { get; set; }
        public Region Region { get; set; }






    }
}
