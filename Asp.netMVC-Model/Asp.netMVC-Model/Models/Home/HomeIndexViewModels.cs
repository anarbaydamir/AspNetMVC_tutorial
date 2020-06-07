using System;
using System.Collections.Generic;
using Asp.netMVCModel.Entity;

namespace Asp.netMVCModel.Models
{
    public class HomeIndexViewModels
    {
        public List<Projects> projects { get; set; }

        public List<Users> users { get; set; }
    }
}
