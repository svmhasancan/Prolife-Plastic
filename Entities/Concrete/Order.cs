using System;
using System.Collections.Generic;
using Core.Entities;

namespace Entities.Concrete
{
    public class Order : IEntity
    {
        public int Id { get; set; }
        public string CustomerName { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public DateTime CreatedAt { get; set; }

        // Navigation property: Bu siparişteki tüm ürünler (sepet elemanları)
        public ICollection<CartItem> CartItems { get; set; }
    }
} 