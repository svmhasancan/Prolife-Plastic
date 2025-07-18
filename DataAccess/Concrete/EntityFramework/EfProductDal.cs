using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System.Collections.Generic;
using System.Linq;

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
                             select new ProductDetailDto
                             {
                                 ProductName = p.Name,
                                 CategoryName = c.Name,
                                 Description = p.Description,
                                 // Görsel ve diğer alanlar eklenebilir
                             };

                return result.ToList();
            }
        }
    }
}