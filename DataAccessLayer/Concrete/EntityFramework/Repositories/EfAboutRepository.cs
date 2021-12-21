using DataAccessLayer.Abstract.Repositories;
using DataAccessLayer.Repositories;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete.EntityFramework.Repositories
{
    public class EfAboutRepository : GenericRepository<About>, IAboutDal
    {
    }
}
