/* build-in modules */
using System;
using System.Collections.Generic;


/* internal modules */

using CarpenterOrdersManagmentSystem.Models.Grpc;

namespace CarpenterOrdersManagmentSystem.Repositories
{

    public class OrdersRepository()
    {
        private List<UserProductOrderEntity> UserOrders = new List<UserProductOrderEntity>();
        
        public bool AddProductOrder(UserProductOrderEntity order){
            if( this.UserOrders.Exists( o => o.OrderId.Equals(order.OrderId) ) )
            {
                return false;
            }

            this.UserOrders.Add(order);

            return true;
        }
    }
}