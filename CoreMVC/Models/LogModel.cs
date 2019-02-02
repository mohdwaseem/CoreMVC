using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreMVC.Models
{
    public class LogModel
    {
        public int Id { get; set; }
        public string Message { get; set; }
        public string ContractId { get; set; }
        public DateTime LogDate { get; set; }
    }
}
