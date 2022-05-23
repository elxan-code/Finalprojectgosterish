using Finalproject.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Finalproject.ViewModels
{
    public class VmTitle
    {
        public List<SubFeature> SubFeatures { get; set; }
        public FeatureTitle FeatureTitles { get; set; }

    }
}
