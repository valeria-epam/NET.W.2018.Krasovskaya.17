using System;

namespace No2.Solution
{
    public class Bank
    {
        private readonly Stock _stock;
        public string Name { get; set; }

        public Bank(string name, Stock stock)
        {
            _stock = stock;
            this.Name = name;
        }

        public void Register()
        {
            _stock.MarketCompleted += OnMarketCompleted;
        }

        public void Unregister()
        {
            _stock.MarketCompleted -= OnMarketCompleted;
        }

        private void OnMarketCompleted(object sender, MarketEventArgs e)
        {
            Console.WriteLine(e.Euro > 40
                ? $"Bank {this.Name} sells euros; Euro rate:{e.Euro}"
                : $"Bank {this.Name} is buying euros; Euro rate: {e.Euro}");
        }
    }
}
