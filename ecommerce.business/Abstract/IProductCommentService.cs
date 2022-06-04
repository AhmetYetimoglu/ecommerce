using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ecommerce.entity;

namespace ecommerce.business.Abstract
{
    public interface IProductCommentService
    {
        
        void AddProductComment(ProductComment comment);

        List<ProductComment> GetProductComment(Product product);
    }
}