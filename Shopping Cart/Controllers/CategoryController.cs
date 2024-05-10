using Microsoft.AspNetCore.Mvc;
using Shopping_Cart.Services;

namespace Shopping_Cart.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ICategoryService _categoryService;
        public CategoryController(ICategoryService categoryService) 
            {
            _categoryService = categoryService;
            }
        public IActionResult Index()
        {
            var cat = _categoryService.GetAll();
            return View(cat);
        }
        
    }
}
