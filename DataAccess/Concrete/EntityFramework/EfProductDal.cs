using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfProductDal : EfEntityRepositoryBase<Product, ProlifePlasticContext>, IProductDal
    {
        public List<ProductDetailDto> GetProductDetails()
        {
            using (var context = new ProlifePlasticContext())
            {
                var result = from p in context.Products
                             join c in context.Categories on p.CategoryId equals c.Id
                             join b in context.Brands on p.BrandId equals b.Id
                             select new ProductDetailDto
                             {
                                 ProductName = p.Name,
                                 CategoryName = c.Name,
                                 BrandName = b.Name,
                                 IsInStock = p.IsInStock,
                                 UnitPrice = p.UnitPrice,
                                 Description = p.Description,
                                 ProductImages = context.ProductImages
                                     .Where(pi => pi.ProductId == p.Id && pi.ImagePath != null)
                                     .Select(pi => pi.ImagePath)
                                     .ToList()
                             };

                return result.ToList();
            }
        }
    }
}