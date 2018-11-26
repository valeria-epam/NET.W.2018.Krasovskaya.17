using System;

namespace No2.Solution
{
    public class Broker
    {
        private readonly Stock _stock;
        public string Name { get; set; }

        public Broker(string name, Stock stock)
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
            Console.WriteLine(e.USD > 30
                ? $"Broker {this.Name} sells dollars; Dollar rate: {e.USD}"
                : $"Broker {this.Name} buys dollars; Dollar rate: {e.USD}");
        }
    }
}
