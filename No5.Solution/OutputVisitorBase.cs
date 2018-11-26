using System.Text;

namespace No5.Solution
{
    public abstract class OutputVisitorBase : IVisitor
    {
        protected StringBuilder Builder { get; } = new StringBuilder();
        public string Result => Builder.ToString();
        public abstract void VisitPlainText(PlainText plainText);
        public abstract void VisitHyperlink(Hyperlink hyperlink);
        public abstract void VisitBoldText(BoldText boldText);
    }
}