using Domain.DTOs;
using Domain.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Domain.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductController : ControllerBase
    {
        private readonly IProductServices _svc;

        public ProductController(IProductServices svc)
        {
            _svc = svc;
        }
        [HttpGet]
        public ActionResult<IEnumerable<ProductDto>> GetAll()
        {
            var products = _svc.GetAll();
            return Ok(products);
        }   
    }
}
