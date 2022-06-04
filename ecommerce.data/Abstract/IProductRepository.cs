using System.Collections.Generic;
using ecommerce.entity;

namespace ecommerce.data.Abstract
{
    public interface IProductRepository: IRepository<Product>
    {
       Product GetProductDetails(string url);
       Product GetByIdWithCategories(int id);
       List<Product> GetProductsByCategory(string name,int page,int pageSize, string orderby);
       List<Product> GetSearchResult(string searchString);
       List<Product> GetHomePageProducts();
       int GetCountByCategory(string category);
       void Update(Product entity, int[] categoryIds);

    }
}