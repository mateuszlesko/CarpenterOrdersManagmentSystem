using System;
namespace CarpenterOrdersManagmentSystem.Models
{
    public class Order
    {
        public string OrderId {get;set;}
        public string ClientId {get;set;}
        public List<ProductOrder> Products {get; set;}
        public DateTime CreationDate {get;set;}
        public DateTime InProgressDate {get;set;}
        public DateTime RealizationDate {get;set;}
        public DateTime SendingDate {get;set;}
    }
}