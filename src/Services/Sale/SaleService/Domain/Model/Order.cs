using System;
using System.Collections.Generic;
using N8T.Domain;

namespace SaleService.Domain.Model
{
    public class Order : EntityBase, IAggregateRoot
    {
        public Guid Id { get; set; }
        public string CustomerId { get; set; } = default!;
        public string CustomerFullName { get; set; } = default!;
        public string CustomerEmail { get; set; } = default!;
        public string CustomerAddress { get; set; } = default!;
        public OrderStatus OrderStatus { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime? CompleteDate { get; set; }
        public string StaffFullName { get; set; } = "admin";
        public ICollection<OrderItem> OrderItems { get; set; }
    }
}
