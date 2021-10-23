using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreBlog.ViewModels
{
    public class City
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public List<City> cities = new List<City>
        {
            new City
            {
                Id = 1,
                Name = "İstanbul"
            },

            new City
            {
                Id = 2,
                Name = "İzmir"
            },

            new City
            {
                Id = 3,
                Name = "Ankara"
            },

            new City
            {
                Id = 4,
                Name = "Tokat"
            }
        };
    }
}
