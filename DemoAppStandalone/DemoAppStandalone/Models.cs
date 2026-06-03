using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoAppStandalone
{
    public static class AuthInfo
    {
        public enum UserRole { Guest, Client, Manager, Administrator };
        public static UserRole Role { get; set; } = UserRole.Guest;
        public static string UserName = "Гость";
    }

    public class Product
    {
        public int Id { get; set; }
        public string Article {  get; set; }
        public string Name { get; set; }
        public string Unit { get; set; } = "шт.";
        public decimal Price { get; set; }
        public string Description { get; set; }
        public string Supplier { get; set; }
        public string Manufacturer { get; set; }
        public string Category { get; set; }
        public decimal Discount { get; set; }
        public int Stock { get; set; }
        public string Photo { get; set; }
    }

    public class OrderPositions
    {
        public int OrderPositionId { get; set; }
        public int ProductId { get; set; }
        public int OrderId { get; set; }
        public int Amount { get; set; }
    }

    public class Orders
    {
        public int OrderId { get; set; }
        public string Article { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime DeliveryDate { get; set; }
        public int PUPId { get; set; }
        public string Surname { get; set; }
        public string Name { get; set; }
        public string Patronymic { get; set; }
        public int DeliveryCode { get; set; }
        public string Status { get; set; }
    }

    public class PickUpPoint
    {
        public int PUPId { get; set; }
        public int Index { get; set; }
        public string City { get; set; }
        public string Address { get; set; }
        public string House { get; set; }
    }

    public class  OrderView
    {
        public int OrderId { get; set; }
        public int PUPId { get; set; }
        public string FullAddress { get; set; }
        public string Article { get; set; }
        public string Status { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime DeliveryDate { get; set; }

    }
}
