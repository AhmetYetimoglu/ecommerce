using System.Collections.Generic;
using ecommerce.entity;

namespace ecommerce.webui.Models
{
    public class ProductDetailModel
    {
        public Product Product { get; set; }
        public List<Category> Categories { get; set; }
    }
}