using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LoginProject1.Entities.Models;

namespace LoginProject1.Interfaces
{
    public interface IRestaurantService: IGenericService<Restaurant>
    {
        List<Restaurant> ListRestaurant(int RestaurantID);
        
        List<Restaurant> ListAllRestaurantByCID(int CID);


    }
}
