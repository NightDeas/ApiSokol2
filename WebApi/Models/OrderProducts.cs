﻿namespace WebApi.Models
{
    public class OrderProducts
    {
        public Guid Id { get; set; }
        public Guid OrderId { get; set; }
        public Guid ProductId { get; set; }
        public int ProductCount { get; set; }

        public Order Order { get;set; }
        public Product Product { get;set; }
    }
}
