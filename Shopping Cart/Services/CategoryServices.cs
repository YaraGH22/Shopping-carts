using Shopping_Cart.Data;
using Shopping_Cart.Models;

namespace Shopping_Cart.Services
{
    public class CategoryServices : ICategoryService
    {
        private readonly ApplicationDbContext _dbContext;
        public CategoryServices(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;

        }

        public IEnumerable<Category> GetAll()
        {
            var items = _dbContext.categories.ToList();
            return items;
        }

    }
}
