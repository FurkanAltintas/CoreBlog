using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreBlog.Models
{
    public class NewsletterById
    {
        public int NewsletterId { get; set; }
        public int BlogId { get; set; }
        public string Mail { get; set; }
    }
}
