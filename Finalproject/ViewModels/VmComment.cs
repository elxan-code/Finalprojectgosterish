using Finalproject.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Finalproject.ViewModels
{
    public class VmComment
    {
        public List<Comment> Comments { get; set; }
        public Comment Comment { get; set; }
        public Product Products{ get; set; }

    }
}
