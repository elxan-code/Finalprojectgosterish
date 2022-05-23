using Finalproject.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Finalproject.ViewModels
{
    public class VmFeatures
    {
        public int ProductId { get; set; }
        public string FeatureMain { get; set; }
        public string FeatureChild { get; set; }
        public List<SubFeature> SubFeatures { get; set; }
        public List<ProductFature> ProductFatures { get; set; }

    }
}
