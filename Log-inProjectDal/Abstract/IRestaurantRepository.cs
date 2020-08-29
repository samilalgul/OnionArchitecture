using LoginProject1.Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace LoginProjectDal.Abstract
{
   public interface IRestaurantRepository : IGenericRepository<Restaurant>
    {
        List<Restaurant> ListRestaurant(int restaurantId);
        List<Restaurant> ListAllRestaurantByCID(int CID);
    }
}
