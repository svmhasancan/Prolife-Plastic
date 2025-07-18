using System;
using Core.Entities;

namespace Entities.Concrete
{
    public class BrandaColor : IEntity
    {
        public int Id { get; set; }
        public int BrandaOptionId { get; set; }
        public string ColorName { get; set; }

        // Navigation property: Bu rengin ait olduğu branda seçeneği
        public BrandaOption BrandaOption { get; set; }
    }
} 