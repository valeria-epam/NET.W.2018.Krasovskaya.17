namespace No5.Solution
{
    public class PlainTextVisitor : OutputVisitorBase
    {
        public override void VisitPlainText(PlainText plainText)
        {
            var result = plainText.Text;
            Builder.Append(result);
        }

        public override void VisitHyperlink(Hyperlink hyperlink)
        {
            var result = hyperlink.Text + " [" + hyperlink.Url + "]";
            Builder.Append(result);
        }

        public override void VisitBoldText(BoldText boldText)
        {
            var result = "**" + boldText.Text + "**";
            Builder.Append(result);
        }
    }
}
