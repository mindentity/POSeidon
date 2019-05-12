namespace POSeidon
{
    public class SupplierLog : Log
    {
        public override LogType Type
        {
            get { return LogType.Supplier; }
        }
        public string ProductName { get; set; }
        public double ProductAmount { get; set; }
        public string SupplierName { get; set; }
        public string SupplierPhone { get; set; }
        public string SupplierEmail { get; set; }
        public string SupplierAddress { get; set; }
    }
}
