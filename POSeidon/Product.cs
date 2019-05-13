namespace POSeidon
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public bool IsCountable { get; set; }
        public double StockAmount { get; set; }

        public string StockAmountText
        {
            get { return $"{StockAmount} {Controller.Settings.WeightUnit.Symbol}";  }
        }
    }
}
