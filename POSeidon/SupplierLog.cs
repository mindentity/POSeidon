using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POSeidon
{
    public class SupplierLog : Log
    {
        public override LogType Type
        {
            get { return LogType.Supplier; }
        }
        public int SupplierId { get; set; }
        public string ProductName { get; set; }
        public double ProductAmount { get; set; }
    }
}
