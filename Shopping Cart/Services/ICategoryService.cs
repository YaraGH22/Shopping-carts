using Shopping_Cart.Models;

namespace Shopping_Cart.Services
{
    public interface ICategoryService
    {
        IEnumerable<Category> GetAll();
    }
}
