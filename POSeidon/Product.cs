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
            get {
                WeightUnit unit = Controller.Settings.WeightUnit;
                string symbol = IsCountable ? "pcs" : Controller.Settings.WeightUnit.Symbol;
                double amount = IsCountable ? StockAmount : StockAmount / unit.Ratio;
                return $"{amount} {symbol}";
            }
        }
    }
}
