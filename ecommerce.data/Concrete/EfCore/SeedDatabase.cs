using System.Linq;
using Microsoft.EntityFrameworkCore;
using ecommerce.entity;
using System.Collections.Generic;

namespace ecommerce.data.Concrete.EfCore
{
    public static class SeedDatabase
    {
        public static void Seed()
        {
            var context = new ShopContext();

            if (context.Database.GetPendingMigrations().Count() == 0)
            {
                if (context.Categories.Count() == 0)
                {
                    context.Categories.AddRange(Categories);
                }

                if (context.Products.Count() == 0)
                {
                    context.Products.AddRange(Products);
                    context.AddRange(ProductCategories);
                }
            }
            context.SaveChanges();
        }

        private static Category[] Categories = {
            new Category(){Name="Ekran Kartı",Url="Ekran Kartı"},
            new Category(){Name="İşlemci",Url="İşlemci"},
            new Category(){Name="RAM",Url="RAM"},
            new Category(){Name="Anakart",Url="Anakart"}
        };

        private static Product[] Products = {
            new Product(){Name="GTX 1660S",Url="1660S",Price=2000,ImageUrl="1660S.jpg",Description="iyi telefon", IsApproved=true},
            new Product(){Name="GTX 1660TI",Url="1660TI",Price=3000,ImageUrl="1660TI.jpg",Description="iyi telefon", IsApproved=false},
            new Product(){Name="RTX 2060",Url="2060",Price=4000,ImageUrl="2060.jpg",Description="iyi telefon", IsApproved=true},
            new Product(){Name="RTX 3070TI",Url="3070TI",Price=5000,ImageUrl="3070TI.jpg",Description="iyi telefon", IsApproved=false},
            new Product(){Name="AMD 6700XT",Url="6700XT",Price=6000,ImageUrl="6700XT.jpg",Description="iyi telefon", IsApproved=true},
            new Product(){Name="AMD 6500XT",Url="6500XT",Price=6000,ImageUrl="6500XT.jpg",Description="iyi telefon", IsApproved=true},
            new Product(){Name="AMD 6800XT",Url="6800XT",Price=6000,ImageUrl="6800XT.jpg",Description="iyi telefon", IsApproved=true},

        };

        private static ProductCategory[] ProductCategories={
            new ProductCategory(){Product=Products[0],Category=Categories[0]},
            new ProductCategory(){Product=Products[0],Category=Categories[2]},
            new ProductCategory(){Product=Products[1],Category=Categories[0]},
            new ProductCategory(){Product=Products[1],Category=Categories[2]},
            new ProductCategory(){Product=Products[2],Category=Categories[0]},
            new ProductCategory(){Product=Products[2],Category=Categories[2]},
            new ProductCategory(){Product=Products[3],Category=Categories[0]},
            new ProductCategory(){Product=Products[3],Category=Categories[2]},
            new ProductCategory(){Product=Products[4],Category=Categories[0]},
            new ProductCategory(){Product=Products[5],Category=Categories[0]},
            new ProductCategory(){Product=Products[6],Category=Categories[0]},
        };
    }
}