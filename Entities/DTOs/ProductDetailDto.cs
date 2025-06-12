using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs
{
    public class ProductDetailDto:IDto
    {
        public string ProductName { get; set; }
        public string CategoryName { get; set; }
        public string BrandName { get; set; }
        public bool IsInStock { get; set; }
        public decimal UnitPrice { get; set; }
        public List<string> ProductImages { get; set; }
        public string? Description { get; set; }
    }
}
