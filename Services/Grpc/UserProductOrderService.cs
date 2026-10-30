using Grpc.Core;

using CarpenterOrdersManagmentSystem.Services.Data;
using Microsoft.Extensions.Logging;

namespace CarpenterOrdersManagmentSystem.Services.Grpc
{

    public class UserProductOrderService(ILogger<UserProductOrderService> logger) : UserProductOrder.UserProductOrderBase
    {

        public override Task<OrderConfirmationReplyStatus> ConfrimUserProductOrder(UserProductOrderRequest request, ServerCallContext context)
        {
            Data.OrderDataService dataService = new Data.OrderDataService();

            logger.LogInformation("The message is received");

            return Task.FromResult(new OrderConfirmationReplyStatus
            {
                Status = 1
            });
        }
    }
}