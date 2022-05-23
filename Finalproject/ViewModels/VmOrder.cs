using Finalproject.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Finalproject.ViewModels
{
    public class VmOrder
    {
        public CustomUser CustomUser { get; set; }
        public List<Product> Products { get; set; }
        public List<Sale> Sales { get; set; }

    }
}
