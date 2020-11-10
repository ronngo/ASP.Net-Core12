using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogDuLich.Models
{
    public class Comments
    {
        public int CommentsID { get; set; }
        public string Name { get; set; }
        public string Content { get; set; }
        public string Status { get; set; }
    }
}
