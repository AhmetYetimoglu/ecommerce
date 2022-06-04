using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ecommerce.entity
{
    public class ProductComment
    {
        public int Id { get; set; }

        public string UserName { get; set; }
        public string Comments { get; set; }

        public DateTime PublishedDate { get; set; }

        public int Rating { get; set; }

        public int ProductId { get; set; }
        [ForeignKey("ProductId")]
        public Product Products { get; set; }
    }
}
