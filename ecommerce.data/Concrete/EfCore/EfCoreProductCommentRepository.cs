using System.Linq;
using Microsoft.EntityFrameworkCore;
using ecommerce.data.Abstract;
using ecommerce.entity;
using System.Collections.Generic;

namespace ecommerce.data.Concrete.EfCore
{
    public class EfCoreProductCommentRepository: EfCoreGenericRepository<ProductComment, ShopContext>, IProductCommentRepository
    {
        public void AddProductComment(ProductComment comment)
        {
            using (var context = new ShopContext())
            {
                context.ProductComments.Add(comment);
                context.SaveChanges();
            }
        }
        public List<ProductComment> GetProductComment(Product product)
        {
            using (var context = new ShopContext())
            {
                return context.ProductComments.Where( d=> d.ProductId.Equals(product.ProductId)).ToList();
            }
        }
    }
}