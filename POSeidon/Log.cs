using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POSeidon
{
    public abstract class Log
    {
        public enum LogType
        {
            Supplier,
            Customer
        }

        public int Id { get; set; }
        public abstract LogType Type { get; }
        public DateTime Date { get; set; }
    }
}
