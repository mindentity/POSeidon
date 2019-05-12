using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace POSeidon
{
    public class Settings
    {
        public int Id { get; set; }
        public NumberFormatInfo NumberFormat { get; set; }
        public IList<Currency> AvailableCurrencies { get; set; }
        public IList<WeightUnit> AvailableWeightUnits { get; set; }
        public WeightUnit WeightUnit { get; set; }

        public Settings()
        {
            AvailableCurrencies = new List<Currency>()
            {
                new Currency { Name = "Dollar", Symbol = "$" },
                new Currency { Name = "Euro", Symbol = "€" },
                new Currency { Name = "Pound", Symbol = "£" },
                new Currency { Name = "Ruble", Symbol = "₽" },
                new Currency { Name = "Rupee", Symbol = "₹" },
                new Currency { Name = "Turkish Lira", Symbol = "₺" },
                new Currency { Name = "Yen", Symbol = "¥" }
            };
            AvailableWeightUnits = new List<WeightUnit>()
            {
                new WeightUnit { Name = "Kilogram", Symbol = "kg", Ratio = 1 },
                new WeightUnit { Name = "Gram", Symbol = "g", Ratio = 1e-3 },
                new WeightUnit { Name = "Miligram", Symbol = "mg", Ratio = 1e-6 }
            };
            WeightUnit = AvailableWeightUnits.First();
        }
    }
}
