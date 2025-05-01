using Business.Abstract;
using Business.Constans;
using Business.Constanse;
using Core.Utilities.Helpers.FileHelper;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class ProductImageManager : IProductImageService
    {
        private IProductImageDal _productImageDal;
        private IFileHelper _fileHelper;

        public ProductImageManager(IProductImageDal productImageDal, IFileHelper fileHelper)
        {
            _productImageDal = productImageDal;
            _fileHelper = fileHelper;
        }


        public IResult Add(IFormFile file, ProductImage productImage)
        {
            string root = PathConstans.ImagesPath;
            productImage.ImagePath = _fileHelper.Upload(file, root);
            productImage.Date = DateTime.Now;
            _productImageDal.Add(productImage);
            return new SuccessResult(Messages.ProductImageAdded);
        }

        public IResult Delete(ProductImage productImage)
        {
            string filePath = PathConstans.ImagesPath + productImage.ImagePath;
            _fileHelper.Delete(filePath);
            _productImageDal.Delete(productImage);
            return new SuccessResult(Messages.ProductImageDeleted);
        }
       
        public IDataResult<List<ProductImage>> GetAll()
        {
            return new SuccessDataResult<List<ProductImage>>(_productImageDal.GetAll());
        }

        public IDataResult<ProductImage> GetById(int id)
        {
            return new SuccessDataResult<ProductImage>(_productImageDal.Get(p => p.Id == id));
        }

        //public IDataResult<List<ProductImage>> GetImagesByProductId(int productId)
        //{
        //    return new SuccessDataResult<List<ProductImage>>(_productImageDal.Get(x => x.ProductId == productId));
        //}

        public IResult Update(IFormFile file, ProductImage productImage)
        {
            string root = PathConstans.ImagesPath;
            string filePath = root + productImage.ImagePath;
            productImage.ImagePath = _fileHelper.Update(file, filePath, root);
            _productImageDal.Update(productImage);
            return new SuccessResult(Messages.ProductImageUpdated);
        }
    }
}
