using System;

namespace LearnPatterns.Strategy
{
    class VostokDocumentCreator : IDocumentCreator
    {
        public Document CreateDocument()
        {
            var rnd = new Random();

            var doc = new Document
            {
                DocumentName = "Vostok",
                Id = rnd.Next()
            };
            return doc;
        }
    }
}
