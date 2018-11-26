namespace No5.Solution
{
    public class HtmlVisitor : OutputVisitorBase
    {
        public override void VisitPlainText(PlainText plainText)
        {
            var result = plainText.Text;
            Builder.Append(result);
        }

        public override void VisitHyperlink(Hyperlink hyperlink)
        {
            var result = "<a href=\"" + hyperlink.Url + "\">" + hyperlink.Text + "</a>";
            Builder.Append(result);
        }

        public override void VisitBoldText(BoldText boldText)
        {
            var result = "<b>" + boldText.Text + "</b>";
            Builder.Append(result);
        }
    }
}
