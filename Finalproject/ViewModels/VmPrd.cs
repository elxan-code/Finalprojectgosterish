using Finalproject.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Finalproject.ViewModels
{
    public class VmPrd
    {
        public Product Product { get; set; }
        public List<VmFeatures> VmFeatures { get; set; }
        public List<VmImage> VmImages { get; set; }
    }
}
