﻿namespace EntityFramewokEstudos.Domain
{
    internal class OrderItem
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public Order Order { get; set; }
        public int ProductId { get; set; }
        public int Amount { get; set; }
        public decimal Value { get; set; }
        public decimal Discount { get; set; }
    }
}
