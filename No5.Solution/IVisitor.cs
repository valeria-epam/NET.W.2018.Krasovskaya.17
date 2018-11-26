namespace No5.Solution
{
    public interface IVisitor
    {
        string Result { get; }

        void VisitPlainText(PlainText plainText);
        void VisitHyperlink(Hyperlink hyperlink);
        void VisitBoldText(BoldText boldText);
    }
}
