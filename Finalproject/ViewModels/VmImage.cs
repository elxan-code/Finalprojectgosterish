using Finalproject.Models;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Finalproject.ViewModels
{
    public class VmImage
    {
        public ProductFature ProductFature { get; set; }
        public IFormFile[] Image { get; set; }
        public List<string> ImageBase64 = new List<string>();


    }
}
