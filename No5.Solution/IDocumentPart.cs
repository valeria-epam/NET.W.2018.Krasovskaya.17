namespace No5.Solution
{
    public interface IDocumentPart
    {
        void Accept(IVisitor visitor);
    }
}
