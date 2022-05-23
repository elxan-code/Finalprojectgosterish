using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Finalproject.Models
{
    public class SubFeature
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(50)]
        public string Feature { get; set; } 

        [ForeignKey("Category")]
        public int CategoryId { get; set; }
        public Category Category{ get; set; }
        public List<FeatureTitle> FeatureTitles { get; set; }







    }
}
