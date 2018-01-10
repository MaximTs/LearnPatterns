using System;

namespace LearnPatterns.Strategy
{
    class StrategyService
    {

        private readonly Document _mainDocument;

        public StrategyService(IDocumentCreator documentCreator)
        {
            _mainDocument = documentCreator.CreateDocument();
        }

        public void CheckDocument()
        {
            if (_mainDocument.Id == 0 || string.IsNullOrEmpty(_mainDocument.DocumentName))
                throw new Exception("Entered incorrect document.");
        }

        public string GetDocumentParamsAsString()
        {
            return $"DocumentName: {_mainDocument.DocumentName}, DocumentId: {_mainDocument.Id}";
        }
    }
}
