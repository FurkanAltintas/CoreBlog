using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IBlogService : IGenericService<Blog>
    {
        List<Blog> FetchCategory();
        List<Blog> FetchCategoryByWriter(int id);
        List<Blog> FetchWriter(int id);
        Blog LastPost();
        List<Blog> RecentPost(int number);
    }
}
