namespace No5.Solution
{
    public class Hyperlink : IDocumentPart
    {
        public string Text { get; set; }
        public string Url { get; set; }
        public void Accept(IVisitor visitor)
        {
            visitor.VisitHyperlink(this);
        }
    }
}
