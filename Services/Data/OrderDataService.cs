

using CarpenterOrdersManagmentSystem.Models.Grpc;
using CarpenterOrdersManagmentSystem.Repositories;

namespace CarpenterOrdersManagmentSystem.Services.Data
{
    public class OrderDataService()
    {

        public bool AddOrder(UserProductOrderEntity order){
            OrdersRepository repository = new OrdersRepository();
            bool result = repository.AddProductOrder(order);
            if(result)
            {
                return true;
            }
            return false;
        }
    }

}


