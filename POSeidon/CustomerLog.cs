using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POSeidon
{
    public class CustomerLog : Log
    {
        public override LogType Type
        {
            get { return LogType.Customer;  }
        }
        public int CustomerId { get; set; }
        public string ProductName { get; set; }
        public double ProductPrice { get; set; }
        public double ProductAmount { get; set; }
        public bool IsProductCountable { get; set; }
    }
}
