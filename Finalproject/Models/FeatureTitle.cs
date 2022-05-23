using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Finalproject.Models
{
    public class FeatureTitle
    {

        [Key]
        public int Id { get; set; }
   
        [MaxLength(100)]
        public string Title { get; set; }


        [ForeignKey("SubFeature")]
        public int SubFeatureId { get; set; }
        public SubFeature SubFeature { get; set; }

        [ForeignKey("Product")]
        public int ProductId { get; set; }
        public Product Product { get; set; }



    }
}
