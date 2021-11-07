using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IStatisticService
    {
        int BlogCount();
        List<Blog> Blog();
        int BlogByWriterCount(int id);
        int Category();
    }
}
