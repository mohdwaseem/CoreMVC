using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreMVC.Models.ViewModels
{
    public class ViewLogVM
    {
        public List<LogModel> Logs { get; set; }
        public List<Contract> Contracts { get; set; }
    }
}
