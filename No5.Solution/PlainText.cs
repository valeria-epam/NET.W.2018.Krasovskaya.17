namespace No5.Solution
{
    public class PlainText : IDocumentPart
    {
        public string Text { get; set; }
        public void Accept(IVisitor visitor)
        {
            visitor.VisitPlainText(this);
        }
    }
}
