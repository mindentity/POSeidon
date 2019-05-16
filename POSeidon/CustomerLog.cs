namespace POSeidon
{
    public class CustomerLog : Log
    {
        public override LogType Type
        {
            get { return LogType.Customer;  }
        }
        public string ProductName { get; set; }
        public decimal ProductPrice { get; set; }
        public double ProductAmount { get; set; }
        public decimal ProductTotalPrice { get; set; }
        public bool IsProductCountable { get; set; }
        public string CustomerFirstName { get; set; }
        public string CustomerLastName { get; set; }
        public string CustomerPhone { get; set; }
        public string CustomerEmail { get; set; }
        public string CustomerAddress { get; set; }
    }
}
