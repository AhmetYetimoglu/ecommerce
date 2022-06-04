using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ecommerce.business.Abstract;
using ecommerce.entity;
using ecommerce.data.Abstract;


namespace ecommerce.business.Concrete
{
    public class ProductCommentManager : IProductCommentService
    {
        private IProductCommentRepository _productCommentRepository;
        public ProductCommentManager(IProductCommentRepository productCommentRepository)
        {
            _productCommentRepository = productCommentRepository;
        }
        public List<ProductComment> GetProductComment(Product product)
        {
            return _productCommentRepository.GetProductComment(product);
        }
        public void AddProductComment(ProductComment comment)
        {
            // iş kuralları
            _productCommentRepository.AddProductComment(comment);
        }
    }
}