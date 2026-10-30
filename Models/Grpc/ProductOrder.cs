using System.Diagnostics.CodeAnalysis;

namespace CarpenterOrdersManagmentSystem.Models.Grpc
{

    public class ProductOrder
    {

        [SetsRequiredMembers]
        public ProductOrder(string productId, uint unit) => 
            (ProductId, Unit) = (productId, unit);

        public required string ProductId {get; init;}
        public required uint Unit {get; init;}
    }

}

