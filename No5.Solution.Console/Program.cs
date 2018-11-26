namespace No5.Solution.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            var document = new Document();
            document.Add(new Hyperlink() { Text = "Text", Url = "https://github.com" });
            document.Add(new BoldText() { Text = "Text"});
            document.Add(new PlainText() { Text = "Text"});

            var htmlVisitor = new HtmlVisitor();
            document.Accept(htmlVisitor);
            System.Console.WriteLine(htmlVisitor.Result);

            var laTeXVisitor = new LaTeXVisitor();
            document.Accept(laTeXVisitor);
            System.Console.WriteLine(laTeXVisitor.Result);

            var plainTextVisitor = new PlainTextVisitor();
            document.Accept(plainTextVisitor);
            System.Console.WriteLine(plainTextVisitor.Result);

            System.Console.ReadLine();
        }
    }
}
