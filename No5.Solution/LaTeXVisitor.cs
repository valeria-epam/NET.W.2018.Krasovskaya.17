namespace No5.Solution
{
    public class LaTeXVisitor : OutputVisitorBase
    {
        public override void VisitPlainText(PlainText plainText)
        {
            var result = plainText.Text;
            Builder.Append(result);
        }

        public override void VisitHyperlink(Hyperlink hyperlink)
        {
            var result = "\\href{" + hyperlink.Url + "}{" + hyperlink.Text + "}";
            Builder.Append(result);
        }

        public override void VisitBoldText(BoldText boldText)
        {
            var result = "\\textbf{" + boldText.Text + "}";
            Builder.Append(result);
        }
    }
}
