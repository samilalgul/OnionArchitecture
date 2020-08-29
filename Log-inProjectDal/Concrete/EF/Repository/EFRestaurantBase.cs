using LoginProject1.Entities.Models;
using LoginProjectDal.Abstract;
using LoginProjectDal.Concrete.EF.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace LoginProjectDal.Concrete.EF.Repository
{
    public class EFRestaurantBase : EFGenericBase<Restaurant>, IRestaurantRepository
    {
        private RestaurantDBContext RestaurantDBContext
        {
            get { return dBContext as RestaurantDBContext; }
        }

        /*public EFRestaurantBase(RestaurantDBContext context)
  : base(context)
        { }*/
        //IRestaurantRepository method inherited
        public List<Restaurant> ListAllRestaurantByCID(int CID)
        {
            throw new NotImplementedException();
        }


        public List<Restaurant> ListRestaurant(int restaurantId)
        {
            throw new NotImplementedException();
        }
    }
}
