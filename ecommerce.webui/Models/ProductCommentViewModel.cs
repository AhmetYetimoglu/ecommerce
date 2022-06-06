using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ecommerce.entity;

namespace ecommerce.webui.Models
{
    public class ProductCommentViewModel
    {
        public string Title { get; set; }
        public string UserName { get; set; }
        public Product Product { get; set; }
        public List<Category> Categories { get; set; }

        public List<ProductComment> ListOfComments { get; set; }

        public List<Product> Products { get; set; }

        public string Comment { get; set; }

        public int ProductId { get; set; }

        public int Rating { get; set; }
    }
}