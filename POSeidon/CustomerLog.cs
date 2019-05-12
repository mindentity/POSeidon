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
