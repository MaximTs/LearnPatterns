using System;

namespace LearnPatterns.Strategy
{
    class VodafoneDocumentCreator : IDocumentCreator
    {
        private readonly string _documentString;

        public VodafoneDocumentCreator(string documentString)
        {
            _documentString = documentString;
        }

        public Document CreateDocument()
        {
            int.TryParse(_documentString, out int id);

            var doc = new Document
            {
                DocumentName = "Vodafone",
                Id = id
            };
            return doc;
        }
    }
}
