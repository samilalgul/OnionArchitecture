using LoginProject1.Entities.Models;
using LoginProject1.Interfaces;
using LoginProjectDal.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LoginProject1.BLL
{
    public class RestaurantManager:GenericManager<Restaurant>,IRestaurantService
    {
        IRestaurantRepository restaurantRepository;

        public RestaurantManager(IRestaurantRepository restaurantRepository): base(restaurantRepository)
        {
            this.restaurantRepository = restaurantRepository;
        }

        public List<Restaurant> ListAllRestaurantByCID(int CID)
        {
            return restaurantRepository.ListAllRestaurantByCID(CID);
        }

        public List<Restaurant> ListRestaurant(int RestaurantID)
        {
            return restaurantRepository.ListRestaurant(RestaurantID);
        
        }
    }
}
