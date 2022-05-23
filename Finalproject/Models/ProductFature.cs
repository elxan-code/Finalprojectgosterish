using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Finalproject.Models
{
    public class ProductFature
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(100)]
        public string FeatureMain { get; set; }

        [MaxLength(100)]
        public string FeatureChild { get; set; }
        [ForeignKey("ProductOfProduct")]
        public int ProductOfProductId { get; set; }
        public ProductOfProduct ProductOfProduct { get; set; }


    }



}
