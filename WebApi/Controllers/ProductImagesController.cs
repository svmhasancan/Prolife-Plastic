using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductImagesController : Controller
    {
        private IProductImageService _productImageService;

        public ProductImagesController(IProductImageService productImageService)
        {
            _productImageService = productImageService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _productImageService.GetAll();

            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest();
        }

        [HttpPost("upload")]
        public IActionResult Upload(IFormFile file,ProductImage productImage)
        {
            var result = _productImageService.Add(file, productImage);

            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest();
        }

        [HttpPost("update")]
        public IActionResult Update(IFormFile file , ProductImage productImage) 
        {
            var result = _productImageService.Update(file, productImage);

            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest();
        }

        [HttpPost("delete")]
        public IActionResult Delete(ProductImage productImage)
        {
            var result = _productImageService.Delete(productImage);

            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest();
        }
    }
}