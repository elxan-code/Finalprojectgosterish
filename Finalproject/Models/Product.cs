using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Finalproject.Models
{
    public class Product
    {
        [Key]

        public int Id { get; set; }

        [MaxLength(50)]

        public string Title { get; set; }

        [MaxLength(50)]
        public string Model { get; set; }
        [MaxLength(50)]
        public string Brand { get; set; }
        public int Stock { get; set; }
        [MaxLength(50)]

        public string Color { get; set; }
        public decimal Price { get; set; }
        public decimal? DiscountPrice { get; set; }
   
        public DateTime? DiscountDate { get; set; }
        [MaxLength(100)]
        public string Discountfaiz { get; set; }
        [ForeignKey("Category")]
        public int CategoryId { get; set; }
        public Category Category { get; set; }

        [ForeignKey("SubCategory")]
        public int SubCategoryId { get; set; }
        public SubCategory SubCategory { get; set; }

        public List<ProductToProduct> ProductToProduct { get; set; }
        public List<ProductOfProduct> ProductOfProducts { get; set; }
        public List<FeatureTitle> FeatureTitles { get; set; }

        public List<SaleItem> SaleItems { get; set; }
        public List<Comment> Comments{ get; set; }
        [NotMapped]
        public List<string> Cart1 { get; set; }
        [NotMapped]
        public List<string> Cart2 { get; set; }

    }
}
