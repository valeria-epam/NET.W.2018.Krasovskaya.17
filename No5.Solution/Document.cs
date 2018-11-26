using System.Collections.Generic;

namespace No5.Solution
{
    public class Document
    {
        private readonly List<IDocumentPart> _parts = new List<IDocumentPart>();

        public void Add(IDocumentPart documentPart)
        {
            _parts.Add(documentPart);
        }

        public void Accept(IVisitor visitor)
        {
            foreach (IDocumentPart part in _parts)
            {
                part.Accept(visitor);
            }
        }
    }
}
