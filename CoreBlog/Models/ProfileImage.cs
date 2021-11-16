using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace CoreBlog.Models
{
    public class ProfileImage
    {
        public void Profile(IFormFile formFile, out string fileName)
        {
            var extension = Path.GetExtension(formFile.FileName);
            var imageName = Guid.NewGuid() + extension;
            var location = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/image/", imageName);
            var stream = new FileStream(location, FileMode.Create);
            formFile.CopyTo(stream);
            fileName = formFile.FileName;
        }

        //public int WriterId { get; set; }
        //public string FullName { get; set; }
        //public string About { get; set; }
        //public IFormFile Image { get; set; }
        //public string Mail { get; set; }
        //public string Password { get; set; }
        //public string RPassword { get; set; }
        //public DateTime CreateDate { get; set; }
        //public bool IsActive { get; set; }
    }
}
