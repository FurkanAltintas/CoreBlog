using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreBlog.Models
{
    public class CommentById
    {
        public CommentById()
        {
            CreateDate = DateTime.Now;
            IsActive = true;
        }

        public int Id { get; set; }
        public int BlogId { get; set; }
        public string UserName { get; set; }
        public string Title { get; set; }
        public string Message { get; set; }
        public DateTime CreateDate { get; set; }
        public bool IsActive { get; set; }
    }
}
