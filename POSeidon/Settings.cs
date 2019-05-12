using System.Collections.Generic;
using System.Globalization;

namespace POSeidon
{
    public class Settings
    {
        public int Id { get; set; }
        public NumberFormatInfo NumberFormat { get; set; }
        public IList<Currency> AvailableCurrencies;

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
        }
    }
}
