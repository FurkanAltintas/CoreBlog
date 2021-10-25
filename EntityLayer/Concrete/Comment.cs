using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Comment
    {
        public Comment()
        {
            CreateDate = DateTime.Now;
            IsActive = false;
        }

        [Key]
        public int CommentId { get; set; }
        public string UserName { get; set; }
        public string Title { get; set; }
        public string Message { get; set; }
        public DateTime CreateDate { get; set; }
        public bool IsActive { get; set; }

        public int BlogId { get; set; }
        public Blog Blog { get; set; }
    }
}
