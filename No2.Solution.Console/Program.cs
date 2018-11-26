namespace No2.Solution.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            var stock = new Stock();

            var bank = new Bank("Bank", stock);
            var broker = new Broker("Broker", stock);

            bank.Register();
            broker.Register();
            for (int i = 0; i < 5; i++)
            {
                stock.Market();
            }
            

            System.Console.ReadLine();
        }
    }
}
