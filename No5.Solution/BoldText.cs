namespace No5.Solution
{
    public class BoldText : IDocumentPart
    {
        public string Text { get; set; }
        public void Accept(IVisitor visitor)
        {
            visitor.VisitBoldText(this);
        }
    }
}
