using System;

namespace POSeidon
{
    public class Currency
    {
        public string Name { get; set; }
        public string Symbol { get; set; }

        public override string ToString()
        {
            return String.Format("{0} ({1})", Name, Symbol);
        }
    }
}
