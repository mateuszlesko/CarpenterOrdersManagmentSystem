
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace CarpenterOrdersManagmentSystem.Models.Grpc
{
    public class UserProductOrderEntity : IEquatable<UserProductOrderEntity>
    {   

        [SetsRequiredMembers]
        public UserProductOrderEntity(string orderId, string clientId, List<ProductOrder> products) => 
            (OrderId, ClientId, Products) = (orderId, clientId, products);

        public string OrderId {get;set;}
        public string ClientId {get;set;}
        public List<ProductOrder> Products {get; set;}

        public override bool Equals(object obj)
        {
            if(obj == null) return false;

            UserProductOrderEntity objAsUPO = obj as UserProductOrderEntity;
            if(objAsUPO == null) return false;
            else return this.Equals(objAsUPO);
        }

        public override int GetHashCode()
        {
            return this.OrderId.GetHashCode();
        }

        private bool compare_instances(UserProductOrderEntity other){
            bool equal = true;
            equal &= this.OrderId.Equals(other.OrderId);
            equal &= this.ClientId.Equals(other.ClientId);
            return equal;
        }

        public bool Equals(UserProductOrderEntity other)
        {
            if (other == null) return false;
            return this.compare_instances(other);
        }

    }
}



