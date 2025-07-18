using System.Collections.Generic;
using System;
using Core.Entities;

namespace Entities.Concrete
{
    public class BrandaOption : IEntity
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int SquareMeter { get; set; } // Örn: 20, 32, 50
        public int QuantityPerBox { get; set; } // Örn: 24, 18, 12

        // Navigation property: Bu branda seçeneğine ait renkler
        public ICollection<BrandaColor> AvailableColors { get; set; }
        // Navigation property: Bu branda seçeneğinin ait olduğu ürün
        public Product Product { get; set; }
    }
} 