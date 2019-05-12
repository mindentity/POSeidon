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
