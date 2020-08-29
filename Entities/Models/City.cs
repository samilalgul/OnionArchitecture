using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace LoginProject1.Entities.Models
{
    public class City
{
        public City()
        {
            Restaurants = new Collection<Restaurant>();
        }
        [Required]
        public int CityID { get; set; }
        public string CityName { get; set; }
        public string ImagePath { get; set; }
        
        public ICollection<Restaurant> Restaurants { get; set; }
        //public ICollection<CityRestaurant> CityRestaurants { get; set; }
    }
}
