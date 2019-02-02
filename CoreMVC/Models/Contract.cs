using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreMVC.Models
{
    public class Contract
    {
        public int Id { get; set; }
        public string ContractId { get; set; }
        public string BankId { get; set; }
        public DateTime CreatedOn { get; set; }
    }
}
