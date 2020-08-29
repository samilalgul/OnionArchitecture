using System;
using System.Collections.Generic;
using System.Text;

namespace LoginProject1.Entities.Models
{
    public class Restaurant
{
        public int ResID { get; set; }
        public string ResName { get; set; }
        public int CID { get; set; }

        public City City { get; set; }

        //public ICollection<CityRestaurant> CityRestaurants { get; set; }
    }
}
