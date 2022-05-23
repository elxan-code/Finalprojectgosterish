using Finalproject.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Finalproject.ViewModels
{
    public class VmChat
    {
        public CustomUser Reciever { get; set; }
        public List<Chat> Messages { get; set; }

    }
}
