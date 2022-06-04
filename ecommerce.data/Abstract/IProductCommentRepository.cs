using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ecommerce.entity;

namespace ecommerce.data.Abstract
{
    public interface IProductCommentRepository: IRepository<ProductComment>
    {
        void AddProductComment(ProductComment comment);
        List<ProductComment> GetProductComment(Product product);
    }
}