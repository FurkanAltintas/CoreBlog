using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Writer
    {
        [Key]
        public int WriterId { get; set; }
        public string FullName { get; set; }
        public string About { get; set; }
        public string Image { get; set; }
        public string Mail { get; set; }
        public string Password { get; set; }
        public string RPassword { get; set; }
        public DateTime CreateDate { get; set; }
        public bool IsActive { get; set; }
        public List<Blog> Blog { get; set; }

        public virtual ICollection<Message> SenderMessage { get; set; }
        public virtual ICollection<Message> ReceiverMessage { get; set; }
    }
}
