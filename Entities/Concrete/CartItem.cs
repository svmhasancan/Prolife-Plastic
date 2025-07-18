using System.Collections.Generic;
using System;
using Core.Entities;

namespace Entities.Concrete
{
    public class CartItem : IEntity
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int BrandaOptionId { get; set; }
        public int BoxCount { get; set; }
        public int? OrderId { get; set; }

        // Navigation property: Bu sepet elemanının ait olduğu ürün
        public Product Product { get; set; }
        // Navigation property: Bu sepet elemanının ait olduğu branda seçeneği
        public BrandaOption BrandaOption { get; set; }
        // Navigation property: Bu sepet elemanının ait olduğu sipariş
        public Order Order { get; set; }
    }
} 